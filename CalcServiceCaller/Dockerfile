FROM microsoft/dotnet:2.1-runtime-nanoserver-1803
WORKDIR /app

# Copy binaries from local relative path to WORKDIR in image
# Remember to run this command first: dotnet publish -c release
COPY CalcServiceCaller/bin/Release/netcoreapp2.1/publish/ ./

ENTRYPOINT ["dotnet", "CalcServiceCaller.dll"]

# Run this command in a command prompt window to build the image:
# docker build -t calcclient .

# Run the image in a container with this command
# docker run -it --name calcclient --rm calcclient

# Run the Calculator API service in a container
# docker run -it --name calcapi --rm calcapi

# Run the demodb database in a container
# docker run -d -p 1433:1433 -e sa_password=ZylincHello2015 --name demodb demodb


