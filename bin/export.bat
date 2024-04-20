@echo off
setlocal
echo Building from packaged EXE
set "dir=D:\GitHub\ProjectInstaller\bin\ProjectInstaller\bin\Release\net8.0-windows\publish\win-x86\ProjectInstaller.exe"
set "target_dir=D:\GitHub\ProjectInstaller"
if not exist "%dir%" (
    echo File does not exist
)
if exist "%target_dir%\ProjectInstaller.exe" (
    echo EXE already exists
    del "%target_dir%\ProjectInstaller.exe"
    echo EXE removed
)
xcopy "%dir%" "%target_dir%"
echo Updated
endlocal
pause