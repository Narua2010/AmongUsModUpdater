Add-Type -AssemblyName System.IO.Compression.FileSystem    
            
function Unzip
{
    param([string]$zipfile, [string]$outpath)
    Expand-Archive -Path $zipfile -DestinationPath $outpath -Force
}
 
Write-Host "Among Us Mod Updater created by Jolle & Narua"

Write-Host "Old files will be deleted ..."
if (Test-Path "./mono") {
    Remove-Item "./mono" -Recurse
    
}
if(Test-Path "./BepInEx"){
    Remove-Item "./BepInEx" -Recurse
}

Write-Host "`n `n `n `n Please Wait ..."

$request = 'https://api.github.com/repos/Eisbison/TheOtherRoles/releases/latest'
$Jsontest = Invoke-RestMethod $request
$JSONDownload = Write-Output $Jsontest.assets.browser_download_url

Invoke-WebRequest -Uri $JSONDownload -OutFile .\otherroles.zip

Write-Host "Please Wait ..."

Unzip ".\otherroles.zip" "."

$exefile = ""

Try{ 
    $exefile = Get-Childitem -Path ".\Among Us.exe" -ErrorAction Stop -Include *.exe -Recurse
    }
    catch [System.Exception]{
     Write-Host "Among Us.exe not found ... Check game directory for Among Us.exe ..."
     Start-Sleep 10
}

if("$($exefile)" -ne ""){
    Write-Host "$($exefile)"
    Start-Process -FilePath "$($exefile)"
    Write-Host "Game is starting..."
    Start-Sleep 10
    Write-Host "After fresh update game loads slower ..."
    Start-Sleep 10
}


