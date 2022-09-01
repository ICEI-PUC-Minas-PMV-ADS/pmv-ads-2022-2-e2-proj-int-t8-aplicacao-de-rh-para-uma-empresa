# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão, feito pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários
<p align = "center">Quadro 1 - Persona Helen Cerqueira</p>

## Personas
|    HELEN CERQUEIRA  |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![](https://user-images.githubusercontent.com/97108151/187811786-7e85686d-d941-4ec0-b6eb-522b555d6944.jpg)|**Idade:** 34 anos - **Ocupação:** Recrutamento e seleção, Formada em gestão e recursos humanos Helen é responsável por buscar os profissionais mais alinhados às necessidades da empresa |**Aplicativos:** Instagram,Facebook,Whatsapp.
|**Motivações:** Helen gosta de sua profissão e espera contratar pessoas que sejam adequadas para cada tipo de vaga, por isso, o mesmo está sempre em busca de mais conhecimento sobre comportamentos de outras pessoas |**Frustrações:** Por trabalhar com o recrutamento de pessoas, Helen se sente desmotivado com plataformas que dificultam seu contato com os profissionais.|**Hobbies:** Helen, está sempre em busca de  aperfeiçoamento para saber lidar com pessoas, em seu tempo livre, busca leituras e aulas de comportamento humano |
<p align = "center">Fonte: Elaborado pelos autores</p>

<br>
<p align = "center">Quadro 2  - Persona Sidney Gomes</p>

|    SIDNEY GOMES |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![jonas-kakaroto-Fs8ZFfVh-cg-unsplash](https://user-images.githubusercontent.com/97108151/187814920-e1a58b32-a081-4512-9396-93a90cf4c6b0.jpg)|**Idade:** 40 anos -**Ocupação:** Auxiliar de logística. Responsável  por representar a empresa na rua, dirigir caminhões e outros veículos para realizar serviços de logística como  busca de mercadoria nos fornecedores e entrega de mercadorias para os clientes, Sempre cumprindo com a rota do dia |**Aplicativos:** Waze,TMS,Whatsapp.
|**Motivações:** Sidney sempre gostou de Trabalhar duro, auxiliar no crescimento da empresa, coordenar a execução dos processos.|**Frustrações:** Sidney acredita que não tem o reconhecimento que merecia dentro da empresa|**Hobbies:** Sidney adora ir em eventos automobilístico| 
<p align = "center">Fonte: Elaborado pelos autores</p>

<br>



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

<p align = "center">Quadro .. - Requisitos funcionais</p>
<div align = "center">

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Na página principal do site deve exigir login e senha para que o usuário tenha acesso ao sistema. | ALTA | 
|RF-002| O site deve deve ter página de registro de pontos, onde usuário poderá registrar o início e fim da jornada de trabalho| ALTA |
|RF-003| O site deve permitir ao usuário visualizar o valor a ser recebido pela soma das horas trabalhadas| ALTA |
|RF-004| O site deve oferecer uma página informando sobre os benefícios que usuário tenha direito| BAIXA |
 </div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Requisitos não Funcionais
<p align = "center">Quadro 00 - Requisitos não funcionais</p>

<div align = "center">

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku); | ALTA | 
|RNF-002| O site deverá ser responsivo permitindo a visualização em um celular de forma adequada |  ALTA | 
|RNF-003| O site deve ter bom nível de contraste entre os elementos da tela em conformidade |  MÉDIA | 
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  BAIXA | 
 </div>

<p align = "center">Fonte: Elaborado pelos autores</p>


## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir: 
 <p align = "center">Quadro  - Restrições</p>

<div align = "center">


|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 11/12/2022 |
|RE-02| Registro de horas dos funcionários deve estar conforme horário de brasília |
|RE-03| Valores referentes a pagamento devem estar em moeda local R$ (real) |
|RE-04| Testes de funcionalidade da aplicação devem ser executados somente no navegador Google Chrome. |
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>




## Diagrama de Casos de Uso

O diagrama contempla as principais ligações previstas entre casos de uso e atores e permite detalhar os Requisitos Funcionais identificados na etapa de licitação. Lembrando que  não se utiliza diagramas de caso de uso para requisitos não-funcionais. Como atores é importante a identificação dos grupos de todos os envolvidos que interagem com o sistema, principalmente outros sistemas ou sensores. Eles são representados graficamente por bonecos-palito e são nomeados pelos papéis nas interações nas quais estão envolvidos (ex. Cliente, Administrador). Lembre-se de que o próprio sistema não pode ser ator do diagrama que o modela. Em relação aos casos de uso, eles devem representar as interações ou transações dos atores com o sistema. Cada tipo possível é representada por uma elipse nomeada e os relacionamentos são indicados por linhas que podem ter setas nos casos em que se indica a origem da interação. Os nomes dos casos de uso representam verbos no infinitivo associados aos objetos com os quais se relacionam os verbos (ex. Cadastrar usuário, Visualizar relatório). Os tipos de relacionamentos mais comuns são associações entre atores e casos de uso, generalizações entre atores e entre casos de uso, inclusões e extensão entre casos de uso.
 
 <p align = "center">Figura 1 - Diagrama de Casos de Uso</p>


 ![](https://user-images.githubusercontent.com/97108151/187820109-e718ff5f-cd54-4a39-b736-c500896ba0e7.jpg )
 
  <p align = "center">Fonte: Elaborado pelos autores</p>

<br>

