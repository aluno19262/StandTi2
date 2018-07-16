using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Owin;
using Stand.Models;

namespace Stand
{
    public partial class Startup
    {
       // public ApplicationDbContext ProjetoDb { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            IniciaAplicacao();
        }

        /// <summary>
        /// cria, caso não existam, as Roles de suporte à aplicação: Veterinario, Funcionario, Dono
        /// cria, nesse caso, também, um utilizador...
        /// </summary>
        private void IniciaAplicacao()
        {

            ApplicationDbContext db = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            // criar a Role 'Cliente'
            if (!roleManager.RoleExists("Cliente"))
            {
                // não existe a 'role'
                // então, criar essa role
                var role = new IdentityRole();
                role.Name = "Cliente";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Administrador"))
            {

                var role = new IdentityRole();
                role.Name = "Administrador";
                roleManager.Create(role);
            }


            // criar um utilizador 'Agente'
            var user = new ApplicationUser();
            user.UserName = "user1@hotmail.com";
            user.Email = "user1@hotmail.com";
            string userPWD = "123_Asd";
            var chkUser = userManager.Create(user, userPWD);

            //Adicionar o Utilizador à respetiva Role-Agente-
            if (chkUser.Succeeded)
            {
                var result1 = userManager.AddToRole(user.Id, "Cliente");
            }

             user = new ApplicationUser();
            user.UserName = "user2@hotmail.com";
            user.Email = "user2@hotmail.com";
            userPWD = "123_Asd";
            chkUser = userManager.Create(user, userPWD);

            //Adicionar o Utilizador à respetiva Role-Agente-
            if (chkUser.Succeeded)
            {
                var result1 = userManager.AddToRole(user.Id, "Administrador");
            }
        }

        // https://code.msdn.microsoft.com/ASPNET-MVC-5-Security-And-44cbdb97
    }
}
