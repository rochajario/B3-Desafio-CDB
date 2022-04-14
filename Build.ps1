Function Restaurar-Dependencias {
    if(Test-Path -Path "$currentPath\Api\bin\Debug\net5.0\Api.dll") {
        Write-Host ("Dependencias do projeto de Backend previamente restauradas...")
    }
    else{
        Write-Host ("Restaurando dependências do projeto de Backend...")
        dotnet restore ./calculadora-cdb.sln
    }

    if(Test-Path -Path "$currentPath\Frontend\node_modules") {
        Write-Host ("Dependencias do projeto de Frontend previamente restauradas...")
    }
    else{
        Write-Host ("Restaurando dependncias do projeto de Frontend...")
        Set-Location .\Frontend
        npm install
    }
}

Function Inicializar-Backend {
    Write-Host ("Inicializando Backend...")
    Start-Process -FilePath "dotnet" -ArgumentList "$currentPath\Api\bin\Debug\net5.0\Api.dll"
}

Function Inicializar-Frontend {
    Write-Host ("Inicializando Frontend...")
    cd $currentPath\Frontend\
    npm run serve 
}

try{
    # Obtendo variáveis de ambiente.
    $nodeVersion = node --version
    $dotnetVersion = dotnet --version
    $currentPath = Get-Location

    # Retaurando dependências dos projetos.
    Restaurar-Dependencias

    # Backend
    Inicializar-Backend

    # Frontend
    Inicializar-Frontend
}
catch{
    Write-Error 'Falha ao Inicializar Sistema' -ErrorAction Stop
}