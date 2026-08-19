# Especificação — Primeira fatia vertical do catálogo de treinamentos

## Estado

- Status: aprovado
- Responsáveis: turma e instrutor
- Última revisão: preencher ao versionar

## Objetivo

Permitir que uma pessoa responsável cadastre um treinamento interno e confirme, pela interface, que o novo item foi aceito e incluído no catálogo.

## Escopo

- receber os dados de um treinamento pela API;
- rejeitar dados obrigatórios ausentes ou inválidos;
- armazenar um treinamento válido;
- permitir consultar os itens cadastrados;
- oferecer uma interface para cadastrar e visualizar o novo item;
- produzir evidências automatizadas do comportamento principal.

## Fora do escopo desta fatia

- autenticação e autorização;
- paginação, busca e ordenação;
- regras de capacidade ou inscrição;
- edição e exclusão na interface;
- escolha definitiva do provedor de banco de dados;
- requisitos de produção, observabilidade e alta disponibilidade.

Operações adicionais de API podem ser implementadas depois com contratos explícitos, desde que não alterem silenciosamente os comportamentos aprovados aqui.

## Dados do treinamento

| Campo | Tipo | Regra |
| --- | --- | --- |
| `id` | identificador | gerado pelo sistema |
| `title` | texto | obrigatório e não vazio |
| `description` | texto | obrigatório e não vazio |
| `startDate` | data no formato `YYYY-MM-DD` | obrigatória, igual ou posterior à data atual e exclusiva no catálogo |
| `durationHours` | inteiro | obrigatório e maior que zero |

## Contrato da API para criação

### Requisição

- Método e rota: `POST /api/trainings`
- Corpo: título, descrição, data de início e carga horária

### Sucesso

- Status: `201 Created`
- Inclui o identificador gerado e a representação do treinamento
- Informa a localização do recurso criado

### Falha de validação

- Status: `400 Bad Request`
- Corpo no formato:

  ```json
  {
    "errors": {
      "fieldName": ["Mensagem útil para correção."]
    }
  }
  ```

### Conflito

- Status: `409 Conflict`
- Ocorre quando já existe um treinamento com a mesma `startDate`
- Corpo no formato:

  ```json
  {
    "errors": {
      "startDate": ["Já existe um treinamento com esta data de início."]
    }
  }
  ```

## Contrato da API para consulta

### Requisição

- Método e rota: `GET /api/trainings`

### Sucesso

- Status: `200 OK`
- Retorna uma coleção de treinamentos.
- Quando não há treinamentos cadastrados, retorna uma coleção vazia.

## Contrato da API para consulta por identificador

### Requisição

- Método e rota: `GET /api/trainings/{id}`

### Sucesso

- Status: `200 OK`
- Retorna o treinamento correspondente ao identificador.

### Não encontrado

- Status: `404 Not Found`
- Ocorre quando não há treinamento com o identificador informado.

## Contrato da API para atualização

### Requisição

- Método e rota: `PUT /api/trainings/{id}`
- Corpo: título, descrição, data de início e carga horária

### Sucesso

- Status: `200 OK`
- Retorna o treinamento atualizado.

### Falha de validação

- Status: `400 Bad Request`
- Ocorre quando os dados não atendem às regras do treinamento.

### Não encontrado

- Status: `404 Not Found`
- Ocorre quando não há treinamento com o identificador informado.

### Conflito

- Status: `409 Conflict`
- Ocorre quando outro treinamento já existe com a mesma `startDate`.
- Corpo no formato:

  ```json
  {
    "errors": {
      "startDate": ["Já existe um treinamento com esta data de início."]
    }
  }
  ```

## Contrato da API para exclusão

### Requisição

- Método e rota: `DELETE /api/trainings/{id}`

### Sucesso

- Status: `204 No Content`
- Ocorre quando o treinamento é excluído.

### Não encontrado

- Status: `404 Not Found`
- Ocorre quando não há treinamento com o identificador informado.

## Comportamento da interface

- desabilitar ou proteger novo envio enquanto a requisição estiver em andamento;
- informar sucesso depois da confirmação da API;
- atualizar a lista com o item criado;
- em caso de erro, apresentar mensagem útil sem apagar os dados preenchidos.

## Critérios de aceitação

1. Dado um título ausente, quando o cadastro for enviado, então a API retorna `400` e identifica o campo `title`.
2. Dada uma descrição ausente, quando o cadastro for enviado, então a API retorna `400` e identifica o campo `description`.
3. Dada uma data de início ausente, quando o cadastro for enviado, então a API retorna `400` e identifica o campo `startDate`.
4. Dada uma carga horária igual ou inferior a zero, quando o cadastro for enviado, então a API retorna `400` e identifica o campo `durationHours`.
5. Dada uma data de início anterior à data atual, quando o cadastro for enviado, então a API retorna `400` e identifica o campo `startDate`.
6. Dados válidos produzem `201`, um identificador e um recurso consultável depois da criação.
7. Quando não há treinamentos cadastrados, a consulta retorna `200` com uma coleção vazia.
8. Depois de cadastrar um treinamento válido, a consulta retorna `200` com o item criado.
9. Dado o identificador de um treinamento cadastrado, a consulta retorna `200` com o treinamento correspondente.
10. Dado um identificador sem treinamento cadastrado, a consulta retorna `404`.
11. Dado um treinamento cadastrado, quando dados válidos são enviados para atualização, então a API retorna `200` com o recurso atualizado.
12. Dado um treinamento cadastrado, quando dados inválidos são enviados para atualização, então a API retorna `400`.
13. Dado um identificador sem treinamento cadastrado, quando uma atualização é enviada, então a API retorna `404`.
14. Dado outro treinamento já cadastrado para uma data de início, quando a atualização usa a mesma `startDate`, então a API retorna `409` e identifica o campo `startDate`, sem alterar o treinamento.
15. Dado um treinamento cadastrado, quando uma exclusão é enviada, então a API retorna `204` sem conteúdo.
16. Dado um identificador sem treinamento cadastrado, quando uma exclusão é enviada, então a API retorna `404`.
17. Pela interface, dados válidos produzem confirmação e o novo item aparece na lista.
18. Pela interface, uma falha preserva os dados preenchidos e apresenta mensagem útil.
19. Dado um treinamento já cadastrado para uma data de início, quando outro treinamento for enviado com a mesma `startDate`, então a API retorna `409` e identifica o campo `startDate`, sem armazenar o segundo treinamento.

## Evidências esperadas

| Critério | Evidência mínima |
| --- | --- |
| validação de entrada | resposta HTTP e teste automatizado |
| criação válida | resposta `201` e teste automatizado |
| exclusividade da data | resposta `409` e teste automatizado confirmando que o segundo item não foi armazenado |
| armazenamento | consulta bem-sucedida após reiniciar a API |
| sucesso na interface | fluxo executado no navegador |
| erro na interface | fluxo de falha executado no navegador |
| integração contínua | workflow executando build e testes |

## Decisões ainda abertas

- provedor e configuração do banco de dados;
- organização interna dos projetos, desde que preserve os contratos;
- detalhes visuais da interface;
- estratégia adicional de testes além da evidência mínima.

Decisões abertas devem ser resolvidas antes da etapa que depende delas e registradas neste documento quando alterarem o comportamento esperado.