# Passo 20 - Criar a consulta por identificador (Slide 16)

O prompt file já demonstrou como coleta entradas. Agora vamos reutilizá-lo para acrescentar a consulta de um treinamento por identificador.

Continue na **mesma sessão**, em modo **Agent**, e invoque `/create-training-endpoint` com estas entradas:

```text
Operação=Consultar um treinamento por identificador
Rota=GET /api/trainings/{id}
Contrato=Retornar 200 OK com o treinamento quando encontrado; retornar 404 Not Found quando o identificador não existir
Validação=Executar um teste para um identificador existente e outro para um identificador inexistente
```

Antes de autorizar a implementação, confirme a rota, o tipo do identificador, a resposta de sucesso e o tratamento explícito da ausência.

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.

