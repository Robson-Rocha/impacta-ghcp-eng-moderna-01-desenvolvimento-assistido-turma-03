# Módulo 1 — Do requisito à aplicação

Neste walkthrough, você usará o GitHub Copilot como colaborador supervisionado para
construir uma aplicação .NET 10 de ponta a ponta. A jornada parte de uma necessidade de
negócio e avança em incrementos pequenos por especificação, API, persistência, interface
e integração contínua.

O objetivo não é produzir código idêntico ao do instrutor. O trabalho será comparado por
critérios, contratos, comportamento e evidências.

## Como iniciar

1. Use o botão abaixo para criar seu próprio repositório.
2. Na tela de criação, marque **Include all branches**. As branches de checkpoint são os
   pontos de partida de cada etapa e não serão copiadas sem essa opção.
3. Aguarde alguns segundos e atualize a página. Um workflow substituirá este README por
   um link para a issue que conduzirá o walkthrough.

[![Iniciar walkthrough](https://img.shields.io/badge/Iniciar%20walkthrough-%E2%86%92-1f883d?style=for-the-badge&logo=github&labelColor=197935)](https://github.com/new?template_owner=impacta-ghcp-eng-moderna&template_name=01-desenvolvimento-assistido&owner=%40me&name=impacta-ghcp-eng-moderna-01-desenvolvimento-assistido&description=M%C3%B3dulo+1%3A+do+requisito+%C3%A0+aplica%C3%A7%C3%A3o)

> [!IMPORTANT]
> ## Antes de criar o repositório: marque **Include all branches**
>
> Na tela aberta pelo botão, ative obrigatoriamente a opção **Include all branches**
> antes de selecionar **Create repository**. Sem ela, os checkpoints da aula não serão
> copiados e você não conseguirá acompanhar o walkthrough a partir dos estados preparados.

> [!WARNING]
> Depois da cópia, você continuará vendo inicialmente esta página. Aguarde cerca de
> 20 segundos, atualize-a e abra a issue indicada no novo README.

## Ambiente inicial

O checkpoint `checkpoint/00-inicio` contém somente:

- um Codespace com .NET 10 e as extensões necessárias;
- o diretório `src` vazio.

A solução e os demais artefatos serão criados durante a aula.
