import grpc

from .proto.calculator_pb2 import IntRequest
from .proto.calculator_pb2_grpc import CalculatorStub

def run():
    print('client to server call')
    with grpc.insecure_channel('[::]:50051') as channel:
        stub = CalculatorStub(channel)

        a = stub.Add(IntRequest(x=3, y=4))
        m = stub.Mul(IntRequest(x=3, y=4))
        p = stub.Pow(IntRequest(x=3, y=4))

    print('Server response')
    print('3+4=', a.result)
    print('3*4=', m.result)
    print('3^4=', p.result)


if __name__ == '__main__':
    run()
