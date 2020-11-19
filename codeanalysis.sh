#!/bin/bash
echo "Downloading ShiftLeft Agent!"
curl -O https://www.shiftleft.io/download/sl-latest-windows-x64.zip
echo "Extracting Shiftleft Agent!"
powershell -Command "& {Expand-Archive sl-latest-windows-x64.zip -DestinationPath . ;}"
echo "Setting SL authentication parameters!"
echo "Perform Code Analysis!"
$BUILD_SOURCESDIRECTORY\\sl analyze --app Umbraco-Azure --wait --cpg --csharp --dotnet-framework --csharp2cpg-args "-l info" "$BUILD_SOURCESDIRECTORY\\src\Umbraco.sln"
sleep 10
