# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Pesquisa de material** 	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|	Requisito Associado 	| RF-001 - A aplicação deve possibilitar um usuário, cadastrado ou não, possa realizar pesquisa de material para estudo. |
| Objetivo do Teste 	| Verificar se o usuário consegue pesquisar o material. |
| Passos 	| - Clicar na barra de pesquisa  <br> - Informar o nome do material a ser buscado <br> - Clicar em "Buscar" |
|Critério de Êxito | - A pesquisa foi bem sucedida. |
|  	|  	|

| **Caso de Teste** 	| **CT-02 – Filtro de pesquisa** 	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|	Requisito Associado 	| RF-002 - A aplicação deve oferecer uma funcionalidade de filtro de pesquisa do material de forma especifica para usuários cadastrado ou não. |
| Objetivo do Teste 	| Verificar se o usuário consegue filtrar o material desejado. |
| Passos 	| - Clicar na barra de filtros  <br> - Informar a categoria desejada <br> - Clicar em "Buscar" |
|Critério de Êxito | - A pesquisa conseguiu filtrar os resultados. |
|  	|  	|

| **Caso de Teste** 	| **CT-03 – Efetuar login**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-003	- A aplicação deve permitir que o usuário possa gerenciar seus dados. Para realizar o cadastro o usuário deverá fornecer pelo menos os seguintes dados: nome, sexo, CPF, data de nascimento, formação academica, e-mail e senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue gerenciar seus dados. |
| Passos 	| - Clicar em "Informações pessoais" <br> - Clicar em alterar informações <br> - Preencher os campos obrigatórios (nome, sexo, CPF, data de nascimento, formação academica, e-mail e senha.) <br> - Clicar em "Salvar alterações" |
|Critério de Êxito | - As alterações foram realizadas com sucesso. |
|  	|  	|

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
