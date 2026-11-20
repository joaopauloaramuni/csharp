# Snake

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

O clássico **jogo da cobrinha**, feito apenas com `PictureBox`es dentro de um `Panel`.

## Funcionalidades

- Controle pelas setas do teclado
- A cobra cresce a cada comida e o placar soma pontos
- *Game over* ao bater na parede ou no próprio corpo
- Botão **Reiniciar**

## O que pratiquei

- Laço de jogo com `Timer`
- Criação dinâmica de controles em tempo de execução
- Eventos de teclado (`KeyDown`)
- Detecção de colisão por coordenadas

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Snake/
├── Snake/
│   ├── Form1.cs
│   ├── Program.cs
│   └── Snake.csproj
└── Snake.sln
```

## Como executar

1. Abra o `Snake.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

---

Desenvolvido por **João Paulo Aramuni**.
