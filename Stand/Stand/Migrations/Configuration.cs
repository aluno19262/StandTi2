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
                            new Viaturas {ID=7, Matricula="AT-49-45",  Marca="BMW",  Modelo="335i",Ano="2017", TipoCombustivel="Gasolina", Cor="Preto",Cilindrada="2999",Potencia="300cv",Lugares="5",Tipo="Ligeiro"},
                            new Viaturas {ID=8, Matricula="AT-49-46",  Marca="Nissan",  Modelo="Micra",Ano="2017", TipoCombustivel="Gasolina", Cor="Preto",Cilindrada="1100",Potencia="58cv",Lugares="5",Tipo="Ligeiro"},
                            new Viaturas {ID=9, Matricula="AT-49-47",  Marca="Renault",  Modelo="Clio",Ano="2010", TipoCombustivel="Diesel", Cor="Branco",Cilindrada="1300",Potencia="71cv",Lugares="5",Tipo="Ligeiro"},
                            new Viaturas {ID=10, Matricula="AT-49-48",  Marca="Renault",  Modelo="Megane",Ano="2005", TipoCombustivel="Diesel", Cor="Preto",Cilindrada="1600",Potencia="110",Lugares="5",Tipo="Ligeiro"}
            };
            viaturas.ForEach(vv => context.Viaturas.AddOrUpdate(v => v.Matricula, vv));
            context.SaveChanges();

            //           //*********************************************************************
            //           // adiciona Imagens
            var imagens = new List<Imagens> {
                          new Imagens {ID=1,Fotografia="Ford_FocusWrc_1.jpg",Marca="Ford",Modelo="WRC",NumeroSeq="1", Viatura=viaturas[0]},
                          new Imagens {ID=2,Fotografia="Ford_FocusWrc_2.jpg",Marca="Ford",Modelo="WRC",NumeroSeq="2", Viatura=viaturas[0]},
                          new Imagens {ID=3,Fotografia="Ford_FocusWrc_3.jpg",Marca="Ford",Modelo="WRC",NumeroSeq="3", Viatura=viaturas[0]},
                          new Imagens {ID=4,Fotografia="Mazda_Rx7_1.jpg",Marca="Mazda",Modelo="Rx7",NumeroSeq="1", Viatura=viaturas[1]},
                          new Imagens {ID=5,Fotografia="Mazda_Rx7_2.jpg",Marca="Mazda",Modelo="Rx7",NumeroSeq="2", Viatura=viaturas[1]},
                          new Imagens {ID=6,Fotografia="Mazda_Rx7_3.jpg",Marca="Mazda",Modelo="Rx7",NumeroSeq="2", Viatura=viaturas[1]},
                          new Imagens {ID=7,Fotografia="Mercedes_Vito_1.jpg",Marca="Mercedes",Modelo="Vito",NumeroSeq="1", Viatura=viaturas[2]},
                          new Imagens {ID=8,Fotografia="Mercedes_Vito_2.jpg",Marca="Mercedes",Modelo="Vito",NumeroSeq="2", Viatura=viaturas[2]},
                          new Imagens {ID=9,Fotografia="Mercedes_Vito_3.jpg",Marca="Mercedes",Modelo="Vito",NumeroSeq="3", Viatura=viaturas[2]},
                          new Imagens {ID=10,Fotografia="Toyota_Supra_1.jpg",Marca="Toyota",Modelo="Supra",NumeroSeq="1",Viatura=viaturas[3]},
                          new Imagens {ID=11,Fotografia="Toyota_Supra_2.jpg",Marca="Toyota",Modelo="Supra",NumeroSeq="2",Viatura=viaturas[3]},
                          new Imagens {ID=12,Fotografia="Toyota_Supra_3.jpg",Marca="Toyota",Modelo="Supra",NumeroSeq="3",Viatura=viaturas[3]},
                          new Imagens {ID=13,Fotografia="Seat_Ibiza_1.jpg",Marca="Seat",Modelo="Ibiza",NumeroSeq="1",Viatura=viaturas[4]},
                          new Imagens {ID=14,Fotografia="Seat_Ibiza_2.jpg",Marca="Seat",Modelo="Ibiza",NumeroSeq="2",Viatura=viaturas[4]},
                          new Imagens {ID=15,Fotografia="Seat_Ibiza_3.jpg",Marca="Seat",Modelo="Ibiza",NumeroSeq="3",Viatura=viaturas[4]},
                          new Imagens {ID=16,Fotografia="Opel_Astra_1.jpg",Marca="Opel",Modelo="Astra",NumeroSeq="1",Viatura=viaturas[5]},
                          new Imagens {ID=17,Fotografia="Opel_Astra_2.jpg",Marca="Opel",Modelo="Astra",NumeroSeq="2",Viatura=viaturas[5]},
                          new Imagens {ID=18,Fotografia="Opel_Astra_3.jpg",Marca="Opel",Modelo="Astra",NumeroSeq="3",Viatura=viaturas[5]},
                          new Imagens {ID=19,Fotografia="Bmw_335i_1.jpg",Marca="BMW",Modelo="335i",NumeroSeq="1", Viatura=viaturas[6]},
                          new Imagens {ID=20,Fotografia="Bmw_335i_2.jpg",Marca="BMW",Modelo="335i",NumeroSeq="2", Viatura=viaturas[6]},
                          new Imagens {ID=21,Fotografia="Bmw_335i_3.jpg",Marca="BMW",Modelo="335i",NumeroSeq="3", Viatura=viaturas[6]},
                          new Imagens {ID=22,Fotografia="Nissan_Micra_1.jpg",Marca="Nissan",Modelo="Micra",NumeroSeq="1", Viatura=viaturas[7]},
                          new Imagens {ID=23,Fotografia="Nissan_Micra_2.jpg",Marca="Nissan",Modelo="Micra",NumeroSeq="2", Viatura=viaturas[7]},
                          new Imagens {ID=24,Fotografia="Nissan_Micra_3.jpg",Marca="Nissan",Modelo="Micra",NumeroSeq="3", Viatura=viaturas[7]},
                          new Imagens {ID=25,Fotografia="Renault_Clio_1.jpg",Marca="Renault",Modelo="Clio",NumeroSeq="1", Viatura=viaturas[8]},
                          new Imagens {ID=26,Fotografia="Renault_Clio_2.jpg",Marca="Renault",Modelo="Clio",NumeroSeq="2", Viatura=viaturas[8]},
                          new Imagens {ID=27,Fotografia="Renault_Clio_3.jpg",Marca="Renault",Modelo="Clio",NumeroSeq="3", Viatura=viaturas[8]},
                          new Imagens {ID=28,Fotografia="Renault_Megane_1.jpg",Marca="Renault",Modelo="Megane",NumeroSeq="1", Viatura=viaturas[9]},
                          new Imagens {ID=29,Fotografia="Renault_Megane_2.jpg",Marca="Renault",Modelo="Megane",NumeroSeq="2", Viatura=viaturas[9]},
                          new Imagens {ID=30,Fotografia="Renault_Megane_3.jpg",Marca="Renault",Modelo="Megane",NumeroSeq="3", Viatura=viaturas[9]}




                       };
            imagens.ForEach(ii => context.Imagens.AddOrUpdate(i => i.NumeroSeq, ii));
            context.SaveChanges();

            //           // adiciona Stands
            var stands = new List<Stands> {
                            new Stands {ID=1,Nome="AlbertoStand",Telefone="955555555",CodigoPostal="1111-111",Email="Alberto@hotmail.com",Localizacao="Porto",Zona="Porto"},
                            new Stands {ID=2,Nome="FernandoStand",Telefone="966666666",CodigoPostal="2222-222",Email="Fernando@hotmail.com",Localizacao="Lisboa",Zona="Lisboa"},
                            new Stands {ID=3,Nome="TonyStand",Telefone="977777777",CodigoPostal="3333-333",Email="Tony@hotmail.com",Localizacao="Braga",Zona="Braga"},
                            new Stands {ID=4,Nome="CarlosStand",Telefone="988888888",CodigoPostal="4444-444",Email="Carlos@hotmail.com",Localizacao="Evora",Zona="Evora"},
                            new Stands {ID=5,Nome="ZéStand",Telefone="999999999",CodigoPostal="5555-555",Email="Carlos@hotmail.com",Localizacao="Porto",Zona="Porto"},
                            new Stands {ID=6,Nome="DanyStand",Telefone="999999991",CodigoPostal="6666-666",Email="Carlos@hotmail.com",Localizacao="Lisboa",Zona="Lisboa"},
                            new Stands {ID=7,Nome="RodaStand",Telefone="999999992",CodigoPostal="7777-777",Email="Carlos@hotmail.com",Localizacao="Braga",Zona="Braga"},
                            new Stands {ID=8,Nome="PneuStand",Telefone="999999993",CodigoPostal="8888-888",Email="Carlos@hotmail.com",Localizacao="Evora",Zona="Evora"},
                            new Stands {ID=9,Nome="SpeedStand",Telefone="999999994",CodigoPostal="9999-999",Email="Carlos@hotmail.com",Localizacao="Porto",Zona="Porto"},
                            new Stands {ID=10,Nome="BrakeStand",Telefone="999999995",CodigoPostal="0000-000",Email="Carlos@hotmail.com",Localizacao="Faro",Zona="Faro"}

                      };
            stands.ForEach(ss => context.Stands.AddOrUpdate(s => s.Telefone, ss));
            context.SaveChanges();

            //           // adiciona ViaturasStands 
            var viaturasStands = new List<ViaturasStands> {
                           new ViaturasStands {ID=1,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=true,ViaturaFK=1,StandFK=1},
                           new ViaturasStands {ID=2,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=2,StandFK=2},
                           new ViaturasStands {ID=3,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=3,StandFK=3},
                           new ViaturasStands {ID=4,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=4,StandFK=4},
                           new ViaturasStands {ID=5,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=5,StandFK=5},
                           new ViaturasStands {ID=6,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=6,StandFK=6},
                           new ViaturasStands {ID=7,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=7,StandFK=7},
                           new ViaturasStands {ID=8,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=8,StandFK=8},
                           new ViaturasStands {ID=9,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=9,StandFK=9},
                           new ViaturasStands {ID=10,DataEntrega=new DateTime(2017,9,25),DataSaida=new DateTime(2017,9,25),Vendido=false,ViaturaFK=10,StandFK=10}


                       };
            viaturasStands.ForEach(pp => context.ViaturasStands.AddOrUpdate(p => p.DataEntrega, pp));
            context.SaveChanges();


            //           //*********************************************************************
            //           // adiciona Utlizadores
            var cliente = new List<Cliente> {
                        new Cliente {ID=1,UserName="Pedro", Nome="Pedro Silva",Fotografia="user1.jpg", Email="user1@hotmail.com",Vendedor=true,NomeRegistoDoUtilizador="PedroSilva"},
                          new Cliente {ID=2,UserName="José", Nome="José Matos",Fotografia="user2.jpg", Email="user2@hotmail.com",Vendedor=false,NomeRegistoDoUtilizador="JosEMatos"},
                          new Cliente {ID=3,UserName="Joaquim", Nome="Joaquim Sousa",Fotografia="user3.jpg", Email="user3@hotmail.com",Vendedor=false,NomeRegistoDoUtilizador="JoaquimSousa"},
                          new Cliente {ID=4,UserName="João", Nome="João Alves",Fotografia="user4.jpg", Email="user4@hotmail.com",Vendedor=false,NomeRegistoDoUtilizador="JoaoAlves"},
                         new Cliente {ID=5,UserName="Rafael", Nome="Rafael Silva",Fotografia="user5.jpg", Email="user5@hotmail.com",Vendedor=false,NomeRegistoDoUtilizador="RafaelSilva"},
                          new Cliente {ID=6,UserName="Tiago", Nome="Tiago Nunes",Fotografia="user6.jpg", Email="user6@hotmail.com",Vendedor=false,NomeRegistoDoUtilizador="TiagoNunes"},
                          new Cliente {ID=6,UserName="Miguel", Nome="Miguel Esteves",Fotografia="user7.jpg", Email="user7@hotmail.com",Vendedor=false,NomeRegistoDoUtilizador="MiguelEsteves"},
                          new Cliente {ID=6,UserName="Telmo", Nome="Telmo Henriques",Fotografia="user8.jpg", Email="user8@hotmail.com",Vendedor=false,NomeRegistoDoUtilizador="TelmoHenriques"},
                          new Cliente {ID=6,UserName="Daniel", Nome="Daniel Ferreira",Fotografia="user9.jpg", Email="user9@hotmail.com",Vendedor=false,NomeRegistoDoUtilizador="DanielFerreira"},
                          new Cliente {ID=6,UserName="Carlos", Nome="Carlos Pereira",Fotografia="user10.jpg", Email="user10@hotmail.com",Vendedor=false,NomeRegistoDoUtilizador="CarlosPereira"}



                     };
            cliente.ForEach(uu => context.Cliente.AddOrUpdate(u => u.Nome, uu));
            context.SaveChanges();



            //           //*********************************************************************
            //           // adiciona Compras
            var compras = new List<Compras> {
                             new Compras {ID=1,NomeStand="AlbertoStand",Preco="3000",Marca="Renault",Modelo="Clio",Ano="2001",TipoCombustivel="Gasolina",IdStand="1",Vendedor=true,StandFK=1},
                             new Compras {ID=2,NomeStand="FernandoStand",Preco="5000",Marca="Seat",Modelo="Ibiza",Ano="2004",TipoCombustivel="Diesel",IdStand="2",Vendedor=false,StandFK=2 },
                            new Compras {ID=3,NomeStand="TonyStand",Preco="8000",Marca="VW",Modelo="Golf",Ano="2008",TipoCombustivel="Diesel",IdStand="3" ,Vendedor=true,StandFK=3},
                             new Compras {ID=4,NomeStand="CarlosStand",Preco="2000",Marca="vw",Modelo="Passatcc",Ano="5555",TipoCombustivel="Gasolina",IdStand="4",Vendedor=true,StandFK=4 },
                             new Compras {ID=5,NomeStand="ZéStand",Preco="1500",Marca="Ford",Modelo="Fiesta",Ano="1992",TipoCombustivel="Gasolina",IdStand="5",Vendedor=true,StandFK=5 },
                             new Compras {ID=6,NomeStand="DanyStand",Preco="2500",Marca="Toyota",Modelo="Yaris",Ano="2000",TipoCombustivel="Gasolina",IdStand="6",Vendedor=false,StandFK=6 },
                             new Compras {ID=7,NomeStand="RodaStand",Preco="4000",Marca="Opel",Modelo="Astra",Ano="2003",TipoCombustivel="Diesel",IdStand="7",Vendedor=false,StandFK=7 },
                             new Compras {ID=8,NomeStand="PneuStand",Preco="4000",Marca="Opel",Modelo="Astra",Ano="2003",TipoCombustivel="Diesel",IdStand="8",Vendedor=false,StandFK=8 },
                             new Compras {ID=9,NomeStand="SpeedStand",Preco="4000",Marca="Opel",Modelo="Astra",Ano="2003",TipoCombustivel="Diesel",IdStand="9",Vendedor=false,StandFK=9 },
                             new Compras {ID=10,NomeStand="BrakeStand",Preco="4000",Marca="Opel",Modelo="Astra",Ano="2003",TipoCombustivel="Diesel",IdStand="10",Vendedor=false,StandFK=10 }



                       };
            compras.ForEach(ee => context.Compras.AddOrUpdate(e => e.Preco, ee));
            context.SaveChanges();



        }
    }
}
