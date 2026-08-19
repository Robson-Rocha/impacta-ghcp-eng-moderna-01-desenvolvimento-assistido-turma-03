# Passo 14 - Validar o primeiro endpoint na Swagger UI (Slide 13)

Agora vamos sair do código e observar o comportamento real da API. Esta validação ajudará a distinguir contrato atendido de expectativa ainda não especificada.

Em terminal que **não seja o terminal do agente**, rode:

```bash
dotnet run --project src/Api/TrainingCatalog.Api.csproj --urls http://127.0.0.1:5080
```

Abra `http://127.0.0.1:5080/swagger/index.html`. Execute casos válido e inválido e observe duas criações com a mesma `startDate`.

## Referências

- [Códigos de status HTTP](https://www.rfc-editor.org/rfc/rfc9110.html#name-client-error-4xx)

Quando tiver concluído, comente `validado` nesta issue para receber o próximo passo.


