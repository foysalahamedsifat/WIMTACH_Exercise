#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/MyCollegeV1.Web.Host/MyCollegeV1.Web.Host.csproj", "src/MyCollegeV1.Web.Host/"]
COPY ["src/MyCollegeV1.Web.Core/MyCollegeV1.Web.Core.csproj", "src/MyCollegeV1.Web.Core/"]
COPY ["src/MyCollegeV1.Application/MyCollegeV1.Application.csproj", "src/MyCollegeV1.Application/"]
COPY ["src/MyCollegeV1.Core/MyCollegeV1.Core.csproj", "src/MyCollegeV1.Core/"]
COPY ["src/MyCollegeV1.EntityFrameworkCore/MyCollegeV1.EntityFrameworkCore.csproj", "src/MyCollegeV1.EntityFrameworkCore/"]
RUN dotnet restore "src/MyCollegeV1.Web.Host/MyCollegeV1.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/MyCollegeV1.Web.Host"
RUN dotnet build "MyCollegeV1.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyCollegeV1.Web.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyCollegeV1.Web.Host.dll"]

