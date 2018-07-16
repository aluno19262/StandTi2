namespace Stand.Migrations
{
    using Stand.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Stand.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Stand.Models.ApplicationDbContext context)
        {

            // adiciona VIATURAS
            var viaturas = new List<Viaturas> {
                            new Viaturas {ID=1, Matricula="AT-47-45",  Marca="Ford",  Modelo="Focus WRC",Ano="2004", TipoCombustivel="Gasolina", Cor="Branco",Cilindrada="1399",Potencia="104cv",Lugares="5",Tipo="Ligeiro" },
                            new Viaturas {ID=2, Matricula="AT-47-46",  Marca="Mazda",  Modelo="Rx7",Ano="1997", TipoCombustivel="Gasolina", Cor="Amarelo",Cilindrada="1308",Potencia="240cv",Lugares="2",Tipo="Ligeiro"},
                            new Viaturas {ID=3, Matricula="AT-47-47",  Marca="Mercedes",  Modelo="Vito",Ano="2007", TipoCombustivel="Diesel", Cor="Cinzento",Cilindrada="2399",Potencia="189cv",Lugares="3",Tipo="Ligeiro"},
                            new Viaturas {ID=4, Matricula="AT-47-48",  Marca="Toyota",  Modelo="Supra",Ano="1993", TipoCombustivel="Gasolina", Cor="Branco",Cilindrada="2999",Potencia="330cv",Lugares="2",Tipo="Ligeiro" },
                            new Viaturas {ID=5, Matricula="AT-47-49",  Marca="Seat",  Modelo="Ibiza",Ano="2006", TipoCombustivel="Diesel", Cor="Preto",Cilindrada="1399",Potencia="75cv",Lugares="2",Tipo="Ligeiro"},
                            new Viaturas {ID=6, Matricula="AT-48-45",  Marca="Opel",  Modelo="Astra",Ano="2011", TipoCombustivel="Diesel", Cor="Verde",Cilindrada="1899",Potencia="115cv",Lugares="5",Tipo="Ligeiro"},
                            new Viaturas {ID=7, Matricula="AT-49-45",  Marca="BMW",  Modelo="335i",Ano="2017", TipoCombustivel="Gasolina", Cor="Preto",Cilindrada="2999",Potencia="300cv",Lugares="5",Tipo="Ligeiro"}

            };
            viaturas.ForEach(vv => context.Viaturas.AddOrUpdate(v => v.Matricula, vv));
            context.SaveChanges();

            //           //*********************************************************************
            //           // adiciona Imagens
            var imagens = new List<Imagens> {
                          new Imagens {ID=1,Fotografia="Mazda_Rx7_1",Marca="Mazda",Modelo="Rx7",NumeroSeq="1"},
                          new Imagens {ID=2,Fotografia="Mazda_Rx7_2",Marca="Mazda",Modelo="Rx7",NumeroSeq="2"},
                          new Imagens {ID=3,Fotografia="Bmw_335i_1",Marca="BMW",Modelo="335i",NumeroSeq="1"},
                          new Imagens {ID=4,Fotografia="Bmw_335i_2",Marca="BMW",Modelo="335i",NumeroSeq="2"},
                          new Imagens {ID=5,Fotografia="Bmw_335i_3",Marca="BMW",Modelo="335i",NumeroSeq="3"},
                          new Imagens {ID=6,Fotografia="Toyota_Supra_1",Marca="Toyota",Modelo="Supra",NumeroSeq="1"},
                          new Imagens {ID=7,Fotografia="Toyota_Supra_2",Marca="Toyota",Modelo="Supra",NumeroSeq="2"},
                          new Imagens {ID=8,Fotografia="Toyota_Supra_3",Marca="Toyota",Modelo="Supra",NumeroSeq="3"},
                          new Imagens {ID=9,Fotografia="Toyota_Supra_4",Marca="Toyota",Modelo="Supra",NumeroSeq="4"},
                          new Imagens {ID=10,Fotografia="Opel_Astra_1",Marca="Opel",Modelo="Astra",NumeroSeq="1"}

                       };
            imagens.ForEach(ii => context.Imagens.AddOrUpdate(i => i.NumeroSeq, ii));
            context.SaveChanges();

            //           // adiciona Stands
            var stands = new List<Stands> {
                            new Stands {ID=1,Nome="AlbertoStand",Telefone="955555555",CodigoPostal="1111-111",Email="Alberto@hotmail.com",Localizacao="Porto",Zona="Porto"},
                            new Stands {ID=2,Nome="FernandoStand",Telefone="966666666",CodigoPostal="2222-222",Email="Fernando@hotmail.com",Localizacao="Lisboa",Zona="Lisboa"},
                            new Stands {ID=3,Nome="TonyStand",Telefone="977777777",CodigoPostal="3333-333",Email="Tony@hotmail.com",Localizacao="Braga",Zona="Braga"},
                            new Stands {ID=4,Nome="CarlosStand",Telefone="988888888",CodigoPostal="4444-444",Email="Carlos@hotmail.com",Localizacao="Faro",Zona="Faro"}
                      };
            stands.ForEach(ss => context.Stands.AddOrUpdate(s => s.Telefone, ss));
            context.SaveChanges();

            //           // adiciona ViaturasStands 
            var viaturasStands = new List<ViaturasStands> {
                           new ViaturasStands {ID=1,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=true,ViaturaFK=1,StandFK=1},
                           new ViaturasStands {ID=2,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=2,StandFK=2},
                           new ViaturasStands {ID=3,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=3,StandFK=3},
                           new ViaturasStands {ID=4,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=4,StandFK=4},
                           new ViaturasStands {ID=5,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=5,StandFK=4},
                           new ViaturasStands {ID=6,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=6,StandFK=4},
                           new ViaturasStands {ID=7,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=7,StandFK=4}


                       };
            viaturasStands.ForEach(pp => context.ViaturasStands.AddOrUpdate(p => p.DataEntrega, pp));
            context.SaveChanges();


            //           //*********************************************************************
            //           // adiciona Utlizadores
            var cliente = new List<Cliente> {
                        new Cliente {ID=1,UserName="Pedro", Nome="Pedro Silva",Fotografia="user1.jpg", Email="user1@hotmail.com",Vendedor=true,NomeRegistoDoUtilizador=""},
                          new Cliente {ID=2,UserName="José", Nome="José Matos",Fotografia="user2.jpg", Email="user2@hotmail.com",Vendedor=true,NomeRegistoDoUtilizador=""},
                          new Cliente {ID=3,UserName="Joaquim", Nome="Joaquim Sousa",Fotografia="user3.jpg", Email="user3@hotmail.com",Vendedor=true,NomeRegistoDoUtilizador=""},
                          new Cliente {ID=4,UserName="João", Nome="João Alves",Fotografia="user4.jpg", Email="user4@hotmail.com",Vendedor=true,NomeRegistoDoUtilizador=""},
                         new Cliente {ID=5,UserName="Rafael", Nome="Rafael Silva",Fotografia="user5.jpg", Email="user5@hotmail.com",Vendedor=true,NomeRegistoDoUtilizador=""},
                          new Cliente {ID=6,UserName="Tiago", Nome="Tiago Nunes",Fotografia="user6.jpg", Email="user6@hotmail.com",Vendedor=true,NomeRegistoDoUtilizador=""}



                     };
            cliente.ForEach(uu => context.Cliente.AddOrUpdate(u => u.Nome, uu));
            context.SaveChanges();



            //           //*********************************************************************
            //           // adiciona Compras
            var compras = new List<Compras> {
                             new Compras {ID=1,NomeStand="AlbertoStand",Preco="3000",Marca="Renault",Modelo="Clio",Ano="2001",TipoCombustivel="Gasolina",IdStand="1",Vendedor=true,StandFK=1},
                             new Compras {ID=2,NomeStand="AlbertoStand",Preco="5000",Marca="Seat",Modelo="Ibiza",Ano="2004",TipoCombustivel="Diesel",IdStand="1",Vendedor=false,StandFK=2 },
                            new Compras {ID=3,NomeStand="FernandoStand",Preco="8000",Marca="VW",Modelo="Golf",Ano="2008",TipoCombustivel="Diesel",IdStand="2" ,Vendedor=true,StandFK=3},
                             new Compras {ID=4,NomeStand="FernandoStand",Preco="2000",Marca="vw",Modelo="Passatcc",Ano="5555",TipoCombustivel="Gasolina",IdStand="2",Vendedor=true,StandFK=3 },
                             new Compras {ID=5,NomeStand="TonyStand",Preco="1500",Marca="Ford",Modelo="Fiesta",Ano="1992",TipoCombustivel="Gasolina",IdStand="3",Vendedor=true,StandFK=1 },
                             new Compras {ID=6,NomeStand="TonyStand",Preco="2500",Marca="Toyota",Modelo="Yaris",Ano="2000",TipoCombustivel="Gasolina",IdStand="3",Vendedor=false,StandFK=1 },
                             new Compras {ID=7,NomeStand="CarlosStand",Preco="4000",Marca="Opel",Modelo="Astra",Ano="2003",TipoCombustivel="Diesel",IdStand="4",Vendedor=false,StandFK=1 }



                       };
            compras.ForEach(ee => context.Compras.AddOrUpdate(e => e.Preco, ee));
            context.SaveChanges();



        }
    }
}
