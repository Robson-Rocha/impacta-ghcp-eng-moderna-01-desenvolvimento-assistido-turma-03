# Passo 6 - Revisar a especificação com o Copilot (Slide 06)

Com o primeiro rascunho pronto, vamos usar o Copilot como revisor de lacunas — não como responsável pelas decisões do produto.

Abra uma **nova sessão** no modo **Ask** e execute o prompt abaixo.

A turma decide quais achados incorporar à especificação; o Copilot apenas torna as lacunas visíveis.


Execute este prompt:

```text
Revise o rascunho de especificação da primeira fatia vertical do catálogo de treinamentos em docs/specs/training-catalog-vertical-slice.md.

Não reescreva o documento.
Não proponha arquitetura, bibliotecas ou código.
Não complete lacunas por suposição.

Identifique somente:
1. informações necessárias que estão ausentes;
2. termos ou comportamentos ambíguos;
3. critérios que não são observáveis ou testáveis;
4. conflitos entre objetivo, escopo e critérios.

Para cada achado:
- cite o trecho relacionado;
- explique o risco;
- formule uma pergunta curta para decisão humana.

Se algo não puder ser concluído a partir do rascunho, marque como “A decidir”.
```

Quando tiver concluído, comente `validado` nesta issue para receber o próximo passo.


