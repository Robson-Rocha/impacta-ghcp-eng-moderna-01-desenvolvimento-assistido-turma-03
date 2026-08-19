## Etapa 17 — Revisar a migration com a skill

Vamos continuar na **mesma sessão anterior** do Copilot Chat, em modo **Agent**.

Confirme que o repositório contém:

```text
.github/skills/review-ef-migration/SKILL.md
```

Use este prompt:

```text
Revise a migration recém-gerada antes de aplicá-la.

Verifique especificamente:
- perda ou transformação inesperada de dados;
- nulabilidade e valores padrão;
- tipos e limites das colunas;
- operações destrutivas;
- divergências entre entidade, configuração e esquema.

Use as orientações da skill `review-ef-migration` disponível no repositório.
Não altere arquivos.

Apresente os achados por severidade, cite o arquivo e explique a evidência.
Se não houver problema, informe também os riscos que ainda dependem de validação em execução.
```

Quando tiver concluido esta etapa, comente `validado` nesta issue para receber o proximo passo.
