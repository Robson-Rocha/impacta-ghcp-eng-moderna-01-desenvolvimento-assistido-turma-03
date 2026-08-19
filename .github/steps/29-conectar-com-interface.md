# Passo 29 - Conectar com a interface (Slide 25)

Com o contrato da API e a persistência estáveis, vamos fechar a primeira fatia vertical conectando a interface ao fluxo de criação.

Abra uma **nova sessão** no modo **Agent** e execute o prompt. Depois rode API e Client em terminais separados:

```bash
dotnet run --project src/Api --launch-profile http --urls http://127.0.0.1:5080
```

```bash
dotnet run --project src/Client --launch-profile http --urls http://127.0.0.1:5152
```

Confirme portas, CORS, sucesso e falha no navegador.


Execute este prompt:

```text
Leia `docs/specs/training-catalog-vertical-slice.md`.
Implemente na interface Blazor WebAssembly somente o fluxo de criação de treinamento descrito na especificação.
Se o contrato implementado divergir do documento, não o altere silenciosamente: descreva a divergência e aguarde decisão.

O fluxo deve:
- coletar título, descrição, data de início e carga horária;
- enviar os dados ao endpoint existente sem alterar seu contrato;
- indicar carregamento durante a requisição;
- em caso de sucesso, exibir confirmação e atualizar a lista;
- em caso de erro, mostrar mensagem útil sem perder os dados preenchidos.

Restrições:
- reutilize os padrões já existentes no projeto;
- não implemente edição ou exclusão;
- não duplique modelos se já houver um contrato compartilhado adequado;
- não altere a API sem antes justificar e solicitar aprovação.

Antes de editar, apresente um plano curto e os arquivos envolvidos.
Ao final, execute as validações disponíveis e descreva como testar sucesso e erro no navegador.
```

## Referências

- [Chamar API Web no Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/call-web-api)
- [Chat no VS Code](https://docs.github.com/en/copilot/how-tos/chat-with-copilot/chat-in-ide)

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


