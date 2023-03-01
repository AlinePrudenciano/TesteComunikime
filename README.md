# ComunikimeTest
api para compras e gerenciamento de estoque

projeto desenvolvido em .net 6.0, logo é necessário que o mesmo esteja instalado

banco de dados 'inMemory' com EntityFramework 6

para executar o projeto web basta abrir o visual studio 2022, definir como padrão o projeto ComunikimeTest.Api e executar o projeto ou o vscode e rodar no terminal dotnet run --project src/ComunikimeTest.Api/ComunikimeTest.Api.csproj

a url de execução deve ser http://localhost:5001/

para visualizar a api, favor usar http://localhost:5001/swagger

Enfrentei alguns problemas no frontend MVC, encontrei alguns problemas e tive dificuldade em resolver em tempo hábil.
Em compensação o Backend está respeitando tanto o SOLID quanto o DDD.

## Passo a Passo
* Criar um usuário admin e não admin (POST /user)
 - Usuario admin: Server response Code 200
	Exemplo:
~~~json
	{
	  "id": 1,
	  "name": "usuario1",
	  "email": "usuario1@gmail.com",
	  "phone": "11999999999",
	  "isAdmin": true
	}
~~~
 - Usuário não admin: Server response Code 200
	Exemplo:
~~~json
	{
	  "id": 2,
	  "name": "usuario2",
	  "email": "usuario2@gmail.com",
	  "phone": "11999999999",
	  "isAdmin": false
	}
~~~

* Criar produtos (POST /product)
 - Usuario admin: Server response Code 200
	Exemplo utilizando o UserId = 1
~~~json
	{
 	 "id": 1,
  	"name": "produto1",
  	"value": 1.5
	}
~~~

 - Usuário não admin: Server response Code 500
	Exemplo utilizando o UserId = 2
~~~json
	{
 	 "id": 2,
  	"name": "produto2",
  	"value": 0.5
	}
~~~

* Adicionar estoque nos produtos (POST /stock)
 - Usuario admin: Server response Code 200
	Exemplo utilizando UserId = 1
~~~json
	{
	  "id": 1,
	  "productId": 1,
	  "amount": 150
	}
~~~

 - Usuário não admin: Server response Code 500
	Exemplo utilizando UserId = 2
~~~json
	{
	  "id": 2,
	  "productId": 2,
	    "amount": 10
	}
~~~

* Criar um order vai fazer o pedido (POST /order) Server response Code 200
	Exemplo:
~~~json
	{
 	 "id": 1,
	  "userId": 2,
  	  "items": [
	    {
      	"id": 1,
	      "productId": 1,
            "amount": 5
          }
        ],
	  "value": 7.5
	}
~~~
* Validar se alterou o estoque dos produtos. (GET /stock/{productId})
 
