# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Cenários de testes: 

Plano de Teste de Software:

• A aplicação deve possuir um tópico de dicas como seguir uma trajetória correta para obter conhecimento financeiro;

• A aplicação deve possuir layouts pré-definidos;

• A aplicação deve ter página de fácil navegação para facilitar edição de dados inseridos, caso seja necessário.

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site URL: [http://localhost:44328]<br> - Clicar em "Cadastre-se" <br> - Preencher os campos obrigatórios (nome, senha, perfil) <br> - <br> - Clicar em "Salvar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-001	- A aplicação deve possuir opção de fazer login, sendo o login o nome. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site URL: [http://localhost:44328]<br> - Clicar no botão "Login" <br> - Preencher o campo nome <br> - Preencher o campo da senha <br> - Clicar em "Acessar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Cadastrar Despesa** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-006 - Ferramentas de Acompanhamento Financeiro: Oferecer funcionalidades para os usuários acompanharem suas despesas, estabelecerem metas de economia e monitorarem seu progresso. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar uma despesa na aplicação. |
| Passos 	| - Realizar login na aplicação conforme CT-02 <br> - Navegar até a seção de cadastro de despesas <br> - Clicar em "Adicionar Despesa" <br> - Preencher os campos obrigatórios (conta, instituição, descriçao) <br> - Clicar em "Adicionar" |
|Critério de Êxito | - A despesa foi cadastrada com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Visualizar Lista de Despesas**	|
|Requisito Associado | RF-006	- Ferramentas de Acompanhamento Financeiro: Oferecer funcionalidades para os usuários acompanharem suas despesas, estabelecerem metas de economia e monitorarem seu progresso. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar o relatório de despesas na aplicação. |
| Passos 	| - Realizar login na aplicação conforme CT-02 <br> - Navegar até a seção de lista de despesas. |
|Critério de Êxito | - O listagem de despesas foi exibido corretamente, incluindo informações precisas sobre o total gasto, categorias de despesas e datas. |
|  	|  	|


