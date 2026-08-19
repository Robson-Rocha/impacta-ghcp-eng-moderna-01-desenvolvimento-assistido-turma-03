## Etapa 14 — Tratar a nova regra de `startDate` exclusiva

Vamos continuar na **mesma sessão anterior** do Copilot Chat, em modo **Agent**.

Execute este prompt:

```text
Ao testar `POST /api/trainings` pela Swagger UI, foi possível criar dois treinamentos com a mesma `startDate`.

Eu esperava que a data de início fosse exclusiva, mas essa regra não está na especificação atual.

Antes de editar:
1. confirme se o comportamento atual viola algum requisito existente;
2. explique por que isso não deve ser tratado automaticamente como defeito;
3. proponha a menor atualização da especificação para tornar explícita a nova regra;
4. proponha o contrato HTTP para o conflito, incluindo status e corpo da resposta;
5. indique o teste que comprovará a regra.

Não edite até eu aprovar a nova regra e o contrato.

Após minha aprovação:
1. atualize primeiro `docs/specs/training-catalog-vertical-slice.md`;
2. adicione o teste;
3. ajuste somente o necessário no endpoint;
4. execute a validação indicada;
5. repita o cenário pela Swagger UI.

Não refatore código não relacionado.
```

Quando tiver concluido esta etapa, comente `planejado` nesta issue para receber o proximo passo.
