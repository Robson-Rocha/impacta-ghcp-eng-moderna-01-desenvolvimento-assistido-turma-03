# Passo 10 - Planejar a base da solução (Slide 10)

Com contexto e instruções definidos, vamos separar planejamento de execução. Primeiro, o Copilot deverá tornar visíveis suas suposições e decisões estruturais.

Abra uma **nova sessão** no modo **Plan**. Revise suposições, projetos, dependências e comandos antes de aprovar.


Execute este prompt:

```text
Leia `docs/specs/training-catalog-vertical-slice.md` e use-a como fonte para o comportamento esperado.

Planeje a base de uma solução .NET 10 para esse catálogo de treinamentos internos.

A solução deve conter:
- uma API ASP.NET Core;
- uma interface Blazor WebAssembly;
- persistência usando EF Core, inicialmente usando SQLite, e in-memory para testes
- projetos de testes;
- estrutura compatível com persistência adicionada em um incremento posterior.

Restrições:
- não implemente o CRUD;
- não adicione bibliotecas sem justificar;
- preserve uma estrutura simples para fins didáticos;
- use os comandos de validação definidos nas repository instructions.
- não resolva silenciosamente as decisões marcadas como abertas na especificação.

Antes do plano, liste as suposições e faça perguntas sobre decisões abertas que alterem a estrutura da solução.
Se houver conflito entre a solicitação e a especificação, pare e descreva o conflito.
Não edite arquivos nem execute comandos.
```

Quando tiver concluído, comente `planejado` nesta issue para receber o próximo passo.


