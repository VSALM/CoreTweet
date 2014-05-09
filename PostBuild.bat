echo "set"
Set
echo "xcopy %TF_BUILD_BINARIESDIRECTORY%\CoreTweet.dll %TF_BUILD_SOURCESDIRECTORY%\CoreTweet\bin\Debug\"
xcopy "%TF_BUILD_BINARIESDIRECTORY%\CoreTweet.dll" "%TF_BUILD_SOURCESDIRECTORY%\CoreTweet\bin\Debug\" /S 
echo "nuget"
"%TF_BUILD_SOURCESDIRECTORY%\tools\NuGet.exe" pack "$(ProjectDir)CoreTweet.csproj" -BasePath "$(TargetDir)." -verbosity detailed -OutputDirectory "$(TargetDir)."

