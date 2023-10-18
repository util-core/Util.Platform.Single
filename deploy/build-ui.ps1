Write-Host "install main..."
cd ./ui/docker-main
./build.ps1
cd ../../

Write-Host "install identity..."
cd ./ui/docker-identity
./build.ps1
cd ../../