<h1 align="center">🐱 Duckling Aleatory Cats Backend 🐱</h1>

<div align="center">
	<a href="https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley">
	<img height = "250em" src = "https://github.com/FernandoSchett/duckling-days-backend/assets/80331486/6417c9a8-0a67-4f24-9e3f-8a2df9ca3515" />
    </a>
</div>

## Developed by 💻:

- [Fernando Schettini](https://github.com/FernandoSchett)
- [Antonio Horácio Magalhães](https://github.com/AntonioHoracio77)
- [Orlando Mota Pires](https://github.com/orlandomotapires)
- [Enzo Gebauer](https://github.com/enzogebauer)

## Special thanks to 🥰:

- [Edson Mota](https://github.com/edsonmottac) - Our supervising professor, your experience and knowledge have been invaluable to our progress.

## About 🤔:

This repository contains the backend made for [Duckling Aleatory Cats FrontEnd](https://github.com/enzogebauer/duckling_aleatory_cats_frontend) application, its cointains all services, business logic and database structure for making that presentation layer work. It is responsible for log in and sign in feature, storing all images from the user and intermediates all images from NASA API and the FrontEnd.  We also used [Cat API](https://thecatapi.com), to get access to aleatory cats.

## Resourses 🧑‍🔬:

- Save your favorite cats in database, by storing images ids, description and title.
- Sign in and log in your user. 
- Pull images from [Cat API](https://thecatapi.com).

## Routes 🛣️:

Every Route from the API can be found in [swagger]().

- **POST** - /PostCat;
- **GET** - /GetRandCat;
- **GET** - /GetCatsFromUser/{id};
- **POST** - /PostUser;
- **POST** - /CheckLogin;

## Dependencies 🚚:

In summary, heres what you're gonna need in order to run the project:

- ```Swashbuckle.AspCore 6.2.3```.
- ```entityframeworkcore 7.0.5```.
- ```entityframeworkcore.SqlServer 7.0.5```.
- ```entityframeworkcore.Tools 7.0.5```.

For installing dependencies more quickly, you can use [Visual Studio](https://visualstudio.microsoft.com/pt-br/) to download automatically your dependencies.

## How to run it 🏃:

First, clone this repository. Then, Open the project with [Visual Studio](https://visualstudio.microsoft.com/pt-br/), change at "duckling_aleatory_cats.DAL" layer ```DbSet.cs``` class path to your own ```Database.mdf``` and execute duckling aleatory cats services layer.

## How to install 🔬:

## UML‍ 💬:

Heres the UML that represents how the application works with their classes.

<div align="center">
	<a href="">
	<img height = "250em" src = "https://github.com/FernandoSchett/github_readme_template/assets/80331486/4e4d24ee-efce-41d9-873b-3ececaf1cdd5" />
    </a>
</div>

<h4 align="center">Figure 1 - Duckling Aleatory Cats Backend UML.</h4>


## Logic Model 🧮:

Here's the logic model that represents how the code works with their classes.

<div align="center">
	<a href="">
	<img height = "250em" src = "https://github.com/FernandoSchett/github_readme_template/assets/80331486/4e4d24ee-efce-41d9-873b-3ececaf1cdd5" />
    </a>
</div>
<h4 align="center">Figure 2 - Logic Model.</h4>

## Database 🗃️:

<div align="center">
	<a href="">
	<img height = "250em" src = "https://github.com/FernandoSchett/duckling-days-backend/assets/80331486/30bf42b6-1a45-4d03-83b7-07f30b4e9578" />
    </a>
</div>

<h4 align="center">Figure 3 - Relational Model Database.</h4>

## Development Process ⚙️:

Developers used [Trello]() to get things organized, each one using their own branch to code, using names to identify the commit type then merginng the features into develop branch. After testing, the group update the main branch. This application was developed in 08/06/2023 until 12/06/2023.

### Tools Used 🛠️: 

- [Visual Studio](https://visualstudio.microsoft.com/pt-br/).
- [Miro](miro.com).

## How to contribute 🫂:

Feel free to create a new branch, fork the project or contact one of us to develop at Duckling Aleatory Days BackEnd.

## Licence 📜:

[Apache V2](https://choosealicense.com/licenses/apache-2.0/)
