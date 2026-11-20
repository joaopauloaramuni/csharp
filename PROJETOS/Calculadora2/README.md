# Calculadora2

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Calculadora de **fatorial** e **sequência de Fibonacci**, criada para praticar laços de repetição e recursão.

## Funcionalidades

- Cálculo do fatorial de *n* (iterativo, com laço `for`)
- Cálculo do *n*-ésimo termo de Fibonacci (recursivo)
- Entrada por `NumericUpDown`, com aviso de "valor limite excedido"

## O que pratiquei

- Recursão x iteração
- Classe de lógica separada da interface (`Calculo.cs`)
- Uso do controle `NumericUpDown`

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Calculadora2/
├── Calculadora2/
│   ├── Calculadora2.csproj
│   ├── Calculo.cs
│   ├── Form1.cs
│   └── Program.cs
└── Calculadora2.sln
```

## Como executar

1. Abra o `Calculadora2.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- O Fibonacci recursivo é exponencial: valores de *n* acima de ~35 deixam a aplicação lenta.

---

Desenvolvido por **João Paulo Aramuni**.
