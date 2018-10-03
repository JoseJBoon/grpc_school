from concurrent import futures
import time

import grpc

from .proto.calculator_pb2 import IntResponse
from .proto.calculator_pb2_grpc import add_CalculatorServicer_to_server, CalculatorServicer

_ONE_DAY_IN_SECONDS = 60 * 60 * 24


class ResponseCalculatorServicer(CalculatorServicer):
    def Add(self, request, context):
        result = request.x + request.y
        return IntResponse(result=result)
    
    def Mul(self, request, context):
        result = request.x * request.y
        return IntResponse(result=result)

    def Pow(self, request, context):
        result = request.x ** request.y
        return IntResponse(result=result)


def serve():  
    server = grpc.server(futures.ThreadPoolExecutor(max_workers=10))
    add_CalculatorServicer_to_server(ResponseCalculatorServicer(), server)
    server.add_insecure_port('[::]:50051')

    print("Start server...")
    server.start()

    try:
        print("running...")
        while True:
            time.sleep(_ONE_DAY_IN_SECONDS)
    except KeyboardInterrupt:
        print("Closing Server...")
        server.stop(0)
    

if __name__ == "__main__":
    serve()
