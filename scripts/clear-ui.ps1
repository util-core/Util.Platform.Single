try{
    rimraf 2>$null
}
catch{
    Write-Host "install rimraf..."
    npm install -g rimraf 
}

$project = '../src/Util.Platform.Ui/ClientApp'
Write-Host "$project : remove ..."
    rimraf $project/node_modules
    rimraf $project/.angular
    rimraf $project/dist
    rimraf $project/yarn.lock

Write-Host "remove completed."