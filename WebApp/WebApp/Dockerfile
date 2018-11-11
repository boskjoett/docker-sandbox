FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803
WORKDIR /app

# Copy binaries from local relative path to WORKDIR in image
# Remember to run this command first: dotnet publish -c release
COPY WebApp/bin/Release/netcoreapp2.1/publish/ ./

ENTRYPOINT ["dotnet", "WebApp.dll"]

# Run this command in a command prompt window to build the image:
# docker build -t webapp .

# Run the image in a container with this command
# docker run -it --name webapp --rm webapp

