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
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site URL: http://localhost:5500/index.html<br> - Clicar em "Cadastre-se" <br> - Preencher os campos obrigatórios (nome, e-mail, senha, data de nascimento) <br> - <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site URL: http://localhost:5500/index.html<br> - Clicar no botão "Login" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Responsividade	|
|Requisito Associado | RF-00Z	- A aplicação deve deve responder de modo responsivo ao ser acessada por dispositivos móveis. |
| Objetivo do Teste 	| Verificar a responsividade da aplicação. |
| Passos 	| - Acessar o navegador por um dispositivo móvel <br> - Informar o endereço do site URL: http://localhost:5500/index.html<br> - navegar pelos paginas do portal|
|Critério de Êxito | - a aplicação respondeu responsivamente com  sucesso. |


