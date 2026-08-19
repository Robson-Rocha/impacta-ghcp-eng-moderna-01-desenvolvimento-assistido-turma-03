# Passo 17 - Propor o prompt file reutilizável (Slide 16)

Com um endpoint validado de ponta a ponta, podemos extrair o método de trabalho para uma tarefa reutilizável — sem copiar detalhes exclusivos do cadastro.

Continue na **mesma sessão** no modo **Agent**. O arquivo deverá ser criado em `.github/prompts/create-training-endpoint.prompt.md`.


Execute este prompt:

```text
Transforme o fluxo que acabamos de validar em um prompt file reutilizável para criar um endpoint por vez na API de treinamentos.

Crie `.github/prompts/create-training-endpoint.prompt.md`.

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

## Referências

- [Prompt files no VS Code](https://code.visualstudio.com/docs/agent-customization/prompt-files)
- [Criar e testar um prompt file](https://docs.github.com/en/copilot/tutorials/customization-library/prompt-files/your-first-prompt-file)

Quando tiver concluído, comente `planejado` nesta issue para receber o próximo passo.


