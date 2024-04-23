$version='v1'

Write-Host "remove docker: api..."
docker rm -f util.platform.api
docker rmi -f util.platform.api:$version

Write-Host "remove docker: ui..."
docker rm -f util.platform.ui
docker rmi -f util.platform.ui:$version