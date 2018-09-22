FROM microsoft/dotnet-framework:4.7.2-runtime

WORKDIR /app

# Copy binary output files to WORKDIR in image
COPY DockerTestAppNET472/bin/x64/Release/* ./

# Define environment variable
ENV MY_ENV_VAR="Hello Docker World"

ENTRYPOINT DockerTestAppNET472.exe

# Run this command in a command prompt window to build the image:
# docker build -t logger-net472 .

# Use this command to run the image in a container:
# docker run --rm logger-net472