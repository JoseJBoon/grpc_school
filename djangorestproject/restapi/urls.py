from django.conf.urls import include, url

from rest_framework import routers

from .views import AuthorViewSet, BookViewSet


router = routers.DefaultRouter()
router.register(r'authors', AuthorViewSet)
router.register(r'books', BookViewSet)

urlpatterns = [
    url(r'', include(router.urls)),
]