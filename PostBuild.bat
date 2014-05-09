echo "xcopy %TF_BUILD_BINARIESDIRECTORY%\CoreTweet.dll %TF_BUILD_SOURCESDIRECTORY%\CoreTweet\bin\Debug\"
xcopy "%TF_BUILD_BINARIESDIRECTORY%\CoreTweet.dll" "%TF_BUILD_SOURCESDIRECTORY%\CoreTweet\bin\Debug\" /S 
echo "dir"
dir %TF_BUILD_SOURCESDIRECTORY%\tools
echo "nuget"
"%TF_BUILD_SOURCESDIRECTORY%\tools\NuGet.exe" pack "%TF_BUILD_SOURCESDIRECTORY%\CoreTweet\CoreTweet.csproj" -BasePath "$(TargetDir)." -verbosity detailed -OutputDirectory "$(TargetDir)."

