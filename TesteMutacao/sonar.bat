dotnet restore
dotnet tool install --global dotnet-sonarscanner
dotnet test TesteMutacao.Teste/TesteMutacao.Teste.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
dotnet sonarscanner begin /k:"LuizSD_TesteMutacao" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="48f5ad5eb42440cf9c81a0b1a7d0500d530c2b34" /d:sonar.cs.opencover.reportsPaths="TesteMutacao.Teste/coverage.opencover.xml" /d:sonar.coverage.exclusions="**Teste*.cs, **Repositorio*.cs, **Controller*.cs, **Model*.cs, **DTO*.cs, **Dto*.cs, **VO.cs, **Define*.cs"
dotnet build 
dotnet sonarscanner end /d:sonar.login="48f5ad5eb42440cf9c81a0b1a7d0500d530c2b34"
pause