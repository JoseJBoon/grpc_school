from xmlrpc.server import SimpleXMLRPCServer, SimpleXMLRPCRequestHandler


class RequestHandler(SimpleXMLRPCRequestHandler):
    rpc_paths = ('/rpc2', )

# Setup server
server = SimpleXMLRPCServer(('localhost', 8000), requestHandler=RequestHandler)
server.register_introspection_functions()

# Adding listeners to the server. 
# It can respond to proxy.pow(x, y), proxy.add(x, y) and proxy.mul(x, y)
server.register_function(pow)

def adder_function(x, y):
    return x+y
server.register_function(adder_function, 'add')

class MyFuncs:
    def mul(self, x, y):
        return x * y
server.register_instance(MyFuncs())

# Run server
try:
    print("Starting server...")
    server.serve_forever()
except:
    print("Closing server...")


