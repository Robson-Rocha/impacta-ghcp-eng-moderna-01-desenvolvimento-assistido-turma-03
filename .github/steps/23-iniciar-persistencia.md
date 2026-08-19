# Passo 23 - Iniciar a persistência (Slide 21)

Até aqui, todos os endpoints compartilharam armazenamento temporário. Agora vamos trocar essa implementação por persistência real sem alterar os contratos públicos.

Em terminal que **não seja o terminal do agente**, instale o SQLite:

```bash
sudo apt update
sudo apt install sqlite
```

Abra uma **nova sessão** no modo **Agent** e execute o prompt. Revise entidade, `DbContext`, pacotes, configuração, migration e contratos.


Execute este prompt:

```text
Leia `docs/specs/training-catalog-vertical-slice.md`.
Substitua o armazenamento temporário compartilhado por persistência com Entity Framework Core.
Se a mudança exigir resolver uma decisão ainda aberta, apresente opções e aguarde aprovação.

Restrições:
- preserve o contrato de `POST` aprovado na especificação e os contratos explícitos validados para `GET`, `PUT` e `DELETE`;
- faça todos os endpoints usarem a mesma fonte persistida;
- modele somente os dados necessários ao catálogo atual;
- mantenha detalhes de persistência fora do DTO público;
- para a persistência da aplicação utilize SQLite; Para os testes, sempre inicialize um novo banco de dados com o estado conhecido para o teste;
- crie uma migration, mas pare antes de aplicá-la;
- não crie novos endpoints;
- não mantenha uma segunda fonte de dados em memória;
- não adicione abstrações além das necessárias para substituir a implementação existente.

Antes de editar, apresente:
1. arquivos que serão criados ou alterados;
2. mapeamento entre DTO, entidade e tabela;
3. como cada endpoint passará a usar o `DbContext`;
4. dependências necessárias e justificativa;
5. comandos de validação.

Depois de minha aprovação, implemente e gere a migration.
```

## Referências

- [Introdução ao Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app)
- [Agent skills](https://docs.github.com/en/copilot/concepts/agents/about-agent-skills)
- [Gerenciar contexto no Copilot](https://docs.github.com/en/copilot/concepts/prompting)

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


