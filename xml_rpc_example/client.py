from xmlrpc.client import ServerProxy


with ServerProxy('http://localhost:8000/rpc2') as proxy:
    a = proxy.add(3, 4)
    m = proxy.mul(3, 4)
    p = proxy.pow(3, 4)

print("Server response...")
print('3+4=', a)
print('3*4=', m)
print('3^4=', p)