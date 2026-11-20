# MU

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

**EncryptSecurity v2.0**: criptografa e descriptografa textos usando uma chave de segurança, salvando o resultado em arquivo `.txt`.

## Funcionalidades

- Criptografa um texto e grava em `C:\<nome>.txt` (em Base64)
- Descriptografa o arquivo com a mesma chave e exibe o conteúdo na tela
- Chave de segurança com no mínimo 8 caracteres
- Validações e mensagens de erro na própria tela
- Tela de ajuda (tecla **F1** ou menu)

## O que pratiquei

- Criptografia simétrica **DES** com `DESCryptoServiceProvider` e `CryptoStream`
- Leitura e escrita de arquivos com `StreamReader` / `StreamWriter`
- Codificação Base64
- Múltiplos formulários (`Help.cs`) e `MenuStrip`

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
MU/
├── MU/
│   ├── Cript.cs
│   ├── Form1.cs
│   ├── Help.cs
│   ├── MU.csproj
│   ├── MU.jpg
│   └── Program.cs
└── MU.sln
```

## Como executar

1. Abra o `MU.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- Projeto de estudo: o DES é considerado inseguro hoje em dia e o vetor de inicialização (IV) é fixo. Não use para proteger dados reais.
- Os arquivos são gravados na raiz `C:\`, o que pode exigir permissão de administrador nas versões atuais do Windows.

---

Desenvolvido por **João Paulo Aramuni**.
