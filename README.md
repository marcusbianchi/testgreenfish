# Test for Greenfish

## Requirements
To run the system in command line you will need aspnet core which can be downloaded here:
https://www.microsoft.com/net/download/
Also de database used is SQLite which can be downloaded here:
https://sqlite.org/download.html 

### Running the System
On the folder /testgreenfish run:
```
dotnet restore
dotnet run
```
### Running the Tests
To run the test on /testgreenfish.Test run:
```
dotnet restore
dotnet test
```
### Running on IIS or Other Webservices
Follow the following tutorial:
https://docs.microsoft.com/en-us/aspnet/core/publishing/?tabs=aspnetcore2x
