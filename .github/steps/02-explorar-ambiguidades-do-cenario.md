# Passo 2 - Explorar ambiguidades do cenário (Slide 04)

Antes de falar de arquitetura ou código, vamos usar o Copilot para revelar decisões que ainda estão escondidas no cenário.

Abra o Copilot Chat em uma **nova sessão** e selecione o modo **Ask**. Execute este prompt:

```text
Precisamos construir uma aplicação para administrar um catálogo de treinamentos internos.

O resultado deverá incluir:
- uma API HTTP para cadastrar, consultar, alterar e excluir treinamentos;
- persistência dos dados;
- uma interface web para executar essas operações;
- testes e integração contínua.

A primeira fatia vertical permitirá cadastrar um treinamento pela API e confirmar o novo item na interface. Ainda não definimos os campos obrigatórios, regras de validação, contratos HTTP, comportamento da persistência nem estados da interface.

Antes de sugerir arquitetura, tecnologia ou código, identifique as ambiguidades que impedem transformar essa primeira fatia em um incremento verificável.

Organize a resposta em:
1. perguntas essenciais;
2. riscos de assumir respostas;
3. critérios que já podem ser derivados da intenção.

Considere explicitamente API, persistência e interface.
Limite-se às cinco perguntas que mais afetam o contrato e a validação da primeira fatia.
```

Leia a resposta e observe se as perguntas realmente ajudam a tornar a primeira fatia verificável. Não trate as sugestões como requisitos prontos: elas serão insumos para as decisões da turma.

Guarde a resposta. Você voltará a ela nos próximos passos.

## Referências

- [Escolher a ferramenta de IA adequada](https://docs.github.com/en/copilot/concepts/tools/ai-tools)

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


