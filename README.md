# 📟 Calculadora Tabajara 2025  

## 📌 Introdução  

A **Calculadora Tabajara 2025** é uma aplicação de linha de comando desenvolvida em **C#** que oferece operações matemáticas básicas com suporte a casas decimais, armazenamento de histórico e validações avançadas. O projeto serve para a utilização de conceitos fundamentais da linguagem, como **estruturas de controle, manipulação de dados em arrays e validação de entrada do usuário**.  

## 🚀 Funcionalidades  

✅ **Operações Aritméticas:**  
- ➕ **Soma**  
- ➖ **Subtração**  
- ✖️ **Multiplicação**  
- ➗ **Divisão** (com validação de divisão por zero)  

✅ **Histórico de Operações:**  
- Armazena as últimas **100 operações** realizadas  
- Exibe os cálculos no formato `"a + b = c"`  

✅ **Tabuada:**  
- Gera a tabuada até 10 de um número fornecido pelo usuário  

✅ **Cálculo Contínuo:**  
- Permite reutilizar o resultado da operação anterior em novos cálculos  

✅ **Validação de Entrada:**  
- Evita entradas inválidas, garantindo que apenas números e opções permitidas sejam aceitos  

✅ **Tratamento de Exceções:**  
- Impede falhas no programa devido a entradas incorretas ou operações inválidas  

---

## 💻 Exemplo de Execução:
![](https://i.imgur.com/4ila6zV.gif)

## 🛠 Como utilizar:
🚀 Passo a Passo

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

## ✅ Requisitos
.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.