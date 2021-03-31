Add-Type -AssemblyName System.IO.Compression.FileSystem    

$request = 'https://api.github.com/repos/Eisbison/TheOtherRoles/releases/latest'
$Jsontest = Invoke-RestMethod $request
$JSONDownload = Write-Output $Jsontest.assets.browser_download_url
$id = Write-Output $Jsontest.id

function Unzip
{
    param([string]$zipfile, [string]$outpath)
    Expand-Archive -Path $zipfile -DestinationPath $outpath -Force
}
 
Write-Host "Among Us Mod Updater created by Jolle & Narua"


if(Test-Path ".\version.txt"){
    $idfile = Get-Content -Path .\version.txt
    if("$($idfile)" -ne "$($id)") {
        Write-Output $Jsontest.id | Out-File -FilePath .\version.txt
        (get-item .\version.txt).Attributes += 'Hidden'
        Write-Host "Old files will be deleted ..."
        if (Test-Path "./mono") {
            Remove-Item "./mono" -Recurse
        }
        if(Test-Path "./BepInEx"){
            if(Test-Path "./BepInEx/core"){
                Remove-Item "./BepInEx/core" -Recurse
            } 
            if(Test-Path "./BepInEx/plugin"){
                Remove-Item "./BepInEx/plugin" -Recurse
            } 
            if(Test-Path "./BepInEx/unity-libs"){
                Remove-Item "./BepInEx/unity-libs" -Recurse
            }  
            if(Test-Path "./BepInEx"){
                if(Test-Path "./BepInEx/cache"){
                    Remove-Item "./BepInEx/cache" -Recurse
                } 
                if(Test-Path "./BepInEx/patchers"){
                    Remove-Item "./BepInEx/patchers" -Recurse
                } 
                if(Test-Path "./BepInEx/plugins"){
                    Remove-Item "./BepInEx/plugins" -Recurse
                }
                if(Test-Path "./BepInEx/config"){
                    if(Test-Path "./BepInEx/config/BepInEx.cfg") {
                        Remove-Item "./BepInEx/config/BepInEx.cfg" -Recurse
                    }
                    if(Test-Path "./BepInEx/config/gg.reactor.api.cfg"){
                        Remove-Item "./BepInEx/config/gg.reactor.api.cfg" -Recurse
                    }
                    if(Test-Path "./BepInEx/config/me.eisbison.theotherroles.cfg"){
                        Remove-Item "./BepInEx/config/me.eisbison.theotherroles.cfg" -Recurse
                    }
                }
            }
            Write-Host "`n `n `n `n Please Wait ..."

            Invoke-WebRequest -Uri $JSONDownload -OutFile .\otherroles.zip
            (get-item .\otherroles.zip).Attributes += 'Hidden'
            Write-Host "Please Wait ..."

            Unzip ".\otherroles.zip" "." 
        }
    }
} else {
    Write-Output $Jsontest.id | Out-File -FilePath .\version.txt
    (get-item .\version.txt).Attributes += 'Hidden'
    Write-Host "`n `n `n `n Please Wait ..."

    Invoke-WebRequest -Uri $JSONDownload -OutFile .\otherroles.zip
    (get-item .\otherroles.zip).Attributes += 'Hidden'
    Write-Host "Please Wait ..."

    Unzip ".\otherroles.zip" "." 
}

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