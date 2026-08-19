## Etapa 27 — Propor o perfil mínimo do custom agent

Abra o Copilot Chat em uma **nova sessão** e use o modo **Ask**.

Execute este prompt:

```text
Proponha o conteúdo mínimo de `.github/agents/revisor-entrega.md` para um custom agent que revise uma entrega antes da conclusão.

Responsabilidades:
- relacionar critérios de aceitação a evidências;
- executar um teste relevante;
- iniciar a API localmente e obter o documento OpenAPI gerado em runtime;
- verificar no documento as operações, entradas e respostas previstas;
- verificar se o workflow executa build e testes.

Limites:
- não editar código ou configuração;
- usar a execução somente para testes, inicialização da API e requisições HTTP a `localhost`;
- apresentar os comandos e aguardar aprovação antes de executá-los;
- encerrar a API ao concluir a inspeção;
- não executar operações externas;
- não ampliar a análise para requisitos não documentados.

Inclua somente o frontmatter necessário e instruções curtas.
Depois do bloco de código, explique por que cada ferramenta ou permissão proposta é necessária.
```

Quando tiver concluido esta etapa, comente `planejado` nesta issue para receber o proximo passo.
