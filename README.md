# Identificador_Bandeira_CartaoCredito💳

# Projeto de Bootcamp da Dio

## Sobre o projeto

Este projeto demonstra o desenvolvimento de uma aplicação simples capaz de identificar a bandeira de um cartão de crédito a partir do seu número.

A proposta é utilizar lógica de programação e padrões dos números iniciais dos cartões para reconhecer bandeiras como Visa, MasterCard e American Express.

O projeto também demonstra o uso do **GitHub Copilot** como assistente de codificação, auxiliando na geração de código, sugestões de implementação, refatoração e produtividade.

## Objetivos

- Identificar a bandeira de um cartão a partir do número informado.
- Praticar lógica de programação em C#/.NET.
- Trabalhar com strings, condicionais e expressões regulares (Regex).
- Utilizar o GitHub Copilot como ferramenta de apoio ao desenvolvimento.
- Documentar uma solução simples e didática.

## Tecnologias

- C#
- .NET
- GitHub
- GitHub Copilot
- Regex

## Como funciona

A aplicação recebe o número do cartão, remove caracteres de formatação quando necessário e analisa os primeiros dígitos para verificar se eles correspondem aos padrões conhecidos das bandeiras.

Exemplos de padrões:

| Bandeira | Padrão inicial comum |
|---|---|
| Visa | 4 |
| MasterCard | 51–55 e determinados intervalos de 2221–2720 |
| American Express | 34 ou 37 |

Esses padrões servem para **identificação da bandeira**. Eles não comprovam que o cartão existe, está ativo ou pode realizar uma compra.

## Fluxo da aplicação

1. Usuário informa o número do cartão.
2. A aplicação normaliza o valor informado.
3. Os primeiros dígitos são analisados.
4. Os padrões são comparados.
5. A aplicação informa a bandeira identificada ou informa que não reconheceu o padrão.

## GitHub Copilot

O GitHub Copilot pode ser utilizado durante o desenvolvimento para sugerir estruturas de código, métodos, expressões regulares e melhorias na implementação.

A utilização da IA não substitui a compreensão do código. O desenvolvedor deve revisar, testar e validar as sugestões antes de utilizá-las.

## Exemplo de resultado

```text
Digite o número do cartão:
4111 1111 1111 1111

Bandeira identificada: Visa
```

## Observação de segurança

Este projeto possui finalidade **educacional**. Não utilize números reais de cartões, dados pessoais ou informações financeiras reais nos testes ou no código-fonte.

## Estrutura sugerida

```text
/
├── README.md
├── Program.cs
├── Models/
│   └── ...
└── ...
```

## Conclusão

O projeto apresenta uma aplicação prática e simples para estudar identificação de bandeiras de cartões, ao mesmo tempo em que demonstra como ferramentas de inteligência artificial, como o GitHub Copilot, podem apoiar o processo de desenvolvimento de software.



