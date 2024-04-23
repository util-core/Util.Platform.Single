$version = 'v1'

Write-Host "docker rm..."
docker rm -f util.platform.api
docker rmi -f util.platform.api:$version

Write-Host "docker build..."
docker build -t util.platform.api:$version -f ../src/Util.Platform.Api/Dockerfile ..

Write-Host "docker run..."
docker run -d --name util.platform.api -p 16200:80 -e ASPNETCORE_HTTP_PORTS=80 util.platform.api:$version