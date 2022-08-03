# dotnet-core-microservices

Simple demonstration for .net core microservices

# Technologies
- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)
- [Envoy](https://www.envoyproxy.io/docs/envoy/latest/)

# Prerequisite
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

# How to run?
- docker-compose build
- docker-compose up

# URLs to Access after running
- http://localhost:10000 gateway home
- http://localhost:10000/identity identity microservice
- http://localhost:10000/application application microservice
- http://localhost:9902 admin access
- http://localhost:5100/swagger/index.html identity microservice swagger
- http://localhost:5000/swagger/index.html application microservice swagger
