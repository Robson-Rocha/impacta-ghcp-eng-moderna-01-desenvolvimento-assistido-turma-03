# Passo 11 - Criar a base da solução (Slide 10)

Depois de revisar e aprovar o plano, chegou a hora de criar apenas a fundação da solução — sem antecipar os incrementos seguintes.

Na **mesma sessão**, alterne para **Agent** e execute o prompt. Confirme que endpoints e regras de negócio não foram antecipados.


Execute este prompt:

```text
Implemente somente a base aprovada no plano anterior.

Durante a execução:
- preserve o escopo e as decisões de `docs/specs/training-catalog-vertical-slice.md`;
- mostre os comandos antes de executá-los;
- não implemente endpoints, persistência ou componentes de negócio;
- não adicione dependências fora do plano;
- preserve os arquivos existentes;
- pare se a implementação exigir uma decisão ainda aberta na especificação;
- ao final, execute restore e build usando os comandos das repository instructions.

Depois, resuma:
1. arquivos e projetos criados;
2. decisões aplicadas;
3. resultado da validação;
4. qualquer desvio em relação ao plano.
```

> [!TIP]
> Se necessário, sincronize com `checkpoint/02-criar-base-solucao`.

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


