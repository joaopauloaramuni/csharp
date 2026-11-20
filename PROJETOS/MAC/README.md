# MAC

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Mostra o **endereço MAC** da primeira interface de rede ativa do computador.

## Funcionalidades

- Detecta a primeira placa de rede com status *Up*
- Exibe o endereço físico (MAC) ao abrir o programa

## O que pratiquei

- `System.Net.NetworkInformation`: `NetworkInterface` e `PhysicalAddress`

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
MAC/
├── MAC/
│   ├── Form1.cs
│   ├── MAC.csproj
│   └── Program.cs
└── MAC.sln
```

## Como executar

1. Abra o `MAC.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

---

Desenvolvido por **João Paulo Aramuni**.
