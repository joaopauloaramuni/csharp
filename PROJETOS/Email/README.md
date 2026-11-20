# Email

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Cliente simples para envio de e-mails via SMTP.

## Funcionalidades

- Campos para servidor SMTP (IP e host), remetente, senha, destinatário, assunto e conteúdo
- Envio da mensagem com autenticação
- Mensagem de sucesso ou erro após o envio

## O que pratiquei

- `System.Net.Mail`: `MailMessage` e `SmtpClient`
- Autenticação com `NetworkCredential`
- Tratamento de exceções com `try/catch`
- Placeholders feitos à mão (texto de exemplo que some ao focar o campo)

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Email/
├── Email/
│   ├── Email.csproj
│   ├── Form1.cs
│   └── Program.cs
└── Email.sln
```

## Como executar

1. Abra o `Email.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- Não usa SSL/TLS, então a maioria dos provedores atuais (Gmail, Outlook etc.) vai recusar o envio. Serve para servidores SMTP internos ou de teste.

---

Desenvolvido por **João Paulo Aramuni**.
