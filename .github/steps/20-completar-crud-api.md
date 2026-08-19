## Etapa 20 — Completar os demais endpoints da API com o prompt file

Agora vamos reutilizar o prompt file criado.

Você pode fazer esta etapa na **mesma sessão anterior** do Copilot Chat, em modo **Agent**.

### Parte A — Criar a listagem

Execute:

```text
/criar-endpoint-treinamento
```

Com estas entradas:

```text
Operação=Listar todos os treinamentos
Rota=GET /api/trainings
Contrato=Retornar 200 OK com uma coleção de treinamentos; quando não houver registros, retornar uma coleção vazia
Validação=Executar um teste para catálogo vazio e outro após cadastrar um treinamento
```

### Parte B — Criar a consulta por identificador

Ainda na **mesma sessão**, execute novamente:

```text
/criar-endpoint-treinamento
```

Com estas entradas:

```text
Operação=Consultar um treinamento por identificador
Rota=GET /api/trainings/{id}
Contrato=Retornar 200 OK com o treinamento quando encontrado; retornar 404 Not Found quando o identificador não existir
Validação=Executar um teste para um identificador existente e outro para um identificador inexistente
```

### Parte C — Criar a atualização

Ainda na **mesma sessão**, execute novamente:

```text
/criar-endpoint-treinamento
```

Com estas entradas:

```text
Operação=Atualizar integralmente um treinamento existente
Rota=PUT /api/trainings/{id}
Contrato=Receber título, descrição, data de início e carga horária; retornar 200 OK com o recurso atualizado; retornar 400 Bad Request para dados inválidos; retornar 404 Not Found quando o identificador não existir
Validação=Executar testes para atualização válida, entrada inválida e identificador inexistente
```

### Parte D — Criar a exclusão

Ainda na **mesma sessão**, execute novamente:

```text
/criar-endpoint-treinamento
```

Com estas entradas:

```text
Operação=Excluir um treinamento por identificador
Rota=DELETE /api/trainings/{id}
Contrato=Retornar 204 No Content quando a exclusão ocorrer; retornar 404 Not Found quando o identificador não existir
Validação=Executar um teste para exclusão bem-sucedida e outro para identificador inexistente
```

> [!NOTE]
> Se você quiser recuperar rapidamente o estado preparado pelo instrutor, pode trocar para `checkpoint/04-completar-api`.

Quando tiver concluido esta etapa, comente `feito` nesta issue para receber o proximo passo.
