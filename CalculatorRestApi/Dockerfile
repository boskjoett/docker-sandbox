FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app

# Copy binaries from local relative path to WORKDIR in image
COPY CalculatorRestApi/bin/Release/netcoreapp2.2/publish/ ./

EXPOSE 80

ENTRYPOINT ["dotnet", "CalculatorRestApi.dll"]

# Build the solution using this command
# dotnet publish -c Release

# Run this command to build the image:
# docker build -t calculator-service .

# Run the image in a container with this command
# docker run -p 80:80 -it --name calculator-service --rm calculator-service
