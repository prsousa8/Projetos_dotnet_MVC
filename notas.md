#Instruções

##Preparar projeto e criar conexão com o Banco

1. Criar Projeto MVC no terminal: *dotnet new mvc --framework net6.0*

2. Instalar pacotes:
-  *dotnet add package Microsoft.EntityFrameworkCore.SqlServer  --version 6.0.5*
-  *dotnet add package Microsoft.EntityFrameworkCore.Design  --version 6.0.5*

3. Criar pasta **Context** e criar uma classe *AgendaContext* na pasta. Depois adicione o trecho de código 

~~~
 public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contato> Contatos{ get; set; }
    }
~~~

Importe a biblioteca: *using Microsoft.EntityFrameworkCore;*

Adicione *using Projetos_dotnet_MVC.Models;*

4. Crie a classe *Contato* na pasta **Models**

5. Adicione o trecho no json *appsettings.Development.json*:
~~~
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings":{
    "ConexaoPadrao": "Server=localhost\\sqlexpress; Initial Catalog=AgendaMvc; Integrated Security=True"
  }
}
~~~

6. Adicione o trecho no *Program* após o primeiro comentário:
~~~
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));
~~~

E importe:
~~~
using Microsoft.EntityFrameworkCore;
using Projetos_dotnet_MVC.Context;
~~~

7. Adicionar Migrações no terminal: *dotnet-ef migrations add AdicionaTabelaContato*

8. Criar Banco no SqlServer: *dotnet-ef database update*

##Codar

9. Criar classe *ContatoController* na pasta **Controllers** e herde a classe *Controller*

- Adicionar método principal:
~~~
public IActionResult Index(){
            return View();
        }
~~~

- Criar pasta **Contato** na pasta **Views** e adicione a página html *Index.cshtml*

- Adicionar biblioteca *using Microsoft.AspNetCore.Mvc;*
- Adicionar *using Projetos_dotnet_MVC.Context;*
- Adicionar *using Projetos_dotnet_MVC.Models;*

- Execute no terminal com *dotnet watch run*. Digite o link https://localhost:_/Contato

10. Adição novas linhas na classe *ContatoController*, identificadas com '//'

11. Adicionar método *Criar* na classe *ContatoController* e criar nova página html na pasta **Views**

12. Adicionar método *Editar* na classe *ContatoController* e criar nova página html na pasta **Views**

13. Adicionar método *Detalhes* na classe *ContatoController* e criar nova página html na pasta **Views**

14. Adicionar método *Deletar* na classe *ContatoController* e criar nova página html na pasta **Views**

15. Adicionar *Contatos* ao Menu Inicial em *Views\Shared\\_Layout.cshtml*