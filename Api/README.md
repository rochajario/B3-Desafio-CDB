<h1 align="center">DESAFIO - CÁLCULO DO CDB</h1>

<p align="center">
    <a href="https://codecov.io/gh/rochajario/B3-Desafio-Cdb">
        <img src="https://codecov.io/gh/rochajario/B3-Desafio-Cdb/branch/master/graph/badge.svg?token=YT3JTL3M0E"/>
    </a>
    <br/>
    <a href="https://sonarcloud.io/project/overview?id=rochajario_B3-Desafio-Cdb">
        <img src="https://sonarcloud.io/api/project_badges/measure?project=rochajario_B3-Desafio-Cdb&metric=sqale_rating"/>
    </a>
    <a href="https://sonarcloud.io/project/overview?id=rochajario_B3-Desafio-Cdb">
        <img src="https://sonarcloud.io/api/project_badges/measure?project=rochajario_B3-Desafio-Cdb&metric=reliability_rating"/>
    </a>
    <a href="https://sonarcloud.io/project/overview?id=rochajario_B3-Desafio-Cdb">
        <img src="https://sonarcloud.io/api/project_badges/measure?project=rochajario_B3-Desafio-Cdb&metric=security_rating"/>
    </a>
    <a href="https://sonarcloud.io/project/overview?id=rochajario_B3-Desafio-Cdb">
        <img src="https://sonarcloud.io/api/project_badges/measure?project=rochajario_B3-Desafio-Cdb&metric=code_smells"/>
    </a>
    <a href="https://sonarcloud.io/project/overview?id=rochajario_B3-Desafio-Cdb">
        <img src="https://sonarcloud.io/api/project_badges/measure?project=rochajario_B3-Desafio-Cdb&metric=sqale_index"/>
    </a>
</p>

### Setup do Projeto
```
dotnet build
```

### Executar testes unitários do projeto com Cobertura de código
```
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```

### Executar Servidor
```
dotnet ./Api/bin/Debug/net5.0/Api.dll"
```