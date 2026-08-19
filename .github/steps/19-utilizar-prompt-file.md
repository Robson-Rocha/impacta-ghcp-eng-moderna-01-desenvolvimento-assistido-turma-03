# Passo 19 - Utilizar o prompt file para completar o CRUD da API (Slide 16)

Agora vamos demonstrar, em sequência, os usos rápidos do prompt file. A ideia é observar como ele pede contexto, reutilizá-lo com contratos diferentes e completar o restante do CRUD na mesma sessão.

Continue na **mesma sessão**, em modo **Agent**.

Primeiro, invoque apenas:

```text
/create-training-endpoint
```

Observe quais entradas o prompt file solicita. Em seguida, ainda na mesma sessão, reutilize-o sucessivamente com os contratos abaixo.

## 1. Listar todos os treinamentos

```text
Operação=Listar todos os treinamentos
Rota=GET /api/trainings
Contrato=Retornar 200 OK com uma coleção de treinamentos; quando não houver registros, retornar uma coleção vazia
Validação=Executar um teste para catálogo vazio e outro após cadastrar um treinamento
```

## 2. Consultar um treinamento por identificador

Antes de autorizar a implementação, confirme a rota, o tipo do identificador, a resposta de sucesso e o tratamento explícito da ausência.

```text
Operação=Consultar um treinamento por identificador
Rota=GET /api/trainings/{id}
Contrato=Retornar 200 OK com o treinamento quando encontrado; retornar 404 Not Found quando o identificador não existir
Validação=Executar um teste para um identificador existente e outro para um identificador inexistente
```

## 3. Atualizar integralmente um treinamento existente

Revise o plano antes de autorizar a atualização integral.

```text
Operação=Atualizar integralmente um treinamento existente
Rota=PUT /api/trainings/{id}
Contrato=Receber título, descrição, data de início e carga horária; retornar 200 OK com o recurso atualizado; retornar 400 Bad Request para dados inválidos; retornar 404 Not Found quando o identificador não existir
Validação=Executar testes para atualização válida, entrada inválida e identificador inexistente
```

## 4. Excluir um treinamento por identificador

```text
Operação=Excluir um treinamento por identificador
Rota=DELETE /api/trainings/{id}
Contrato=Retornar 204 No Content quando a exclusão ocorrer; retornar 404 Not Found quando o identificador não existir
Validação=Executar um teste para exclusão bem-sucedida e outro para identificador inexistente
```

> [!TIP]
> Se necessário, sincronize com `checkpoint/04-completar-api`.

Quando tiver concluído toda a sequência, comente `concluido` nesta issue para receber o próximo passo.

