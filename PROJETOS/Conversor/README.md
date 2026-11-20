# Conversor

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Conversor de números entre as bases **decimal** e **binária**, nos dois sentidos.

## Funcionalidades

- Decimal → binário, pelo método de divisões sucessivas por 2
- Binário → decimal, com validação (só aceita `0` e `1`)
- Botões para limpar cada conversão

## O que pratiquei

- Algoritmo de conversão de base implementado à mão (`DecimalBinario.cs`)
- Inversão de string com array de `char`
- `Convert.ToInt32(valor, 2)` para a conversão inversa (`BinarioDecimal.cs`)

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Conversor/
├── Conversor/
│   ├── BinarioDecimal.cs
│   ├── Conversor.csproj
│   ├── DecimalBinario.cs
│   ├── Form1.cs
│   └── Program.cs
└── Conversor.sln
```

## Como executar

1. Abra o `Conversor.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

---

Desenvolvido por **João Paulo Aramuni**.
