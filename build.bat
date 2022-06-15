mkdir build

g++ visible.cpp -o visible
g++ invisible.cpp -mwindows -o invisible
xcopy .\visible.exe .\build\ /Y
xcopy .\invisible.exe .\build\ /Y

cd GUI
dotnet build
cd bin\Debug\net6.0-windows
xcopy *.* ..\..\..\..\build\ /Y

cd ..\..\..\..\sym
dotnet build
cd bin\Debug\net6.0-windows
xcopy *.* ..\..\..\..\build\ /Y

cd ..\..\..\..
xcopy win11notepad.ico .\build\ /Y
xcopy win11settings.ico .\build\ /Y