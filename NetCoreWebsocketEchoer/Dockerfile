FROM microsoft/dotnet:2.1-runtime

WORKDIR /app

# Copy binary output files to WORKDIR in image
COPY NetCoreWebsocketEchoer/bin/Release/netcoreapp2.1/* ./

# Expose websocket port
EXPOSE 8080

ENTRYPOINT ["dotnet", "NetCoreWebsocketEchoer.dll"]

# Run this command in a command prompt window to build the image:
# docker build -t wsechoer .

# Run the image in a container with this command
# docker run -p 8080:8080 --rm wsechoer
