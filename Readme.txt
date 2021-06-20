cd C:\Users\kasta\OneDrive\кпи\core6.0-2
dotnet new mvc -f net6.0
dotnet run -v n
https://localhost:5001
shutt down ctrl+c
open core6.0.csproj
run

webBuilder.UseUrls("http://*:" + Environment.GetEnvironmentVariable("PORT")); 
FROM mcr.microsoft.com/dotnet/core/sdk:6.0 AS build-env
WORKDIR /app
COPY core6.0-2.csproj ./
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o out
FROM mcr.microsoft.com/dotnet/core/sdk:6.0
WORKDIR /app
COPY --from=build-env /app/out . 
ENTRYPOINT ["dotnet", "core6.0-2.dll"]

save
пересобрать
dotnet restore
heroku login
heroku container:login
docker ps -a

docker build -t counter-image-six-one -f Dockerfile .
docker ps -a
docker create --name core-counter-six-one counter-image-six-one

docker tag counter-image-six-one registry.heroku.com/app-six-two/web
docker push registry.heroku.com/app-six-two/web
heroku container:release web -a=app-six-two

heroku logs --tail -a=app-six-two