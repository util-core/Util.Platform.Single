try{
    rimraf 2>$null
}
catch{
    Write-Host "install rimraf..."
    npm install -g rimraf
}

Write-Host "docker remove..."
docker rm -f util.platform.ui.identity
docker rmi -f util.platform.ui.identity:v1

$path = '../../../src/Util.Platform.Ui.Identity/ClientApp'

Write-Host "identity: remove dist ..."
rimraf $path/dist
rimraf ./dist

Write-Host "identity: install npm ..."
yarn --cwd $path

Write-Host "identity: npm run build:prod..."
yarn --cwd $path run build:prod

Write-Host "identity: copy dist..."
Copy-Item -Path $path/dist -Destination ./dist -Recurse

Write-Host "docker build..."
docker build -t util.platform.ui.identity:v1 .

Write-Host "docker run..."
docker run --name util.platform.ui.identity -d -p 16101:80 util.platform.ui.identity:v1