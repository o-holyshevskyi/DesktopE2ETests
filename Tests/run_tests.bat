﻿@echo off

REM Set the base path of your project
set "basePath=C:\My Projects\desktop app\DesktopE2ETests"

REM Get the current date formatted as yyyy-MM-dd
for /f "tokens=1-4 delims=/-. " %%a in ('date /t') do (
  set "_date=%%d-%%b-%%c"
)

REM Generate the output filenames
set "testExecutionJson=TestExecution_%_date%.json"
set "outputHtml=%basePath%\Tests\TestResults\TestResult_%_date%.html"

REM Execute dotnet test command
dotnet test

REM Navigate to the directory where tests are located
cd /d "%basePath%\Tests\bin\Debug\net8.0"

REM Execute livingdoc command to generate HTML report
livingdoc test-assembly Tests.dll -t "%testExecutionJson%" -o "%outputHtml%"

REM Change directory back to the base path
cd /d "%basePath%"
