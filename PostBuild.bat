echo "xcopy %TF_BUILD_BINARIESDIRECTORY%\CoreTweet.dll %TF_BUILD_SOURCESDIRECTORY%\CoreTweet\bin\Debug\"
xcopy "%TF_BUILD_BINARIESDIRECTORY%\CoreTweet.dll" "%TF_BUILD_SOURCESDIRECTORY%\CoreTweet\bin\Debug\" /S 
echo "running NuGet.exe"
"%TF_BUILD_SOURCESDIRECTORY%\tools\NuGet.exe" pack "%TF_BUILD_SOURCESDIRECTORY%\CoreTweet\CoreTweet.csproj"  -verbosity detailed -OutputDirectory "%TF_BUILD_BINARIESDIRECTORY%"

