## Etapa 3 — Explorar respostas de erro com zero-shot

Agora vamos observar o que o modelo produz quando o formato não está rigidamente exemplificado.

Abra o Copilot Chat em uma **nova sessão** e use o modo **Ask**.

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

Guarde a resposta para compará-la com a próxima etapa.

Quando tiver concluido esta etapa, comente `feito` nesta issue para receber o proximo passo.
