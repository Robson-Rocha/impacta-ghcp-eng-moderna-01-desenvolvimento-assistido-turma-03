# Passo 12 - Implementar o primeiro endpoint (Slide 12)

A partir daqui, trabalharemos em incrementos pequenos e verificáveis. O primeiro deles será somente o cadastro de treinamento.

Continue na **mesma sessão** no modo **Agent**. Inspecione DTO, validação, respostas HTTP, armazenamento temporário e testes.


Execute este prompt:

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

## Referências

- [OpenAPI e Swagger UI no ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/openapi/using-openapi-documents)

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


