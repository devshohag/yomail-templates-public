from django.http import HttpResponse
from django.urls import path


def home(_request):
    return HttpResponse("Your Django app is running.")


urlpatterns = [path("", home)]
