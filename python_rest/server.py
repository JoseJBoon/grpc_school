from restart.api import RESTArt
from restart.resource import Resource


api = RESTArt()


@api.route(methods=['POST'])
class Add(Resource):
    name = 'add'

    def create(self, request):
        x = int(request.data.get('x', 0))
        y = int(request.data.get('y', 0))

        return { 'result': x + y}


@api.route(methods=['POST'])
class Mul(Resource):
    name = 'mul'

    def create(self, request):
        x = int(request.data.get('x', 0))
        y = int(request.data.get('y', 0))

        return { 'result': x * y}


@api.route(methods=['POST'])
class Pow(Resource):
    name = 'pow'

    def create(self, request):
        x = int(request.data.get('x', 0))
        y = int(request.data.get('y', 0))

        return { 'result': x ** y}