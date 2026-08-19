## Etapa 6 — Propor as repository instructions

Agora vamos transformar parte do contexto aprovado em instruções duráveis do repositório.

Abra o Copilot Chat em uma **nova sessão** e use o modo **Ask**.

Forneça como contexto o `README.md` e `docs/specs/training-catalog-vertical-slice.md`.

Execute este prompt:

```text
Com base apenas no contexto fornecido, proponha quatro instruções curtas para `.github/copilot-instructions.md`:

1. propósito do repositório;
2. plataforma principal e restrições técnicas;
3. comandos obrigatórios de validação.
4. antes de planejar ou alterar o catálogo, ler a especificação da primeira fatia vertical em docs/specs/training-catalog-vertical-slice.md e sinalizar conflitos antes de editar.

Não inclua preferências que não estejam documentadas.
Não copie o conteúdo completo da especificação para as instructions.
Para cada instrução, explique em uma frase por que ela deve ser durável e aplicada a todo o repositório.
Não edite o arquivo.
```

Quando tiver concluido esta etapa, comente `planejado` nesta issue para receber o proximo passo.
