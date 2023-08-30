## <a name="especificacaoprojeto">Especificação do Projeto</a>

&nbsp;&nbsp; Foram definidos pela equipe os pontos mais relevantes a serem abordados neste projeto, deste modo, houve uma entrevista com voluntários para coletar informações sobre suas respectivas situações financeiras. Das informações coletadas, foram criadas personas e histórias de usuários, conforme abaixo descritas.  

## Personas 


##
**<h3 align="center" >João Alves de Almeida</h3 >**
 
 <img align="left" width="180px" height="190px" style="margin:-5px 1em 0 auto" src="img/persona1.jpg"> **Biografia**: João é um estudante universitário de 22 anos, vivendo em um alojamento estudantil.

**Metas**:
Economizar para a formatura, evitar dívidas estudantis excessivas.

**Motivação**:
Busca adquirir habilidades financeiras desde cedo, sonha em iniciar uma carreira sem dívidas.

**Frustrações**:
Dificuldade em equilibrar gastos com entretenimento e necessidades básicas.

**Bloqueadores**:
Falta de renda consistente, pressão social para gastar.
 <br /> 
##


**<h3 align="center" >Ana Paula de Souza</h3 >**
 
 <img align="left" width="180px" height="190px" style="margin:-5px 1em 0 auto" src="img/persona2.jpg"> **Biografia**: Ana Paula é uma jovem profissional de 28 anos, recém-promovida em seu trabalho.

**Metas**:
Economizar para uma viagem ao exterior, começar a investir.

**Motivação**:
Alcançar independência financeira, aproveitar a vida agora e no futuro.

**Frustrações**:
Despesas inesperadas afetando seu orçamento, dificuldade em entender o mercado de investimentos.

**Bloqueadores**:
Falta de conhecimento em investimentos, instabilidade de renda.
 <br /> 
##


**<h3 align="center" >Marcos Alencar</h3 >**
 
 <img align="left" width="180px" height="190px" style="margin:-5px 1em 0 auto" src="img/persona3.jpg"> **Biografia**: Marcos é um pai solteiro de 35 anos, com dois filhos adolescentes.

**Metas**:
Economizar para a educação dos filhos, criar um fundo de aposentadoria.

**Motivação**:
Proporcionar o melhor para seus filhos, assegurar um futuro confortável.

**Frustrações**:
Despesas imprevistas com educação e saúde, dificuldade em equilibrar trabalho e vida familiar.

**Bloqueadores**:
 Falta de tempo para buscar oportunidades de renda extra, falta de suporte familiar.
 <br /> 
 ##


 **<h3 align="center" >Carla Moreira</h3 >**
 
 <img align="left" width="180px" height="190px" style="margin:-5px 1em 0 auto" src="img/persona4.jpg"> **Biografia**: Carla, 40 anos, decidiu iniciar seu próprio negócio no setor de alimentos.

**Metas**:
Fazer crescer o negócio, gerenciar dívidas relacionadas ao empreendimento.

**Motivação**:
Realizar seu sonho empreendedor, alcançar estabilidade financeira por meio do negócio.

**Frustrações**:
Incertezas financeiras no início do negócio, dificuldade em equilibrar investimento pessoal e comercial.

**Bloqueadores**:
Desafios de fluxo de caixa, despesas iniciais elevadas.
 <br /> 
 ##


 **<h3 align="center" >Sofia de Azevedo</h3 >**
 
 <img align="left" width="180px" height="190px" style="margin:-5px 1em 0 auto" src="img/persona5.jpg"> **Biografia**: Sofia, 55 anos, está prestes a se aposentar após uma carreira de sucesso.

**Metas**:
Garantir um fluxo de renda sustentável na aposentadoria, viajar e aproveitar a vida.

**Motivação**:
Desfrutar da aposentadoria sem se preocupar com finanças, explorar novas paixões.

**Frustrações**:
Incertezas sobre quanto dinheiro é suficiente para a aposentadoria, preocupações com despesas médicas.

**Bloqueadores**:
Falta de conhecimento em como criar uma estratégia de retirada de fundos, resistência a adotar tecnologias financeiras.
 <br /> 
	
## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
