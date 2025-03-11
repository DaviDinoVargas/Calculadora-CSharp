# Calculadora Tabajara 2025

## Introdu��o

Calculadora Tabajara 2025 � um projeto de uma aplica��o de linha de c�digo simples em **C#** que simula uma calculadora real com suas funcionalidades de opera��es aritim�ticas b�sicas.

## Funcionalidades

- **Opera��es Aritm�ticas:**
	- Somar
	- Subtrair
	- Multiplicar
	- Dividir

- **Suporte a Casas Decimais;**
- **Hist�rico de Opera��es**:
  - Armazena e exibe as opera��es realizadas, incluindo o n�mero de cada opera��o e o resultado.
- **Tabuada**:
  - Exibe a tabuada de um n�mero fornecido pelo usu�rio.
- **Continua��o com o Resultado Anterior:**
  - Permite que o usu�rio continue calculando com o resultado de opera��es anteriores.
- **Valida��o de Entrada:** 
  - A calculadora garante que apenas op��es v�lidas sejam aceitas.
- **Tratamento de Divis�o por Zero:**
  - A calculadora � capaz de validar erros de divis�o por zero.

![](https://i.imgur.com/4ila6zV.gif)

## Como utilizar:

1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto

```
dotnet restore
```
4. Em seguida, compile a solu��o o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project Calculadora.ConsoleApp
```
6. Para executar o arquivo compilado, navegue at� a pasta: ./Calculadora.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
Calculdora.ConsoleApp.exe
```

## Requisitos
.NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.