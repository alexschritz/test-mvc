# Teste de ASP.NET MVC
Este é o teste de ASP.NET MVC para os candidatos qualificados para trabalharem com a Weepa. Leia todas as intruções com 
atenção antes de iniciar o projeto. É esperado que você gaste de 1 a 3 horas para completar a solução.

## Objetivo
Este teste tem o objetivo de avaliar suas habilidades de programação em C# e ASP.NET MVC, seguir melhores práticas como 
*Clean Code* e *Convention over Configuration*, além da sua habilidade em tirar vantagem do *Scaffold* do Visual Studio 2015,
mais *Migrations* e *Code First* com *Entity Framework*. Conhecimentos básicos de OOP (*Object-Oriented Programming*) vão te 
ajudar terminar mais rapidamente.

## O Projeto
Primeiro, você vai desenvolver um projeto simples Web API REST para um tipo de Mídia Social, fornecendo os seguintes serviços:

* Registro de Usuário com nome de usuário e senha;
* Criar Posts para Usuários logados com texto e upload de imagem;
* Mensagens de uma Pessoa para outra;
* Listagem de todos os Posts de uma determinada Pessoa;
* Listagem de todas as Mensagens trocadas entre duas Pessoas, ordenadas da última para a primeira.

Nós também precisamos de uma interface de Administração para listar e eventualmente bloquear conteúdos ofensivos e seu autor.
* Use as *views* Bootstrap padrões;
* Use *Accounts* e *Roles* separadas para o Admin e usuários normais;

## Requisitos
1. Uma *Solution* completa com o Visual Studio 2015;
2. *Code First* e *Migrations* habilitada, mais algum dado automático de teste;
3. Tanto a API como a interface de Administração estarão sob Login e controle de acesso.

## O início
Neste repositório, você vai encontrar algumas classes *Model* para começar seu projeto. Essas classes não estão completas e 
precisam de um ajuste fino para funcionarem corretamente com o *Scaffold* do Visual Studio 2015:
* ModelBase.cs
* Person.cs
* Post.cs
* Message.cs

## A solução
A *Solution* deve ter dois *Projects* separados, um para o Admin e outra para a API pública, ambos compartilhando o mesmo 
banco de dados.

Não é necessário um projeto de *Unity Test*, mas você precisa garantir que sua solução funcione de forma apropriada.
