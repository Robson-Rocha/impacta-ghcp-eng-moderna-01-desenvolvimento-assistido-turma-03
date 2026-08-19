# Passo 21 - Criar a atualização de treinamento (Slide 16)

Na próxima reutilização, o contrato exige mais cuidado: uma atualização integral precisa preservar validações e tratar recursos inexistentes.

Continue na **mesma sessão**, em modo **Agent**, usando `/create-training-endpoint`. Revise o plano antes de autorizar a atualização integral.


Execute este prompt:

```text
Operação=Atualizar integralmente um treinamento existente
Rota=PUT /api/trainings/{id}
Contrato=Receber título, descrição, data de início e carga horária; retornar 200 OK com o recurso atualizado; retornar 400 Bad Request para dados inválidos; retornar 404 Not Found quando o identificador não existir
Validação=Executar testes para atualização válida, entrada inválida e identificador inexistente
```

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


