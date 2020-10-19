
# Devtops
Grupo de desenvolvedores Gama Academy .NET Pleno. formado por: Vagner Santos e Bruno Melo

DETALHAMENTO DO PROCESSSO SCRUM:

Somos 2 desenvolvedores fazendo papeis de P.O e Scrum Team simultâneamente devido ao curto prazo e tamanho reduzido da equipe alternaremos entre os papéis funciona mais de uma forma colaborativa vamos nos utilizar das Cerimônias: (Product Backlog, Sprint Backlog, Reunião diária e Sprint Review Meeting) pois com sprint de uma semana podemos administrar ter uma visão do todo e melhorar pra sprint final que será a segunda semana.

ESCOLHA DA EQUIPE:

Quanto ao critério de escolha dos membros da equipe, por se tratar de um tempo curto, não tivemos como conhecer a todos de maneira intensa. Eu, Bruno Melo de Souza, levantei o questionamento no grupo do whatsapp se alguém gostaria de formar equipe, o Vagner Santos se prontificou e juntos formamos a equipe no qual nomeamos "Devtops". Apesar do pouco tempo em equipe, podemos destacar como fortaleza em ambos os membros, a vontade de aprender, paciência e persistência além das caracteristicas e experiências profissionais FrontEnd. Como ponto de melhoria podemos citar a falta de experiência em desenvolvimento BackEnd que esta sendo sanada com a imersão oferecida pela Gama Academy e Avanade com monitoria e mentoria do Professor Fernando Mendes.

DIFICULDADES ENCONTRADAS: 

Talvez a maior dificuldade do trabalho em equipe tenha sido a pouca experiência com a linguagem. Ambos não conheciam suas particularidades muito bem, e para desenvolver os itens do projeto, tínhamos que muitas vezes rever os vídeos das aulas e tentar replicar para nossa realidade. Esse fato fez com que infelizmente não pudéssemos entregar toda a demanda, faltando ainda algumas funcionalidades para implantar. Outra dificuldade foi com relação ao github. Subimos uma primeira versão da estrutura toda montada como aprendemos a fazer, mas depois de algumas modificações, houveram algumas dificuldades para clonagem de repositório e commits, fato que nos fez perder tempo.
Acreditamos que como experiência positiva, tivemos um bom relacionamento onde um sempre se prontificava a ajudar o outro quando podia nas tarefas. Acreditamos também que essa experiência nos fez adquirir conhecimento e nos mostrou que devemos sempre nos aperfeiçoar cada vez mais.

APRENDIZADOS / DESNVOLVIMENTOS:

A infra estrutura do projeto foi montada com base no que aprendemos com o professor Fernando Mendes, onde procuramos respeitar as camadas da aplicação, seguindo o modelo:

0 - CONSOLE

1 - APPLICATION

2 - DOMAIN

3 - INFRASTRUCTURE

4 – TESTS

Nesse modelo descrito, tentamos seguir a hierarquia: camada de API chamado a Application, camada de Domain não chamando nínguem, camada de Infrastructure chamando Domain, camada de Repository apenas com responsabilidade de realizar operações referentes a banco e camada de Aplication orquestrando dados. No que diz respeito a testes, foi instalado o pacote do Nuget denominado Xunit e foi criada uma classe de teste para testes unitários de métodos conforme orientação do professor. 

azure devops:

master / main:

https://dev.azure.com/brunomelodesouza/EmissoraDevops/_git/Devtops.git



# DevTopFront

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 10.1.6.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).
