# Passo 19 - Executar o prompt file pela primeira vez (Slide 16)

Antes de fornecer qualquer entrada, vamos invocar o prompt file sozinho para observar quais decisões ele solicita. Depois, usaremos o primeiro contrato real.

Continue na **mesma sessão**, em modo **Agent**. Primeiro invoque apenas:

```text
/create-training-endpoint
```

Observe as entradas solicitadas; depois forneça as entradas oficiais de listagem.


Execute este prompt:

```text
Operação=Listar todos os treinamentos
Rota=GET /api/trainings
Contrato=Retornar 200 OK com uma coleção de treinamentos; quando não houver registros, retornar uma coleção vazia
Validação=Executar um teste para catálogo vazio e outro após cadastrar um treinamento
```

Quando tiver concluído, comente `validado` nesta issue para receber o próximo passo.


