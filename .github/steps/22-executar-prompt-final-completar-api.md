# Passo 22 - Criar a exclusão e completar a API (Slide 16)

Vamos completar o conjunto de operações com a exclusão, mantendo a mesma disciplina de contrato, plano e evidência.

Continue na **mesma sessão**, em modo **Agent**, usando `/create-training-endpoint` para criar a exclusão e completar o CRUD.


Execute este prompt:

```text
Operação=Excluir um treinamento por identificador
Rota=DELETE /api/trainings/{id}
Contrato=Retornar 204 No Content quando a exclusão ocorrer; retornar 404 Not Found quando o identificador não existir
Validação=Executar um teste para exclusão bem-sucedida e outro para identificador inexistente
```

> [!TIP]
> Se necessário, sincronize com `checkpoint/04-completar-api`.

Quando tiver concluído, comente `concluido` nesta issue para receber o próximo passo.


