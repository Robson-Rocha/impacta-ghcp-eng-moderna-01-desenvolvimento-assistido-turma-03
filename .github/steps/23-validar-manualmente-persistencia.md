## Etapa 23 — Validar manualmente a persistência

Agora faça a validação manual em terminais que **não sejam o terminal do agente**.

Rode a API:

```bash
dotnet run --project src/Api/TrainingCatalog.Api.csproj --urls http://127.0.0.1:5080
```

Abra:

```text
http://127.0.0.1:5080/swagger/index.html
```

Faça estes testes manuais:

1. crie três treinamentos com `POST /api/trainings`;
2. liste os treinamentos com `GET /api/trainings`;
3. abra o banco `src/Api/training-catalog.db` com a extensão SQLite do Codespaces;
4. no painel do VS Code, expanda o SQLite Explorer e inspecione a tabela `Trainings`.

Quando tiver concluido esta etapa, comente `validado` nesta issue para receber o proximo passo.
