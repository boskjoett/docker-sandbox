FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803
WORKDIR /app

# Copy binaries from local relative path to WORKDIR in image
COPY bin/Release/netcoreapp2.1/* ./

EXPOSE 80

ENTRYPOINT ["dotnet", "CalculatorRestApi.dll"]

# Run this command in a command prompt window to build the image:
# docker build -t calcapi .

# Run the image in a container with this command
# docker run -p 5000:80 -it --name calcapi --rm calcapi

# docker inspect --format '{{.NetworkSettings.Networks.nat.IPAddress}}'
