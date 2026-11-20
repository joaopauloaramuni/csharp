# HD

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Exibe informações do disco `C:` do computador.

## Funcionalidades

- Capacidade total (GB)
- Espaço usado (GB)
- Espaço livre (GB)
- Número de série do volume

## O que pratiquei

- Consultas **WMI** com `System.Management` (`Win32_LogicalDisk`)
- Encapsulamento das consultas em uma classe (`HD.cs`)

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
HD/
├── HD/
│   ├── Form1.cs
│   ├── HD.cs
│   ├── HD.csproj
│   └── Program.cs
└── HD.sln
```

## Como executar

1. Abra o `HD.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- Funciona apenas no Windows e lê sempre a unidade `C:`.

---

Desenvolvido por **João Paulo Aramuni**.
