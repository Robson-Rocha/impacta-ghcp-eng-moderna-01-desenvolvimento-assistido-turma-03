# Passo 27 - Comprovar o CRUD persistido (Slide 21)

Uma migration aplicada não comprova que o CRUD inteiro usa a mesma fonte. Vamos produzir uma evidência funcional pela API pública.

Continue na **mesma sessão** no modo **Agent**. Revise o teste funcional, o isolamento do SQLite e a evidência de cada operação.


Execute este prompt:

```text
Comprove que todos os endpoints do catálogo usam a mesma persistência com Entity Framework Core.

Primeiro, inspecione os testes existentes e a forma documentada de executá-los. Proponha o menor teste funcional que cubra, em sequência:
1. criar um treinamento válido;
2. consultar o treinamento criado;
3. atualizar esse treinamento;
4. consultar novamente e confirmar os dados atualizados;
5. excluir o treinamento;
6. confirmar que ele não pode mais ser consultado;
7. comprovar também um erro de validação já definido ou a consulta de um identificador inexistente.

Restrições:
- use a API pública; não teste o `DbContext` diretamente;
- use um banco SQLite novo e com estado conhecido para o teste;
- não dependa do banco de desenvolvimento nem da ordem de outros testes;
- preserve os contratos HTTP já aprovados;
- não adicione abstrações apenas para acomodar o teste;
- não amplie a cobertura para interface, autenticação ou comportamentos não especificados.

Antes de editar:
1. informe se um teste existente já cobre todos os cenários;
2. apresente o arquivo que pretende criar ou alterar;
3. relacione cada etapa aos status e respostas esperados;
4. informe o comando direcionado que executará.

Após minha aprovação, implemente somente o que estiver ausente, execute o teste direcionado e apresente:
- resultado do comando;
- evidência de cada etapa do fluxo;
- confirmação de isolamento do banco;
- arquivos alterados;
- qualquer divergência entre comportamento e contrato.

Se o teste falhar, investigue a causa antes de alterar código de produção. Não transforme uma expectativa não especificada em correção automática.
```

Quando tiver concluído, comente `validado` nesta issue para receber o próximo passo.


