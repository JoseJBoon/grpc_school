from restart.api import RESTArt
from restart.resource import Resource


api = RESTArt()


@api.route(methods=['GET'])
class Add(Resource):
    name = 'add'

    def read(self, request):
        x = int(request.data.get('x', 0))
        y = int(request.data.get('y', 0))

        return { 'result': x + y}


@api.route(methods=['GET'])
class Mul(Resource):
    name = 'mul'

    def read(self, request):
        x = int(request.data.get('x', 0))
        y = int(request.data.get('y', 0))

        return { 'result': x * y}


@api.route(methods=['GET'])
class Pow(Resource):
    name = 'pow'

    def read(self, request):
        x = int(request.data.get('x', 0))
        y = int(request.data.get('y', 0))

        return { 'result': x ** y}