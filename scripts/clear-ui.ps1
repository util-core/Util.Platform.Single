try{
    rimraf 2>$null
}
catch{
    Write-Host "install rimraf..."
    npm install -g rimraf 
}

$projects = '../src/Util.Platform.Ui.Main/ClientApp','../src/Util.Platform.Ui.Identity/ClientApp'
foreach ($project in $projects)
{
    Write-Host "$project : remove ..."
    rimraf $project/node_modules
    rimraf $project/.angular
    rimraf $project/dist
}

Write-Host "remove completed."