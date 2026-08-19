# Passo 3 - Propor erros sem exemplo (Slide 05)

Antes de fechar o contrato de validação, vamos observar como o Copilot responde quando recebe a intenção, mas nenhum exemplo do formato esperado.

Abra uma **nova sessão** no modo **Ask**. Execute o zero-shot e guarde o resultado sem refiná-lo.


Execute este prompt:

```text
Estamos definindo o contrato de validação de uma API HTTP para cadastro de treinamentos.

O endpoint será `POST /api/trainings` e receberá JSON com:
- `title`: texto obrigatório;
- `description`: texto obrigatório;
- `startDate`: data obrigatória no formato `YYYY-MM-DD`;
- `durationHours`: número inteiro obrigatório e maior que zero.

Quando a entrada for inválida, a API deverá retornar `400 Bad Request` com um corpo JSON que identifique os campos e apresente mensagens úteis para correção.

Sem escrever código, proponha as respostas de erro para:
- data de início ausente;
- carga horária igual a zero.

Para cada caso, mostre:
1. o JSON completo da entrada inválida;
2. o status HTTP;
3. o corpo JSON da resposta.

Não invente novas regras de negócio.
```

## Referências

- [Engenharia de prompts](https://docs.github.com/en/copilot/concepts/prompting/prompt-engineering)
- [Zero-shot e few-shot](https://learn.microsoft.com/en-us/dotnet/ai/conceptual/zero-shot-learning)

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


