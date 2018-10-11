from .models import Author, Book

from rest_framework import serializers


class AuthorSerializer(serializers.HyperlinkedModelSerializer):
    pass


class BookSerializer(serializers.HyperlinkedModelSerializer):
    pass