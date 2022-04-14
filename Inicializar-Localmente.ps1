Function Restaurar-Dependencias {
    Param($Path)
    if(Test-Path -Path "$Path\Api\bin\Debug\net5.0\Api.dll") {
        Write-Host ("Dependencias do projeto de Backend previamente restauradas...")
    }
    else{
        Write-Host ("Restaurando dependências do projeto de Backend...")
        dotnet restore ./calculadora-cdb.sln
        dotnet build ./calculadora-cdb.sln
    }

    if(Test-Path -Path "$Path\Frontend\node_modules") {
        Write-Host ("Dependencias do projeto de Frontend previamente restauradas...")
    }
    else{
        Write-Host ("Restaurando dependncias do projeto de Frontend...")
        Set-Location .\Frontend
        npm install
    }
}

Function Inicializar-Backend {
    Param($Path)
    Write-Host ("Inicializando Backend...")
    Start-Process -FilePath "dotnet" -ArgumentList "$Path\Api\bin\Debug\net5.0\Api.dll"
}

Function Inicializar-Frontend {
    Param($Path)
    Write-Host ("Inicializando Frontend...")
    cd $Path\Frontend\
    npm run serve 
}

try{
    # Obtendo variáveis de ambiente.
    $nodeVersion = node --version
    $dotnetVersion = dotnet --version
    $currentPath = Get-Location

    # Retaurando dependências dos projetos.
    Restaurar-Dependencias -Path $currentPath

    # Backend
    Inicializar-Backend -Path $currentPath

    # Frontend
    Inicializar-Frontend -P $currentPath
}
catch{
    Write-Error 'Falha ao Inicializar Sistema' -ErrorAction Stop
}