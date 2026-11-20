# Gerador

> Projeto de estudo em C#, desenvolvido em 2011 enquanto eu trabalhava como estagiário C# na [Álamo TI](https://alamoti.net/).

## Sobre

Gerador de números de **CPF**, **CNPJ** e **PIS** válidos, útil para testes de sistemas.

## Funcionalidades

- Gera um CPF, um CNPJ e um PIS válidos com um clique
- Validação pelos dígitos verificadores (módulo 11)

## O que pratiquei

- Algoritmos de dígito verificador de CPF, CNPJ e PIS (uma classe para cada)
- Geração aleatória com `Random`, repetindo até obter um número válido (recursão)
- Constantes centralizadas em uma classe estática (`Constantes.cs`)
- Organização com `#region` e convenção de nomes `v_` / `p_`

## Tecnologias

- C# / .NET Framework 4.0
- Windows Forms
- Visual Studio 2010

## Estrutura

```
Gerador/
├── Gerador/
│   ├── Constantes.cs
│   ├── Form1.cs
│   ├── Gerador.csproj
│   ├── Gerar.cs
│   ├── Program.cs
│   ├── ValidarCNPJ.cs
│   ├── ValidarCPF.cs
│   └── ValidarPIS.cs
└── Gerador.sln
```

## Como executar

1. Abra o `Gerador.sln` no Visual Studio (2010 ou mais recente; versões novas podem pedir para atualizar o projeto).
2. Compile e execute com **F5**.

## Observações

- Os números gerados são apenas matematicamente válidos e devem ser usados somente para testes.

---

Desenvolvido por **João Paulo Aramuni**.
