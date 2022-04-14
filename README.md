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

## Sumário

## 1 - Objetivo
Demonstrar a capacidade de análise e implementação de soluções fundamentadas pelos princípios do SOLID, Testes unitários e performance.

## 2 - Inicializando Localmente
> Para inicializar o sistema em ambiente windows assegure-se que o sistema operacional possui:
- Node.js na versão 14.0.1 (Outras versões não testadas);
- .Net 5.0
> Navegue até a pasta onde o projeto foi baixado e execute o seguinte comando:

```
powershell ./Inicializar-localmente.ps1
```


## 3 - Problema
### Cálculo do CDB
1. Desenvolvimento de uma tela web que possibilita ao usuário informar um valor monetário positivo e um prazo em meses maior que 1 (um) para resgate da aplicação. Após solicitar o cálculo do investimento, a tela deve apresentar o resultado bruto e o resultado líquido do investimento.

2. Desenvolvimento de uma Web API que receba os dados informados no item 1
Para o cálculo do CDB, deve-se utilizar a fórmula `VF = VI x [1 +(CDI x TB)]` onde:
>VF é o valor final;  

>VI é o valor inicial;

>CDI é o valor dessa taxa no último mês;

>TB é quanto o banco paga sobre o CDI;

	Nota: A fórmula calcula somente o valor de um mês. 
	Ou seja, os rendimentos de cada mês devem ser utilizados para calcular o mês seguinte

Para medida do Exercício considerar os valores abaixo como fixos:
> TB – 108%

> CDI – 0,9%

Para cálculo de imposto regressivo utilizar os seguintes dados:
> Até 06 meses: 22,5%

> Até 12 meses: 20%

> Até 24 meses 17,5%

> Acima de 24 meses 15%
