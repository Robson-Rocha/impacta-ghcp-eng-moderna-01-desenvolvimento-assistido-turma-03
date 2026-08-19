## Etapa 7 — Criar ou revisar as repository instructions

Agora vamos materializar o arquivo do repositório.

Crie ou ajuste:

```text
.github/copilot-instructions.md
```

Você pode revisar a resposta do Copilot ou usar diretamente este conteúdo de referência:

```markdown
# Catálogo de treinamentos — instruções do repositório

## Propósito

Este repositório contém a aplicação de catálogo de treinamentos usada no walkthrough do curso GitHub Copilot para Engenharia de Software Moderna.

## Plataforma

Use .NET 10 e C# como plataforma principal. O ambiente de desenvolvimento esperado é o VS Code em GitHub Codespaces.

Considere o ambiente de desenvolvimento como sendo o VS Code em um dev container Ubuntu 24.04.3 LTS, usando as ferramentas já disponíveis no ambiente, como Node.js, npm, ESLint e .NET SDK. Os testes serão executados no próprio container.

Use somente ferramentas e dependências disponíveis ou documentadas no repositório. Não presuma frameworks, pacotes ou serviços externos que ainda não tenham sido aprovados.

## Validação

Antes de concluir uma alteração, identifique e execute os comandos de build, testes e demais validações documentados no repositório. Se os comandos necessários não estiverem documentados, sinalize essa lacuna em vez de inventá-los.

## Especificação do catálogo

Antes de planejar ou alterar o comportamento do catálogo de treinamentos, leia a [especificação da primeira fatia vertical](../docs/specs/training-catalog-vertical-slice.md). Se a solicitação conflitar com a especificação, sinalize o conflito antes de editar. Novos comportamentos exigem contrato explícito e não podem alterar silenciosamente os critérios aprovados.
```

> [!NOTE]
> Se você não acompanhou as etapas anteriores, ou quiser se alinhar rapidamente ao estado do instrutor, pode trocar para `checkpoint/01-especificar-fatia`.

Quando tiver concluido esta etapa, comente `feito` nesta issue para receber o proximo passo.
