# Passo 4 - Indicar um padrão com exemplos (Slide 05)

Agora vamos repetir a mesma tarefa com exemplos explícitos. A comparação mostrará como um padrão fornecido no prompt reduz escolhas indesejadas sem substituir a revisão humana.

Abra outra **nova sessão** no modo **Ask**, usando o mesmo modelo e contexto. Execute o few-shot e compare estrutura, consistência e aderência.


Execute este prompt:

```text
Estamos definindo o contrato de validação de uma API HTTP para cadastro de treinamentos.

O endpoint será `POST /api/trainings` e receberá JSON com:
- `title`: texto obrigatório;
- `description`: texto obrigatório;
- `startDate`: data obrigatória no formato `YYYY-MM-DD`;
- `durationHours`: número inteiro obrigatório e maior que zero.

Quando a entrada for inválida, a API deverá retornar `400 Bad Request` no formato Problem Details definido pela RFC 9457, com o media type `application/problem+json`. Use a extensão `errors` para identificar os campos e apresentar mensagens úteis para correção.

Use estes exemplos como padrão:

Exemplo 1 — entrada inválida:
{
  "title": "",
  "description": "Introdução ao C#",
  "startDate": "2026-09-15",
  "durationHours": 8
}

Exemplo 1 — status HTTP:
400 Bad Request

Exemplo 1 — Content-Type:
application/problem+json

Exemplo 1 — erro esperado:
{
  "type": "https://tools.ietf.org/html/rfc9110#section-15.5.1",
  "title": "Ocorreram um ou mais erros de validação.",
  "status": 400,
  "errors": {
    "title": ["O título é obrigatório."]
  }
}

Exemplo 2 — entrada inválida:
{
  "title": "GitHub Copilot",
  "description": "",
  "startDate": "2026-09-15",
  "durationHours": 8
}

Exemplo 2 — status HTTP:
400 Bad Request

Exemplo 2 — Content-Type:
application/problem+json

Exemplo 2 — erro esperado:
{
  "type": "https://tools.ietf.org/html/rfc9110#section-15.5.1",
  "title": "Ocorreram um ou mais erros de validação.",
  "status": 400,
  "errors": {
    "description": ["A descrição é obrigatória."]
  }
}

Sem escrever código, proponha as respostas de erro para:
- data de início ausente;
- carga horária igual a zero.

Para cada caso, mostre:
1. o JSON completo da entrada inválida;
2. o status HTTP;
3. o `Content-Type`;
4. o corpo Problem Details da resposta, preservando os membros `type`, `title`, `status` e `errors` apresentados nos exemplos.

Não invente novas regras de negócio.
```

Quando tiver concluído, comente `feito` nesta issue para receber o próximo passo.


