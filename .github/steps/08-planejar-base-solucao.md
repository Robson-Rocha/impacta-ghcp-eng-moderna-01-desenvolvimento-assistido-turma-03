## Etapa 8 — Planejar a base da solução

Agora vamos sair da especificação e planejar a estrutura mínima da solução.

Abra o Copilot Chat em uma **nova sessão** e use o modo **Plan**.

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

Quando tiver concluido esta etapa, comente `planejado` nesta issue para receber o proximo passo.
