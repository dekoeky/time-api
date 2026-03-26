# time-api

## Publish From CLI

```powershell
# Windows ARM64 Profile
dotnet publish -p:PublishProfile=Properties/PublishProfiles/win-arm64.pubxml

# Windows x64 Profile
dotnet publish -p:PublishProfile=Properties/PublishProfiles/win-x64.pubxml

# Windows x86 Profile
dotnet publish -p:PublishProfile=Properties/PublishProfiles/win-x86.pubxml
```



## Docker Builds

```powershell

# Prepare for multi arch builds
docker buildx create --name multiarch --driver docker-container --platform linux/arm64,linux/amd64 --bootstrap
docker buildx use multiarch
docker buildx inspect --bootstrap

# Build
docker buildx build `
    --platform linux/amd64,linux/arm64 `
    -f time-api/Dockerfile `
    -t dekoeky/time-api:dev-default-latest `
    -t dekoeky/time-api:dev-latest `
    --push .
```
