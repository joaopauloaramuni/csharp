# MountyHall

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Simulação do **problema de Monty Hall**: três portas, um prêmio escondido e a decisão de manter ou trocar de porta.

## Funcionalidades

- O prêmio é sorteado atrás de uma das três portas
- O jogador escolhe uma porta e o programa abre (esconde) uma das outras que não tem o prêmio
- O jogador escolhe novamente, mantendo ou trocando, e vê o resultado: **Sucesso** ou **Fracasso**
- O jogo reinicia automaticamente após cada rodada

## O que pratiquei

- Sorteio com `Random`
- Controle de estado do jogo com variáveis
- Manipulação da visibilidade de controles

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
MountyHall/
├── MountyHall/
│   ├── Form1.cs
│   ├── MountyHall.csproj
│   └── Program.cs
└── MountyHall.sln
```

## Como executar

1. Abra o `MountyHall.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- Curiosidade: trocar de porta vence em cerca de 2/3 das vezes. Jogue várias rodadas para conferir.

---

Desenvolvido por **João Paulo Aramuni**.
