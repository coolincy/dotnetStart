FROM asp31 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM sdk31 AS publish

# copy proj and restore as distinct layers
WORKDIR /src
COPY . .
RUN dotnet restore "src/AOA.AbpOnDocker.Web/AOA.AbpOnDocker.Web.csproj" \
&& dotnet restore "src/AOA.AbpOnDocker.DbMigrator/AOA.AbpOnDocker.DbMigrator.csproj"

# db migrator
WORKDIR "/src/src/AOA.AbpOnDocker.DbMigrator"
RUN dotnet run -c Release

# publish
WORKDIR "/src/src/AOA.AbpOnDocker.Web"
RUN yarn && gulp \
&& dotnet publish "AOA.AbpOnDocker.Web.csproj" -c Release -o /app/publish

# build docker image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AOA.AbpOnDocker.Web.dll"]

# docker build -t abpondocker . -f Dockerfile
# docker run --rm -it -p 44324:443 -p 8024:80 abpondocker
