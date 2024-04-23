try{
    rimraf 2>$null
}
catch{
    Write-Host "install rimraf..."
    npm install -g rimraf
}

$version='v1'

Write-Host "docker remove..."
docker rm -f util.platform.ui
docker rmi -f util.platform.ui:$version

$path = '../src/Util.Platform.Ui/ClientApp'

Write-Host "remove dist ..."
rimraf $path/dist
rimraf ./ui/dist

Write-Host "install npm ..."
yarn --cwd $path

Write-Host "npm run build..."
yarn --cwd $path run build

Write-Host "copy dist..."
Copy-Item -Path $path/dist -Destination ./ui/dist -Recurse

Write-Host "docker build..."
docker build -t util.platform.ui:$version ./ui

Write-Host "docker run..."
docker run --name util.platform.ui -d -p 16100:80 -e IdentityUrl='http://localhost:16200' -e ApiBaseUrl='http://localhost:16200' util.platform.ui:$version