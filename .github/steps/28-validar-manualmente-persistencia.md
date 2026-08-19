# Passo 28 - Validar manualmente a persistência (Slide 22)

Agora confirme no navegador e no banco o que o teste automatizado demonstrou: os dados sobrevivem ao processo e podem ser inspecionados.

Em terminal que **não seja o terminal do agente**, rode:

```bash
dotnet run --project src/Api/TrainingCatalog.Api.csproj --urls http://127.0.0.1:5080
```

Abra `http://127.0.0.1:5080/swagger/index.html` e:

1. crie três treinamentos com `POST /api/trainings`;
2. liste com `GET /api/trainings`;
3. reinicie a API e confirme persistência;
4. pressione F1 e execute `SQLite: Open Database`;
5. abra `src/Api/training-catalog.db`;
6. expanda **SQLite Explorer** e inspecione `Trainings`.

## Referências

- [Migrations do EF Core](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/)

> [!TIP]
> Se necessário, sincronize com `checkpoint/05-adicionar-persistencia`.

Quando tiver concluído, comente `validado` nesta issue para receber o próximo passo.


