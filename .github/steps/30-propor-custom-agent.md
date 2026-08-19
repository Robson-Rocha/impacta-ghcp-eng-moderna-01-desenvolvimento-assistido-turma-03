# Passo 33 - Propor o custom agent (Slide 30)

Para a revisão final, vamos criar um papel especializado: um agente que relaciona critérios a evidências sem editar a entrega.

Abra uma **nova sessão** no modo **Ask**. Compare a proposta com a documentação vigente e remova ferramentas desnecessárias.


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

## Referências

- [Testes no .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/)
- [GitHub Actions](https://docs.github.com/en/actions)
- [Custom agents](https://docs.github.com/en/copilot/concepts/agents/cloud-agent/about-custom-agents)
- [Cheat sheet de customização](https://docs.github.com/en/copilot/reference/customization-cheat-sheet)
- [Configuração de custom agents](https://docs.github.com/en/copilot/reference/custom-agents-configuration)

Quando tiver concluído, comente `planejado` nesta issue para receber o próximo passo.


