# DespertadorProgramavel

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Despertador que toca uma música escolhida pelo usuário em um horário programado.

## Funcionalidades

- Relógio com a hora atual atualizada a cada segundo
- Escolha do arquivo de música pelo `OpenFileDialog`
- Horário do alarme digitado em `MaskedTextBox` (hh:mm:ss)
- Se nenhum horário for informado, o alarme é programado para daqui a 3h55
- Botões **Start** e **Stop**

## O que pratiquei

- Dois `Timer`s trabalhando juntos (hora atual e verificação do alarme)
- Reprodução de mídia com o controle ActiveX do **Windows Media Player**
- Cálculos com `DateTime` e `TimeSpan`
- Organização do código com `#region`

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
DespertadorProgramavel/
├── DespertadorProgramavel/
│   ├── DespertadorProgramavel.csproj
│   ├── Form1.cs
│   └── Program.cs
└── DespertadorProgramavel.sln
```

## Como executar

1. Abra o `DespertadorProgramavel.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- Requer o Windows Media Player instalado (o controle AxWMPLib é usado para tocar o som).

---

Desenvolvido por **João Paulo Aramuni**.
