@echo off
setlocal
bin\export.bat
bin\ProjectInstallerPY\unpack\compile.bat
bin\update.bat
endlocal
echo Updated
pause