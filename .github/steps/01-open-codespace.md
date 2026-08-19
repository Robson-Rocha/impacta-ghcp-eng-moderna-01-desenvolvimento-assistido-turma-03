## Etapa 1 — Abra o ambiente do walkthrough

Começaremos pelo mesmo estado mínimo usado na demonstração: um Codespace com .NET 10 e
SQLite, mas sem uma solução pronta.

[![Abrir no GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/{{ repository }}?quickstart=1)

1. Clique no botão acima e crie o Codespace a partir da branch `main`.
2. Aguarde a criação do ambiente e a conclusão do comando de pós-criação.
3. No terminal do Codespace, acesse o ponto de partida do walkthrough:

   ```bash
   git switch checkpoint/00-inicio
   ```

4. Confirme as ferramentas:

   ```bash
   dotnet --version
   ```

O diretório `src` estará vazio de propósito. A solução será criada durante a aula.

> [!IMPORTANT]
> Se a branch `checkpoint/00-inicio` não existir, o repositório provavelmente foi criado
> sem **Include all branches**. Exclua a cópia e crie-a novamente marcando essa opção.

Quando o ambiente estiver pronto, responda nesta issue com `pronto`.
