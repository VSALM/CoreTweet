echo "xcopy"
xcopy ".\..\bin\CoreTweet.dll" ".\bin\Debug\" /S /Y

echo "nuget"
"$(SolutionDir)\tools\NuGet.exe" pack "$(ProjectDir)CoreTweet.csproj" -BasePath "$(TargetDir)." -verbosity detailed -OutputDirectory "$(TargetDir)."