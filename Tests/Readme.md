# Report configuration

## Install package

```bash
dotnet add package SpecFlow.Plus.LivingDocPlugin --version 3.9.57
```

## Install CLI globally

```bash
dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
```

## Go to the dir

```bash
cd C:\work\SpecFlowCalculator\SpecFlowCalculator.Specs\bin\Debug\netcoreapp3.1
```

## To generate report

```bash
livingdoc test-assembly SpecFlowCalculator.Specs.dll -t TestExecution.json
```

# Run tests with generating report

run .bat file called `run_tests.bat`

```bash
.\run_tests.bat
```