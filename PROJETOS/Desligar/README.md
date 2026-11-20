# Desligar

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Agendador de desligamento do Windows: desliga ou reinicia o computador após um número de segundos, com contagem regressiva na tela.

## Funcionalidades

- Escolha entre **desligar** ou **reiniciar**
- Tempo definido em segundos, com contagem regressiva visível
- Botão **Cancelar** (aborta o desligamento agendado)
- Botão **Deslogar** (encerra a sessão imediatamente)

## O que pratiquei

- Execução de processos externos com `Process.Start` (comando `shutdown` do Windows)
- Uso de `Timer` para atualizar a interface a cada segundo
- `ComboBox` e `switch` para selecionar a ação

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Desligar/
├── Desligar/
│   ├── Desligar.csproj
│   ├── Form1.cs
│   └── Program.cs
└── Desligar.sln
```

## Como executar

1. Abra o `Desligar.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- ⚠️ Este programa **realmente desliga, reinicia ou faz logoff** do computador e força o fechamento dos programas abertos (`-f`). Salve seu trabalho antes de testar.
- Funciona apenas no Windows.

---

Desenvolvido por **João Paulo Aramuni**.
