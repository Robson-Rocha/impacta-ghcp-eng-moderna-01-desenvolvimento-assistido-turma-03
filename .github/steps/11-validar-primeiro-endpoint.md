## Etapa 11 — Validar o primeiro endpoint na Swagger UI

Agora valide manualmente o que acabou de ser implementado.

Rode a API em um terminal que **não seja o terminal do agente**:

```bash
dotnet run --project src/Api/TrainingCatalog.Api.csproj --urls http://127.0.0.1:5080
```

Abra no navegador:

```text
http://127.0.0.1:5080/swagger/index.html
```

Faça pelo menos:

1. um teste de criação válida;
2. um teste de validação inválida.

Quando tiver concluido esta etapa, comente `validado` nesta issue para receber o proximo passo.
