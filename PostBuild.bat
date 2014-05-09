echo "set"
Set
echo "xcopy %TF_BUILD_BINARIESDIRECTORY%\CoreTweet.dll %TF_BUILD_SOURCESDIRECTORY%\CoreTweet\bin\Debug\"
xcopy "%TF_BUILD_BINARIESDIRECTORY%\CoreTweet.dll" "%TF_BUILD_SOURCESDIRECTORY%\CoreTweet\bin\Debug\" /S 

