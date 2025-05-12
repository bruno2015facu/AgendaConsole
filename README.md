# Sistema de Agenda de Compromissos (Console App em C#)

## 📌 Objetivo

Este projeto é uma aplicação de console desenvolvida em C# para gerenciar compromissos de usuários, permitindo:

- Registro de compromissos com data e hora futura.
- Associação com local e validação da capacidade.
- Adição de participantes com relação N:N.
- Inclusão de anotações internas (composição).
- Associação simples entre objetos (usuário, compromisso, local).

O foco é a prática dos princípios da Programação Orientada a Objetos (POO): **abstração, encapsulamento, composição e associação**.

---

## 🗂 Estrutura do Projeto

```
/AgendaConsole
├── Program.cs
└── Modelos
    ├── Usuario.cs
    ├── Compromisso.cs
    ├── Participante.cs
    ├── Anotacao.cs
    └── Local.cs
```

---

## ▶️ Como Executar

1. **Pré-requisitos**:
   - .NET SDK instalado (versão 6.0 ou superior).

2. **Executando via terminal**:

```bash
dotnet run
```

---

## 🧠 Funcionalidades

### Menu principal:
- **Registrar compromisso**
- **Exibir compromissos**
- **Sair**

### Fluxo:
- Entrada do nome do usuário.
- Cadastro de compromisso com descrição, data/hora e local.
- Adição de participantes (com validação de capacidade).
- Inclusão de anotações no compromisso.
- Exibição dos compromissos criados com detalhes.

---

## 🧪 Exemplos de Uso

```
Informe seu nome: João Silva

Menu:
1 - Criar novo compromisso
2 - Exibir compromissos
0 - Sair
```

---

## 📚 Conceitos Trabalhados

- Associação Simples (Usuario ↔ Compromisso, Compromisso ↔ Local)
- Associação N:N (Compromisso ↔ Participante)
- Composição (Compromisso ↔ Anotação)
- Encapsulamento com `private` + `IReadOnlyCollection`
- Validações em construtores e métodos

---

## 📘 Licença

Este projeto é de uso acadêmico e livre para fins educacionais.
