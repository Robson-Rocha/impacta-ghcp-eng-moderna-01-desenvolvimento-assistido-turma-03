## Etapa 25 — Criar o workflow de integração contínua

Vamos continuar na **mesma sessão anterior**, agora em modo **Agent**.

Execute este prompt:

```text
Implemente o plano aprovado em `.github/workflows/ci.yml`.

Antes de editar, repita:
1. o arquivo que será criado;
2. os gatilhos e permissões;
3. as actions e respectivas versões;
4. os comandos de restore, build e testes.

Requisitos:
- use somente actions oficiais necessárias;
- configure `permissions` explicitamente com o menor acesso possível;
- fixe versões estáveis das actions conforme a documentação oficial vigente;
- use .NET 10 e a configuração `Release`;
- preserve a separação entre restore, build e testes;
- não adicione publicação, deploy, secrets ou permissões de escrita;
- não altere código da aplicação para satisfazer o workflow.

Após criar o arquivo:
1. explique cada seção do YAML;
2. confira sintaxe, indentação, caminhos e nomes usados;
3. execute localmente os comandos equivalentes aos passos de restore, build e testes;
4. apresente o resultado de cada comando;
5. informe como versionar e disparar a primeira execução no GitHub;
6. indique onde observar logs e identificar o passo que falhou.

Não faça commit, push ou deploy.
Se algum comando falhar, investigue a causa antes de alterar o workflow e não o enfraqueça removendo validações.
```

Quando tiver concluido esta etapa, comente `feito` nesta issue para receber o proximo passo.
