@echo off
setlocal
echo Building from EXE creation
REM Set the paths
set "source_dir=D:\GitHub\ProjectInstaller\bin\ProjectInstaller\unpack\dist"
set "build_dir=D:\GitHub\ProjectInstaller\bin\ProjectInstaller\unpack\build"
set "pack_dir=D:\GitHub\ProjectInstaller\bin\ProjectInstaller\pack"
set "target_dir=D:\GitHub\ProjectInstaller"

REM Check if the source file exists
if not exist "%source_dir%\main.exe" (
    echo Source file does not exist.
)

REM Move the file
move "%source_dir%\main.exe" "%target_dir%\main.exe"
ren  "%target_dir%\main.exe" "%target_dir%\installer.exe"
move "%build_dir%" "%pack_dir%"
move "%build_dir%\main.spec" "%pack_dir%\main.spec"
echo Updated
endlocal
pause