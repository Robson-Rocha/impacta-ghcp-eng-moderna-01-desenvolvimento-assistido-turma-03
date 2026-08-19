## Etapa 1 — Preparar o Codespace e abrir o ponto de partida

Vamos começar pelo mesmo estado base usado no walkthrough do instrutor.

[![Abrir no GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/{{ repository }}?quickstart=1)

1. Clique no botão acima e crie um Codespace a partir da branch `main`.
2. Aguarde a criação do ambiente e a conclusão do comando de pós-criação.
3. No terminal do Codespace, troque para a branch inicial do módulo:

   ```bash
   git switch checkpoint/00-inicio
   ```

4. Confirme que o ambiente respondeu corretamente:

   ```bash
   dotnet --version
   ```

O diretório `src` estará vazio de propósito. A solução será criada durante a aula.

> [!IMPORTANT]
> Este walkthrough depende das branches de checkpoint copiadas do template. Se a branch `checkpoint/00-inicio` não existir, exclua este repositório e crie uma nova cópia do template marcando **Include all branches**.

Quando tiver concluido esta etapa, comente `preparado` nesta issue para receber o proximo passo.
