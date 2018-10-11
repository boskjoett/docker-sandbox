FROM microsoft/dotnet:2.1-runtime-nanoserver-1803
WORKDIR /app

# Copy binaries from local relative path to WORKDIR in image
COPY CalcServiceCaller/bin/Release/netcoreapp2.1/* ./

ENTRYPOINT ["dotnet", "CalcServiceCaller.dll"]

# Run this command in a command prompt window to build the image:
# docker build -t calcclient .

# Run the image in a container with this command
# docker run -it --name calcclient --rm calcclient
