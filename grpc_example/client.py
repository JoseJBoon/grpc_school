import grpc

from .proto.calculator_pb2 import IntRequest
from .proto.calculator_pb2_grpc import CalculateStub


def run():
    print('Python client to server call')
    with grpc.insecure_channel('localhost:50051') as channel:
        stub = CalculateStub(channel)

        request = IntRequest(x=3, y=4)
        a = stub.Add(request)
        m = stub.Mul(request)
        p = stub.Pow(request)

    print('Server response')
    print('3+4=', a.result)
    print('3*4=', m.result)
    print('3^4=', p.result)


if __name__ == '__main__':
    run()
