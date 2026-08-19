## Etapa 12 — Pedir o rascunho do prompt file

Vamos continuar na **mesma sessão anterior** do Copilot Chat, em modo **Agent**.

Execute este prompt:

```text
Transforme o fluxo que acabamos de validar em um prompt file reutilizável para criar um endpoint por vez na API de treinamentos.

Crie `.github/prompts/criar-endpoint-treinamento.prompt.md`.

O prompt file deve:
- usar o agente `agent`;
- receber entradas para operação, rota, contrato e validação;
- mandar inspecionar o endpoint de criação existente antes de propor mudanças;
- preservar as repository instructions e as convenções já validadas;
- apresentar plano e arquivos envolvidos antes de editar;
- implementar somente um endpoint por invocação;
- executar a validação informada;
- relacionar o resultado ao contrato;
- pedir esclarecimento em vez de inventar regras.

Não fixe um modelo.
Não inclua no arquivo detalhes exclusivos do endpoint `POST`.
Antes de criar o arquivo, mostre o conteúdo proposto e explique o que ficou fixo e o que virou entrada.
```

Quando tiver concluido esta etapa, comente `planejado` nesta issue para receber o proximo passo.
