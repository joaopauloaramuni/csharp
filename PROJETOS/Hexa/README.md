# Hexa

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Conversor de números **binários** para **hexadecimal**.

## Funcionalidades

- Converte o binário em grupos de 4 bits (nibbles) para o dígito hexadecimal correspondente
- Valida se a entrada contém apenas `0` e `1`
- Exige no mínimo 4 dígitos

## O que pratiquei

- Representação binária e hexadecimal
- Percorrer string caractere a caractere com `foreach`
- Validação de entrada

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Hexa/
├── Hexa/
│   ├── Form1.cs
│   ├── Hexa.csproj
│   └── Program.cs
└── Hexa.sln
```

## Como executar

1. Abra o `Hexa.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- A entrada deve ter um número de dígitos múltiplo de 4 (ex.: `10101111` → `AF`). O grupo `0000` não gera o dígito `0`.

---

Desenvolvido por **João Paulo Aramuni**.
