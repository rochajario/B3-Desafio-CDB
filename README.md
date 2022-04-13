<h1 align="center">DESAFIO - CÁLCULO DO CDB</h1>

<p align="center">
    <a href="https://github.com/rochajario/B3-Desafio-Cdb/actions/workflows/UnitTest.yml">
        <img src="https://github.com/rochajario/B3-Desafio-Cdb/actions/workflows/UnitTest.yml/badge.svg?branch=master"/>
    </a>
    <br/>
    <!--Outras Badges aqui-->
</p>

## 1 - Objetivo
Demonstrar a capacidade de análise e implementação de soluções fundamentadas pelos princípios do SOLID, Testes unitários e performance.

## 2 - Problema
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
