from django.shortcuts import render
from django.http.response import JsonResponse

from rest_framework import viewsets


class AuthorViewSet(viewsets.ModelViewSet):
    pass


class BookViewSet(viewsets.ModelViewSet):
    pass

