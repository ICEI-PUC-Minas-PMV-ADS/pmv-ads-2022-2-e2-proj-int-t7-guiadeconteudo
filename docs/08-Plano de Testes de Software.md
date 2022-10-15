# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>


 
| **Caso de Teste** 	| **CT-01 – Pesquisa de material** 	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|	Requisito Associado 	| RF-001 - A aplicação deve possibilitar um usuário, cadastrado ou não, possa realizar pesquisa de material para estudo. |
| Objetivo do Teste 	| Verificar se o usuário consegue pesquisar o material. |
| Passos 	| - Clicar na barra de pesquisa  <br> - Informar o nome do material a ser buscado <br> - Clicar em "Buscar" |
|Critério de Êxito | - A pesquisa foi bem sucedida. |


| **Caso de Teste** 	| **CT-02 – Filtro de pesquisa** 	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|	Requisito Associado 	| RF-002 - A aplicação deve oferecer uma funcionalidade de filtro de pesquisa do material de forma especifica para usuários cadastrado ou não. |
| Objetivo do Teste 	| Verificar se o usuário consegue filtrar o material desejado. |
| Passos 	| - Clicar na barra de filtros  <br> - Informar a categoria desejada <br> - Clicar em "Buscar" |
|Critério de Êxito | - A pesquisa conseguiu filtrar os resultados. |


| **Caso de Teste** 	| **CT-03 – Gerenciamento de dados do usuário**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-003	- A aplicação deve permitir que o usuário possa gerenciar seus dados. Para realizar o cadastro o usuário deverá fornecer pelo menos os seguintes dados: nome, sexo, CPF, data de nascimento, formação academica, e-mail e senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue gerenciar seus dados. |
| Passos 	| - Clicar em "Informações pessoais" <br> - Clicar em alterar informações <br> - Preencher os campos obrigatórios (nome, sexo, CPF, data de nascimento, formação academica, e-mail e senha.) <br> - Clicar em "Salvar alterações" |
|Critério de Êxito | - As alterações foram realizadas com sucesso. |                                                                                             


| **Caso de Teste** 	| **CT-04 – Avaliação de material**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-004	-A aplicação deve possibilitar que um usuário cadastrado possa avaliar o material pesquisado. |
| Objetivo do Teste 	| Verificar se o usuário consegue avaliar o material. |
| Passos 	| - Clicar no material <br> - Clicar em "avaliar o material" <br> - Preencher os campos obrigatórios (comentário e avaliação) <br> - Clicar em "Enviar" |
|Critério de Êxito | - O usuário conseguiu avaliar o material. |                                                                                                    


| **Caso de Teste** 	| **CT-05 – Inclusão dos materiais**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-005	- A aplicação deve possibilitar que um usuário cadastrado possa incluir e GERENCIAR uma referência de material para consulta, enquanto o status de seu material ainda estiver pendente, contendo pelo menos os seguintes campos: Título do material, área do conhecimento, resumo, link de acesso. |
| Objetivo do Teste 	| Verificar se o usuário cadastrado consegue incluir o material enquanto seu status ainda está pendente. |
| Passos 	| - Clicar no material <br> - Verificar se está pendente <br> - Preencher os campos (Título do material, área do conhecimento, resumo, link de acesso) <br> - Clicar em "Enviar" |
|Critério de Êxito | - O usuário conseguiu incluir o material. |

| **Caso de Teste** 	| **CT-06 – Gerenciamento de materiais pendentes**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-005	- A aplicação deve possibilitar que um usuário cadastrado possa incluir e GERENCIAR uma referência de material para consulta, enquanto o status de seu material ainda estiver pendente, contendo pelo menos os seguintes campos: Título do material, área do conhecimento, resumo, link de acesso. |
| Objetivo do Teste 	| Verificar se o usuário cadastrado consegue gerenciar o material enquanto seu status ainda está pendente. |
| Passos 	| - Clicar no material <br> - Verificar se está pendente <br> - Alterar os campos (Título do material, área do conhecimento, resumo, link de acesso) <br> - Clicar em "Alterar" |
|Critério de Êxito | - O usuário conseguiu gerenciar o material. |



| **Caso de Teste** 	| **CT-07 – Materiais em análise**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-006	-A aplicação deverá permitir que o Administrador visualize todos os materiais submetidos para análise. |
| Objetivo do Teste 	| Verificar se o administrador consegue visualizar os materiais em análise. |
| Passos 	| - Ir até os materiais em análise <br> - A aplicação deve exibir a listagem de materiais para avaliação |
|Critério de Êxito | - O administrador conseguiu visualizar todos os materiais submetidos para análise. |


| **Caso de Teste** 	| **CT-08 – Avaliação de materiais como confiáveis**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-007	-A aplicação deve possibilitar que uma referência de material seja avaliado como confiável ou não confiável pelos administradores. |
| Objetivo do Teste 	| Verificar se o administrador consegue avaliar os materiais como confiáveis ou não confiáveis. |
| Passos 	| - Se for adm <br> - Selecionar um material <br> - Clicar em avaliar como administrador <br> - Definir material como confiável ou não confiável.|
|Critério de Êxito | - O administrador consegue avaliar material como confiável ou não confiável. |


| **Caso de Teste** 	| **CT-09 – Notificar autor**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-008	-A aplicação deve notificar o autor do conteúdo por e-mail sobre a aprovação/veto do seu conteúdo. |
| Objetivo do Teste 	| Verificar se o e-mail foi enviado com êxito. |
| Passos 	| - Clicar em "material aprovado" <br> - Verificar se a notificação foi enviada.|
|Critério de Êxito | - O e-mail foi enviado com sucesso. |


| **Caso de Teste** 	| **CT-10 – Duas etapas**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-009	-Todo material terá duas etapas: Pendente e confiável/não confiável. |
| Objetivo do Teste 	| Verificar se o material possui as duas etapas (Pendente e confiável/não confiável). |
| Passos 	| - Clicar no material <br> - Ver status do material <br> - Verificar se o material possui pelo menos uma das etapas.|
|Critério de Êxito | - O material possui uma das duas etapas. |

 
| **Caso de Teste** 	| **CT-11 – Materiais confiaveis**	|
|:---:	|:---:	|
|	Tipo de teste:	| Funcional |
|Requisito Associado | RF-010	-Somente materiais avaliados como confiável poderá ser exibido no campo de pesquisa. |
| Objetivo do Teste 	| Verificar se apenas materiais avaliados aparecem no campo de pesquisa. |
| Passos 	| - Clicar na barra de pesquisa <br> - Digitar o nome do material. <br> - Verificar se aparecem apenas materiais avaliados como confiáveis. |
|Critério de Êxito | - Apenas materiais confiáveis são exibidos. |


| **Caso de Teste** 	| **CT-12 – Recomendações da LGPD**	|
|:---:	|:---:	|
|	Tipo de teste:	| Não funcional |
|Requisito Associado | RNF-001	-A aplicação deve obedecer às recomendações da LGPD. |
| Objetivo do Teste 	| Verificar se aplicação se encaixa nas normas da LGPD. |
| Passos 	| - Verificar recomendações da LGPD. <br> - Alterar as partes da aplicação que não obedecem as normas. |
|Critério de Êxito | - A aplicação se encaixa nas recomendações. |


| **Caso de Teste** 	| **CT-13 – Compatibilidade com os navegadores**	|
|:---:	|:---:	|
|	Tipo de teste:	| Não funcional |
|Requisito Associado | RNF-002	-A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). |
| Objetivo do Teste 	| Verificar se aplicação é compatível com os nevegadores (Google Chrome, Firefox, Microsoft Edge). |
| Passos 	| - Verificar a aplicação se adequa aos principais navegadores do mercado.|
|Critério de Êxito | - A aplicação se encaixa nas recomendações. |


| **Caso de Teste** 	| **CT-14 – Responsividade**	|
|:---:	|:---:	|
|	Tipo de teste:	| Não funcional |
|Requisito Associado | RNF-004	-A aplicação deverá ser responsiva. |
| Objetivo do Teste 	| Verificar se aplicação é responsiva. |
| Passos 	| - Verificar a responsividade da aplicação.|
|Critério de Êxito | - A aplicação é responsiva. |


| **Caso de Teste** 	| **CT-15 – Submissão de materiais**	|
|:---:	|:---:	|
|	Tipo de teste:	| Não funcional |
|Requisito Associado | RNF-005	-A aplicação deverá permitir que apenas usuários cadastrados postem e gerenciem seus materiais postados.	 |
| Objetivo do Teste 	| Verificar se apenas usuários cadastrados postam e gerenciam seus materiais. |
| Passos 	| - Clicar em material <br> - Verificar se consegue postar e gerenciar materiais.|
|Critério de Êxito | - O usuário consegue postar e gerenciar. |


| **Caso de Teste** 	| **CT-16 – API de envio de e-mail**	|
|:---:	|:---:	|
|	Tipo de teste:	| Não funcional |
|Requisito Associado | RNF-006	-Deverá ser usado uma API para que a aplicação notifique por e-mail os usuários sobre o resultado do material submetido.	 |
| Objetivo do Teste 	| Verificar se API notifica os usuários sobre o resultado do material submetido. |
| Passos 	| - - Clicar em "material aprovado" <br> - Verificar se a notificação foi enviada.|
|Critério de Êxito | - A API notificou com sucesso. |


