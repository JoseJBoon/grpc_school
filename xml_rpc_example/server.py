from xmlrpc.server import SimpleXMLRPCServer, SimpleXMLRPCRequestHandler


class RequestHandler(SimpleXMLRPCRequestHandler):
    rpc_paths = ('/rpc2', )

server = SimpleXMLRPCServer(('localhost', 8000), requestHandler=RequestHandler)
server.register_introspection_functions()
server.register_function(pow)

def adder_function(x, y):
    return x+y
server.register_function(adder_function, 'add')

class MyFuncs:
    def mul(self, x, y):
        return x * y
server.register_instance(MyFuncs())

try:
    print("Starting server...")
    server.serve_forever()
except:
    print("Closing server...")


