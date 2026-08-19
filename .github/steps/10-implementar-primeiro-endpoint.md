## Etapa 10 — Implementar o primeiro endpoint

Vamos continuar na **mesma sessão anterior** do Copilot Chat, preservando o contexto da criação da solução.

Use o modo **Agent** e execute este prompt:

```text
Leia `docs/specs/training-catalog-vertical-slice.md`.
Implemente somente o endpoint de criação de treinamento descrito nessa especificação.
Se este prompt divergir da especificação, pare e apresente o conflito antes de editar.

Contrato:
- entrada: título, descrição, data de início e carga horária;
- sucesso: `201 Created`, com identificador e representação do recurso;
- falha de validação: `400 Bad Request`;
- use somente o armazenamento temporário em memória preparado para esta etapa;
- mantenha esse armazenamento atrás da menor abstração necessária para ser compartilhado e substituído depois;
- não adicione banco de dados ou persistência definitiva ainda.

Use este exemplo como padrão para erros:

Entrada:
{
  "title": "",
  "description": "Introdução ao C#",
  "startDate": "2026-09-15",
  "durationHours": 8
}

Resposta:
{
  "errors": {
    "title": ["O título é obrigatório."]
  }
}

Antes de editar, informe quais arquivos pretende alterar e por quê.
Depois de implementar, execute o menor conjunto de validações que comprove um caso válido e um inválido.
Não implemente outros endpoints.
```

Quando tiver concluido esta etapa, comente `feito` nesta issue para receber o proximo passo.
