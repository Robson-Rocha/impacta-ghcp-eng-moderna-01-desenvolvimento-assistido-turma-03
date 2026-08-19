# Passo 35 - Executar a revisão final com o agente (Slide 30)

Chegou o momento de reunir as evidências. O agente especializado executará teste, inspecionará o OpenAPI em runtime e verificará o workflow.

Abra uma **nova sessão**, selecione **Revisor da entrega** e execute o prompt. Aprove os comandos antes da execução e confirme que a API local é encerrada.


Execute este prompt:

```text
Revise a entrega da criação de treinamento contra `docs/specs/training-catalog-vertical-slice.md`.

Use os arquivos selecionados para relacionar os critérios às evidências disponíveis no teste, na configuração e nos metadados que geram o contrato OpenAPI, e no workflow de CI.

Antes de executar comandos, apresente-os e aguarde minha aprovação. Depois:
1. execute o teste principal;
2. identifique o projeto e o comando corretos para iniciar a API em ambiente de desenvolvimento;
3. inicie a API localmente e aguarde até que esteja pronta;
4. descubra pela configuração ou pela saída da aplicação a URL que expõe o documento OpenAPI;
5. obtenha o JSON por uma requisição HTTP a `localhost`;
6. verifique no documento a operação `POST /api/trainings`, seus dados de entrada, a resposta `201 Created` e o erro de validação `400 Bad Request`;
7. encerre o processo da API;
8. verifique se o workflow executa os mesmos comandos de build e testes validados localmente.

Não use somente a presença da Swagger UI como evidência do contrato. Se não conseguir executar alguma etapa, classifique o critério relacionado como "não foi possível comprovar", mostre a causa e indique a menor validação adicional necessária.
```

Quando tiver concluído, comente `validado` nesta issue para receber o próximo passo.


