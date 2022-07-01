using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualMagazine.Migrations
{
    public partial class AdicionandoBanco : Migration
    {
         protected override void Up(MigrationBuilder migrationBuilder)
        {
            //receita 1
            migrationBuilder.Sql("INSERT INTO Receitas(Nome,ModoPreparo,TempoPreparo,Status) VALUES('Batata Recheada','1 Lave bem as batatas e retire uma tampa no sentido do comprimento.2 Disponha na panela de pressão, cubra com água e leve ao fogo médio.3 Assim que começar a chiar, conte 10 minutos.4 Libere a pressão para abrir a panela, retire as batatas e, com uma colher, cave o miolo (com cuidado para não perfurar).5 Reserve as batatas e o miolo. Frite o bacon na própria gordura em fogo médio até dourar.6 Adicione a cebola e refogue até dourar.7 Misture com metade do miolo das batatas (com a outra metade, faça um purê), o frango desfiado, o requeijão e cheiro-verde a gosto.8 Recheie a cavidade das batatas e polvilhe parmesão ralado.9 Disponha em assadeira e leve ao forno médio preaquecido (180 ºC) por cerca de 15 minutos ou até gratinar.', '50 Minutos', 1)");
            migrationBuilder.Sql("INSERT INTO UnidadeDeMedidas(Nome,Status,ReceitaId) VALUES('3 batatas grandes com casca,100 g de bacon picado,50 g de cebola picada,250 g de peito de frango cozido e desfiado (ou presunto, carne moída refogada, linguiça grelhada e picada),100 g de requeijão cremoso,Cheiro-verde (salsinha e cebolinha) picado a gosto,Parmesão ralado para polvilhar.', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Igredientes(Nome,ReceitaId,UnidadeDeMedidaId,Medicao,Status) VALUES('Batatas, Bacon, Cebola, Peito de frango(ou presunto, carne moída refogada, linguiça grelhada e picada), Requeijão, Cheiro-verde (salsinha e cebolinha), Parmesão.', 1, 1, 0, 1)");
           
           //receita 2
            migrationBuilder.Sql("INSERT INTO Receitas(Nome,ModoPreparo,TempoPreparo,Status) VALUES('Espirantelli à Napolitana','1 Coloque uma fatia de presunto e uma de queijo, uma sobra a outra até utilizar toda a quantidade da receita.2 Cozinhe o macarrão. Refogue o macarrão com o sal e a pimenta do reino (use azeite).3 Recheie o queijo e o presunto com o macarrão refogado. Faça rolinhos e leve ao freezer.4 Após congelado, retire do freezer e corte os rolinhos ao meio. Numa travessa refratária, coloque uma camada de molho branco (150g) e outra de molho de tomate (150g).5 Coloque as metades dos rolinhos, em pé, uma ao lado da outra, até preencher a travessa.6 Em cima de cada rolinho coloque uma bolinha de requeijão culinário.7 Coloque a outra camada de molho branco e molho vermelho. Polvilhe com parmesão e leve ao forno para gratinar.', '35 Minutos', 1)");
            migrationBuilder.Sql("INSERT INTO UnidadeDeMedidas(Nome,Status,ReceitaId) VALUES('500 gr de mussarela,500 gr de presunto gordo,200 gr de capelli d’angelo,pimenta-do-reino branca moída(s) a gosto,sal a gosto,300 gr de molho de tomate,300 gr de molho bechamel,requeijão culinário a gosto,parmesão ralado(s) a gosto', 1, 2)");
            migrationBuilder.Sql("INSERT INTO Igredientes(Nome,ReceitaId,UnidadeDeMedidaId,Medicao,Status) VALUES('Mussarela,Presunto gordo,Capelli d’angelo,Pimenta-do-reino branca,Molho de tomate,Molho bechamel,Requeijão culinário,Parmesão.', 2, 2, 0, 1)");
            //usuario
            migrationBuilder.Sql("INSERT INTO aspnetusers(Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount) VALUES('58d47ea9-dc12-43ca-9952-ddb9c5ff415d','usuario@gft.com','USUARIO@GFT.COM','usuario@gft.com','USUARIO@GFT.COM',1,'AQAAAAEAACcQAAAAEIa0Ie3VKgn9gTt0Sy87vCCtD5XR/jF/F4UY6ckiom1JrO368EsxYxYK+DI2ZvXI/g==','ILTHWFWJQFHRYXCPHUTTBXLBIBRCXCZH','064cd62b-24ca-4efa-830b-cd26f32b1768',NULL,0,0,NULL,1,0)");
            migrationBuilder.Sql("INSERT INTO aspnetusers(Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount) VALUES('251fdde7-846a-4282-a118-2009d458b9bb','admin@gft.com','ADMIN@GFT.COM','admin@gft.com','ADMIN@GFT.COM',1,'AQAAAAEAACcQAAAAEPo77x1suXvatcWG6iDCkHxmN04oDkKoZcadtpCR640tDAsDKJg2wxdQUp9g1X0UmA==','F2QAFXOCUGDPCEO6JLQ4VCUFB4RNQTM4','316a0246-6a69-490c-adf1-bf2f413c70b0',NULL,0,0,NULL,1,0)");
            //Claims
            migrationBuilder.Sql("INSERT INTO Aspnetuserclaims(UserId,ClaimType,ClaimValue) VALUES('58d47ea9-dc12-43ca-9952-ddb9c5ff415d','NomeAutorizado','usuario@gft.com')");
            migrationBuilder.Sql("INSERT INTO Aspnetuserclaims(UserId,ClaimType,ClaimValue) VALUES('251fdde7-846a-4282-a118-2009d458b9bb','NomeAutorizado','admin@gft.com')");
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Receitas");
            migrationBuilder.Sql("DELETE FROM UnidadeDeMedida");
            migrationBuilder.Sql("DELETE FROM Igredientes");
            migrationBuilder.Sql("DELETE FROM aspnetusers");
        }
    }
}
