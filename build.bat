@echo off
SET VS_PATH=C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE
SET PATH=%PATH%;%VS_PATH%

devenv.com .\SsKeywordExtractor\SsKeywordExtractor.sln /build Debug 

robocopy .\SsKeywordExtractor\SsKeywordExtractor\bin\Debug .\ SsKeywordExtractor.exe

timeout /t 3