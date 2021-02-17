# Series Register, Simple App
---
### >> [_Content in Portuguese____](#app-simples-de-cadastro-de-séries)

#### For Portuguese speakers ^^^^
---
## What is this Project?

This project is part of Digital Innovation One's (DIO) MRV's Bootcamp, for learn .NET, in which I'm studying.
The project has as objective to implement the basic knowledges of .NET, C# and OOP.

## Project's objective:
1. Serial CRUD implementation;
2. Uses of Abstract Classes;

## What does it do?
1. The App run in Terminal mode and has as objective to save in the memory (RAM) a list of series that is seted by the user, creating a simple "Data Bank" that is temporary and ends when it is closed.
2. The App starts with a menu that have a range of options for execute the actions, the menu runs in loop and is finished when the `userOption` is equal to "X".
   1. Among the choices are: List, Insert, Update, Delet, Show Infomations, Clear Chat and Finish Process.
   2. Each of this options has it own settings, and each Serie `Series()` has as your content: Id (int), Genre (Genre), Title (string), Year (int), Description (string) and Deleted (bool);
   3. The option Delete doesn't erase the data from the memory, because the application's own structure, then, it hides the Serie by means of parameter `Deleted` as being false. 

<br><br><br>

---

# App simples de cadastro de séries



## O que é esse projeto?

Esse projeto faz parte do Bootcamp MRV da Digital Innovation One, de .NET, no qual estou cursando.
O projeto tem como objetivo implementar os conhecimentos básicos de .NET, C# e POO.

## Objetivos do projeto:
1. Implementação de CRUD em série;
2. Utilização de Classes Abstratas;

## O que isso faz?
1. O Aplicativo funciona por meio de um terminal e ele tem como objetivo salvar na memória (RAM) uma lista de séries determinada pelo usuário, criando um "Banco de Dados" simples e temporário que termina ao fechá-lo.
2. Inicia-se com um menu onde se tem uma gama de opções para poder exercitar as ações, o menu funciona em loop e só é finalizado quando a escolha do usuário (`userOption`) for igual a "X".
   1. Dentre as escolhas estão: Listar, Inserir, Atualizar, Deletar, Mostrar Informações, Limpar Chat e Finalizar Processo.
   2. Cada uma dessas opções tem suas devidas configurações e cada Série tem como seu conteúdo: Id (int), Gênero (Genre), Título (string), Ano (int), Descrição (string) e Apagado (bool);
   3. A opção de Deletar não apaga realmente o dado da memória por questões estruturais do próprio aplicativo, por isso, ele oculta-o por meio do parâmetro `Deleted` como sendo falso.




