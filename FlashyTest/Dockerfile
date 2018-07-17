FROM microsoft/dotnet:2.0-runtime-nanoserver-sac2016 AS base
WORKDIR /app

FROM microsoft/dotnet:2.0-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY FlashyTest/FlashyTest.csproj FlashyTest/
COPY FlashyCards.RemoteAPI.Message/FlashyCards.RemoteAPI.Message.csproj FlashyCards.RemoteAPI.Message/
COPY Flashycard/Flashycard.csproj Flashycard/
RUN dotnet restore FlashyTest/FlashyTest.csproj
COPY . .
WORKDIR /src/FlashyTest
RUN dotnet build FlashyTest.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FlashyTest.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FlashyTest.dll"]
