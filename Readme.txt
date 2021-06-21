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
COPY zabolotnyi_zpi_zp_92_lab_kpi_3.csproj ./
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o out
FROM mcr.microsoft.com/dotnet/core/sdk:6.0
WORKDIR /app
COPY --from=build-env /app/out . 
ENTRYPOINT ["dotnet", "zabolotnyi_zpi_zp_92_lab_kpi_3.dll"]

save
пересобрать
dotnet restore
heroku login
heroku container:login
docker ps -a

docker build -t counter-image-six-two -f Dockerfile .
docker create --name core-counter-six-two counter-image-six-two
docker ps -a

docker tag counter-image-six-two registry.heroku.com/zabolotnyi-zpi-zp-92-lab-kpi-3/web
docker push registry.heroku.com/zabolotnyi-zpi-zp-92-lab-kpi-3/web
heroku container:release web -a=zabolotnyi-zpi-zp-92-lab-kpi-3

heroku logs --tail -a=zabolotnyi-zpi-zp-92-lab-kpi-3