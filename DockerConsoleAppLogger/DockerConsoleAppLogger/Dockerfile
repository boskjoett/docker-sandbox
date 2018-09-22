FROM microsoft/dotnet:2.1-runtime-nanoserver-1803
WORKDIR /app

# Copy binaries from local relative path to WORKDIR in image
COPY bin/Release/netcoreapp2.1/publish/* ./

ENTRYPOINT ["dotnet", "DockerConsoleAppLogger.dll"]
