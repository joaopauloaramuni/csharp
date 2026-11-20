# Calculadora

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Calculadora simples que realiza as quatro operações básicas entre dois números.

## Funcionalidades

- Soma, subtração, multiplicação e divisão
- Aceita ponto ou vírgula como separador decimal
- Botão para limpar os campos

## O que pratiquei

- Separação da lógica em uma classe própria (`Calculo.cs`)
- Tratamento de eventos de clique em botões
- Conversão de texto para número com `Convert.ToDouble`

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Calculadora/
├── Calculadora/
│   ├── Calculadora.csproj
│   ├── Calculo.cs
│   ├── Form1.cs
│   └── Program.cs
└── Calculadora.sln
```

## Como executar

1. Abra o `Calculadora.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- Não há tratamento de entrada inválida: digitar letras ou deixar um campo vazio gera uma exceção.

---

Desenvolvido por **João Paulo Aramuni**.
