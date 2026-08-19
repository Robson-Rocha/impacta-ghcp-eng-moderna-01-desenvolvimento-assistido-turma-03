# Passo 25 - Revisar a migration com a skill (Slide 21)

Com a migration gerada e a skill disponível, o próximo passo é revisar o que será aplicado — ainda sem modificar o banco.

Continue na **mesma sessão** no modo **Agent**. Revise a migration com a skill e não a aplique ainda.


Execute este prompt:

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

Quando tiver concluído, comente `validado` nesta issue para receber o próximo passo.


