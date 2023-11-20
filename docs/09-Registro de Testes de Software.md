# Registro de Testes de Software

Foram realizados os testes de acordo com as tabelas mostradas no ítem 08 (Plano de Testes de Software), testes de funcionalidades e de controle de acesso, podendo ser resumidos na tabela abaixo:

| Código do Teste | Descrição | Status | Dispositivo |
|---------------------|-----------------------|-------------|-------------|
| CT-01 | Cadastrar perfil | ✅ Passou | Chrome |
| CT-02 | Efetuar login | ✅ Passou | Chrome |
| CT-03 | Cadastrar Despesa | ✅ Passou | Chrome |
| CT-04 | Visualizar Lista de Despesas | ✅ Passou | Chrome |

### CT - 01: Cadastrar perfil

#### Descrição do Teste:
1. Acessar o navegador.
2. Informar o endereço do site URL: [http://localhost:44328].
3. Clicar em "Cadastre-se".
4. Preencher os campos obrigatórios (nome, e-mail, senha, data de nascimento).
5. Clicar em "Cadastrar".

#### Evidência:
![CT01](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t9-pmv-ads-2023-2-e2-portal-financeiro/assets/111186037/8880ecd3-ef33-4b7c-8eb2-24cd4776d8ba)

#### Estrutura de Dados:
 <img src="img/Usuarios.jpeg">

#### Resultado:
Foi possível informar os dados corretamente.

### CT - 02: Efetuar login

#### Descrição do Teste:
1. Acessar o navegador.
2. Informar o endereço do site URL: [http://localhost:44328]).
3. Clicar no botão "Login".
4. Preencher o campo nome.
5. Preencher o campo da senha.
6. Clicar em "Acessar".

#### Evidência:
![CT02](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t9-pmv-ads-2023-2-e2-portal-financeiro/assets/111186037/dd7caeb6-1cd2-4dc6-9c2e-23ab65f0451c)

#### Estrutura de Dados:
 <img src="img/Usuarios controler.jpeg">
 
#### Resultado:
Os dados inseridos são aceitos para fazer o login com sucesso.

### CT - 03: Cadastrar Despesa

#### Descrição do Teste:
1. Realizar login na aplicação conforme CT-02.
2. Navegar até a seção de cadastro de despesas.
3. Clicar em "Adicionar Despesa".
4. Preencher os campos obrigatórios (conta, instituição, descrição).
5. Clicar em "Adicionar".

#### Evidência:
![CT04](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t9-pmv-ads-2023-2-e2-portal-financeiro/assets/111186037/dba9f87e-0e5d-4e10-86ea-85b38dbe88a4)

#### Estrutura de Dados:
 <img src="img/Despesas.jpeg">

#### Resultado:
A tabela aceita e demonstra corretamente os valores fornecidos nos campos;

### CT - 04: Visualizar Lista de Despesas

#### Descrição do Teste:
1. Realizar login na aplicação conforme CT-02.
2. Navegar até a seção de Lista de despesas.

#### Evidência:
![CT05](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t9-pmv-ads-2023-2-e2-portal-financeiro/assets/111186037/0d46e7f6-284f-4a9f-a000-4a7b70237b5e)

#### Estrutura de Dados:
 <img src="img/Despesa controler.jpeg">
 
#### Resultado:
A tabela cumpre o papel proposto de dar resultado das despesas;
A tabela mostra a mensagem correta de acordo com a porcentagem da despesas pré definido;
