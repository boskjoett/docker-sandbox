# This Dockerfile shows how to create a MS SQL Server Express Docker image
# containing a database that is loaded from its data files (.mdf and .log).
# MS SQL Server Express database files are usually placed in this folder:
# C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA
# You need to detach the database in MS SQL Server Management Studio
# before you can copy the .mdf and .log files.
# This Dockerfile is made for Docker for Windows.

FROM microsoft/mssql-server-windows-express

# Create directory in image for database files
RUN mkdir C:/DbFiles

# Copy database files to image
COPY DockerDb.mdf C:/DbFiles/
COPY DockerDb_log.ldf C:/DbFiles/

# Set the SQL instance's System Administrator password (must be a strong password)
ENV SA_PASSWORD=password

# Accept the SQL Server licence agreement
ENV ACCEPT_EULA=Y

# Attach database 
ENV attach_dbs='[{"dbName":"DockerDb","dbFiles":["C:\\DbFiles\\DockerDb.mdf","C:\\DbFiles\\DockerDb_log.ldf"]}]'

# Run this command in a command prompt window to build the image:
# docker build -t demodb .

# Use this command to run the image in a container:
# docker run -d -p 1433:1433 -e sa_password=ZylincHello2015 --name demodbcontainer demodb

# Show IP address of container:
# docker inspect --format '{{.NetworkSettings.Networks.nat.IPAddress}}' demodbcontainer
# Use this IP adress when connecting to the database from MS SQL Server Management Studio.