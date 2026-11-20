# Txt

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Editor de texto simples que lê e grava o conteúdo em `C:\texto.txt`.

## Funcionalidades

- Ao abrir, carrega o conteúdo de `C:\texto.txt` (ou cria o arquivo se não existir)
- Botão para gravar o texto no arquivo

## O que pratiquei

- Leitura e escrita de arquivos com `StreamReader` / `StreamWriter` e `File`
- Separação da leitura (`Ler.cs`) e da gravação (`Gravar.cs`) em classes

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Txt/
├── Txt/
│   ├── Form1.cs
│   ├── Gravar.cs
│   ├── Ler.cs
│   ├── Program.cs
│   └── Txt.csproj
└── Txt.sln
```

## Como executar

1. Abra o `Txt.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- Gravar na raiz `C:\` pode exigir permissão de administrador nas versões atuais do Windows.
- A leitura concatena as linhas sem preservar as quebras de linha.

---

Desenvolvido por **João Paulo Aramuni**.
