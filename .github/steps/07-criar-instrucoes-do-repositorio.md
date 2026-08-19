# Passo 7 - Criar as instruções do repositório (Slide 06)

A especificação só ajuda de forma consistente quando o Copilot sabe que deve consultá-la. Vamos registrar essa orientação de forma curta e durável.

Crie `.github/copilot-instructions.md` com a instrução abaixo, que aponta para a especificação aprovada. Não copie todo o contrato para as instructions.


Use este conteúdo de referência:

```markdown
Antes de planejar ou alterar o comportamento do catálogo de treinamentos, leia a [especificação da primeira fatia vertical](../docs/specs/training-catalog-vertical-slice.md). Se a solicitação conflitar com a especificação, sinalize o conflito antes de editar. Novos comportamentos exigem contrato explícito e não podem alterar silenciosamente os critérios aprovados.
```

> [!TIP]
> Se necessário, sincronize com `checkpoint/01-especificar-fatia`.

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


