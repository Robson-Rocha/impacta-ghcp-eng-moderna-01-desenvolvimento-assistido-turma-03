# Passo 26 - Aplicar a migration revisada (Slide 21)

Depois da revisão e da aprovação humana, vamos aplicar somente as migrations pendentes ao banco local de desenvolvimento.

Continue na **mesma sessão** no modo **Agent**. Após aprovar a revisão, confirme explicitamente alvo, comando e migrations pendentes antes de aplicar.


Execute este prompt:

```text
A migration recém-gerada já foi revisada e aprovada. Conduza sua aplicação no banco SQLite de desenvolvimento.

Antes de executar qualquer comando:
1. identifique o projeto que contém o `DbContext` e o projeto de inicialização;
2. informe a connection string efetiva e o caminho do arquivo SQLite que será alterado, sem revelar segredos;
3. confirme quais migrations estão pendentes;
4. apresente o comando exato que pretende executar e explique cada opção;
5. confirme que o alvo é o banco local de desenvolvimento, não um ambiente compartilhado ou de produção.

Se o alvo, a configuração ou a migration pendente estiverem ambíguos, pare e peça esclarecimento.

Após minha aprovação:
1. aplique somente as migrations pendentes;
2. confirme o código de saída do comando;
3. verifique que o banco registra a migration aplicada;
4. inspecione o esquema criado e compare tabelas, colunas, chaves, índices e nulabilidade com a migration;
5. execute o menor comando de build necessário para detectar inconsistências posteriores.

Não gere outra migration, não altere arquivos e não apague nem recrie o banco silenciosamente.
Se a aplicação falhar, preserve a saída do erro, investigue somente a causa relacionada e não use `--force` nem outro atalho destrutivo.
```

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


