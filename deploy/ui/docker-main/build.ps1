try{
    rimraf 2>$null
}
catch{
    Write-Host "install rimraf..."
    npm install -g rimraf
}

Write-Host "docker remove..."
docker rm -f util.platform.ui.main
docker rmi -f util.platform.ui.main:v1

$path = '../../../src/Util.Platform.Ui.Main/ClientApp'

Write-Host "main: remove dist ..."
rimraf $path/dist
rimraf ./dist

Write-Host "main: install npm ..."
yarn --cwd $path

Write-Host "main: npm run build:prod..."
yarn --cwd $path run build:prod

Write-Host "main: copy dist..."
Copy-Item -Path $path/dist -Destination ./dist -Recurse

Write-Host "docker build..."
docker build -t util.platform.ui.main:v1 .

Write-Host "docker run..."
docker run --name util.platform.ui.main -d -p 16100:80 -e ManifestUrl='/assets/mf.manifest.json' -e IdentityUrl='http://localhost:16200' -e ApiBaseUrl='http://localhost:16200' util.platform.ui.main:v1