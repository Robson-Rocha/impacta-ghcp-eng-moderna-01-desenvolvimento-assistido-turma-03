# Passo 1 - Preparar o Codespace (Slide 03)

Vamos começar pelo mesmo estado base usado pelo instrutor. Assim, você poderá acompanhar as demonstrações ou recorrer aos checkpoints sem perder o contexto da aula.

O GitHub Codespaces cria um ambiente de desenvolvimento isolado na nuvem, já configurado com o VS Code, o .NET SDK e as extensões necessárias. Você trabalhará pelo navegador, sem precisar instalar essas ferramentas em seu computador.

> [!NOTE]
> Este Codespace usa intencionalmente uma imagem baseada no .NET 10 RC. Ela foi mantida para introduzir pequenas incompatibilidades semelhantes às encontradas em ambientes reais e exercitar diagnóstico, validação e decisões conscientes sobre ferramentas. Não a considere uma recomendação para ambientes de produção.

[![Abrir no GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/{{ repository }}?quickstart=1)

1. Clique no botão acima. Uma nova página do GitHub será aberta com este repositório selecionado.
2. Confirme que a branch exibida é `main` e selecione **Create codespace**.
3. Aguarde enquanto o GitHub prepara o ambiente. Esse processo pode levar alguns minutos na primeira execução.
4. Quando o VS Code abrir no navegador, espere a conclusão das notificações e dos comandos de preparação. Não feche a página durante essa etapa.
5. Abra um terminal pelo menu **Terminal > New Terminal**. Ele será usado para executar os comandos do walkthrough.
6. No terminal, troque para o ponto de partida do módulo:

```bash
   git switch checkpoint/00-inicio
```

7. Confirme que o SDK esperado está disponível:

```bash
   dotnet --version
```

O comando deve informar uma versão do .NET 10. O diretório `src` estará vazio de propósito: ao longo do walkthrough, você criará a solução em incrementos pequenos e verificáveis.

> [!TIP]
> Se o terminal não estiver visível, use o atalho <kbd>Ctrl</kbd>+<kbd>`</kbd> para abri-lo. Você também pode recarregar o Codespace pelo navegador caso a preparação pare de responder.

> [!IMPORTANT]
> Este walkthrough depende das branches de checkpoint copiadas do template. Se `checkpoint/00-inicio` não existir, recrie o repositório marcando **Include all branches**.

## Referências

- [Criar repositório a partir de template](https://docs.github.com/en/repositories/creating-and-managing-repositories/creating-a-repository-from-a-template)
- [Criar um Codespace](https://docs.github.com/en/codespaces/developing-in-a-codespace/creating-a-codespace-for-a-repository)

Quando o ambiente estiver pronto, comente `preparado` nesta issue para receber o próximo passo.

