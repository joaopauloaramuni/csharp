# Esfera

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Calcula a **área da superfície** e o **volume** de uma esfera a partir do raio informado.

## Funcionalidades

- Área: `4 · π · r²`
- Volume: `(4 · π · r³) / 3`
- Aceita ponto ou vírgula como separador decimal
- Validação de valores inválidos ou negativos

## O que pratiquei

- Fórmulas matemáticas com `Math.Pow`
- Conversão segura com `double.TryParse`

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Esfera/
├── Esfera/
│   ├── Esfera.csproj
│   ├── Form1.cs
│   ├── Program.cs
│   └── esfera.jpg
└── Esfera.sln
```

## Como executar

1. Abra o `Esfera.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- O valor de π está fixo em `3.14`, então os resultados são aproximados (poderia ser usado `Math.PI`).

---

Desenvolvido por **João Paulo Aramuni**.
