# Passo 31 - Planejar CI (Slide 29)

As validações locais já são conhecidas. Agora vamos planejar como reproduzi-las no GitHub Actions com comandos explícitos e permissões mínimas.

Abra uma **nova sessão** no modo **Plan**. Revise gatilhos, permissões, .NET, solução, testes e comandos antes de aprovar.


Execute este prompt:

```text
Planeje um workflow de integração contínua para esta solução .NET 10.

O workflow deverá ser criado em `.github/workflows/ci.yml` e executar em pushes para `main` e em pull requests direcionados a `main`.

Antes de propor o YAML:
1. identifique o arquivo de solução e todos os projetos de testes;
2. verifique como a versão do .NET está definida no repositório;
3. identifique os comandos de restore, build e testes já usados com sucesso;
4. verifique se algum workload ou preparação adicional está realmente documentado;
5. sinalize informações ausentes ou conflitos.

O plano deve prever:
- Ubuntu como runner;
- permissões mínimas, começando por `contents: read`;
- checkout do repositório;
- instalação do .NET 10 e do SQLite;
- restore explícito;
- build em `Release` sem novo restore;
- execução de todos os testes sem novo build;
- timeout para evitar execução indefinida;
- versões estáveis e oficialmente documentadas das actions no momento da implementação.

Não inclua publicação, deploy, secrets, banco externo, matriz de versões, cobertura ou cache sem necessidade documentada.

Apresente:
1. gatilhos;
2. permissões;
3. passos e comandos exatos;
4. arquivos que serão criados ou alterados;
5. como validar localmente os mesmos comandos;
6. como comprovar a primeira execução no GitHub.

Não edite arquivos.
```

## Referências

- [Aplicações .NET com GitHub Actions](https://docs.github.com/en/actions/how-tos/use-cases-and-examples/building-and-testing/building-and-testing-net)
- [Sintaxe de workflows](https://docs.github.com/en/actions/reference/workflows-and-actions/workflow-syntax)
- [Permissões do GITHUB_TOKEN](https://docs.github.com/en/actions/how-tos/security-for-github-actions/security-guides/automatic-token-authentication)

Quando tiver concluído, comente `planejado` nesta issue para receber o próximo passo.


