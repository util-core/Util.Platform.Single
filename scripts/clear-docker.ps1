Write-Host "remove docker: api..."
docker rm -f util.platform.api
docker rmi -f util.platform.api:v1

Write-Host "remove docker: main..."
docker rm -f util.platform.ui.main
docker rmi -f util.platform.ui.main:v1

Write-Host "remove docker: identity..."
docker rm -f util.platform.ui.identity
docker rmi -f util.platform.ui.identity:v1