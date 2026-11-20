# Agenda

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Agenda de contatos em Windows Forms com banco de dados local SQL Server (arquivo `.mdf`). Permite cadastrar, editar, navegar e excluir contatos usando os componentes de *data binding* do Visual Studio.

## Funcionalidades

- Cadastro de contatos com **Nome**, **Telefone** e **Celular**
- Navegação entre registros pelo `BindingNavigator` (primeiro, anterior, próximo, último)
- Inclusão, exclusão e gravação das alterações no banco
- Botão "Sobre" com os créditos do autor

## O que pratiquei

- `DataSet` tipado (`AgendaDataSet.xsd`), `TableAdapter` e `TableAdapterManager`
- `BindingSource` e `BindingNavigator` para ligar controles aos dados
- Banco de dados local SQL Server Express (`Agenda.mdf`) anexado ao projeto

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Agenda/
├── Agenda/
│   ├── Agenda.csproj
│   ├── Agenda.mdf
│   ├── AgendaDataSet.xsd
│   ├── Form1.cs
│   └── Program.cs
└── Agenda.sln
```

## Como executar

1. Abra o `Agenda.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- Requer **SQL Server Express / LocalDB** para abrir o arquivo `Agenda.mdf`. Se necessário, ajuste a *connection string* em `app.config`.

---

Desenvolvido por **João Paulo Aramuni**.
