## Etapa 9 — Criar a base da solução

Agora vamos executar o plano aprovado.

Abra o Copilot Chat em uma **nova sessão** e use o modo **Agent**.

Execute este prompt:

```text
Implemente a base da solução planejada e aprovada para o catálogo de treinamentos.

Restrições:
- leia primeiro `docs/specs/training-catalog-vertical-slice.md` e `.github/copilot-instructions.md`;
- preserve as decisões aprovadas no plano;
- não implemente o CRUD completo ainda;
- não invente comportamentos fora da especificação;
- use comandos de validação documentados no repositório;
- se encontrar conflito entre plano e especificação, pare e descreva o conflito antes de editar.

Antes de editar, apresente:
1. arquivos que pretende criar ou alterar;
2. estrutura dos projetos;
3. dependências necessárias;
4. comandos de validação que pretende executar.

Depois da aprovação, implemente a base da solução.
```

> [!NOTE]
> Se você não acompanhou até aqui, ou quiser se sincronizar com o estado do instrutor, pode trocar para `checkpoint/02-criar-base-solucao`.

Quando tiver concluido esta etapa, comente `feito` nesta issue para receber o proximo passo.
