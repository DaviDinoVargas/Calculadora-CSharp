# Calculadora Tabajara 2025

## Introdução

Calculadora Tabajara 2025 é um projeto de uma aplicação de linha de código simples em **C#** que simula uma calculadora real com suas funcionalidades de operações aritiméticas básicas.

## Funcionalidades

- **Operações Aritméticas:**
	- Somar
	- Subtrair
	- Multiplicar
	- Dividir

- **Suporte a Casas Decimais;**
- **Histórico de Operações**:
  - Armazena e exibe as operações realizadas, incluindo o número de cada operação e o resultado.
- **Tabuada**:
  - Exibe a tabuada de um número fornecido pelo usuário.
- **Continuação com o Resultado Anterior:**
  - Permite que o usuário continue calculando com o resultado de operações anteriores.
- **Validação de Entrada:** 
  - A calculadora garante que apenas opções válidas sejam aceitas.
- **Tratamento de Divisão por Zero:**
  - A calculadora é capaz de validar erros de divisão por zero.

![](https://i.imgur.com/4ila6zV.gif)

## Como utilizar:

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto

```
dotnet restore
```
4. Em seguida, compile a solução o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project Calculadora.ConsoleApp
```
6. Para executar o arquivo compilado, navegue até a pasta: ./Calculadora.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
Calculdora.ConsoleApp.exe
```

## Requisitos
.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.