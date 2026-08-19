# Passo 13 - Adicionar Swagger UI (Slide 12)

O endpoint precisa ser observável, não apenas compilável. Vamos adicionar uma interface de desenvolvimento para executar o contrato no navegador.

Continue na **mesma sessão** no modo **Agent**. Confirme que a UI só fica disponível em desenvolvimento.


Execute este prompt:

```text
Adicione Swagger UI ao projeto da API para permitir testes manuais no navegador durante o desenvolvimento.

Antes de editar:
1. inspecione a configuração OpenAPI existente;
2. informe quais arquivos e dependências precisam mudar;
3. preserve o comportamento de `POST /api/trainings`.

Requisitos:
- gere e exponha o documento OpenAPI;
- disponibilize uma Swagger UI interativa somente no ambiente de desenvolvimento;
- permita executar `POST /api/trainings` diretamente pela interface;
- não adicione novos endpoints nem altere contratos;
- use versões de pacotes compatíveis com o .NET 10 e com as dependências atuais do projeto.

Depois de implementar:
1. execute a API;
2. informe a URL da Swagger UI;
3. pela interface, envie um treinamento válido e confirme `201 Created`;
4. envie um treinamento inválido e confirme `400 Bad Request`;
5. informe os arquivos alterados e as evidências observadas.
```

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


