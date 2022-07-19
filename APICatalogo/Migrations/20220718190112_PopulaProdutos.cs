using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mB)
        {
            mB.Sql("insert into Produtos(Nome,Descricao,Preco,Desconto,DataCadastro) Values('Skol','Lata 350ml','6.00','25',now())");
            mB.Sql("insert into Produtos(Nome,Descricao,Preco,Desconto,DataCadastro) Values('Brahma','Lata 350ml','7.00','30',now())");
            mB.Sql("insert into Produtos(Nome,Descricao,Preco,Desconto,DataCadastro) Values('Stella','Lata 350ml','8.00','35',now())");
            mB.Sql("insert into Produtos(Nome,Descricao,Preco,Desconto,DataCadastro) Values('Bohemia','Lata 350ml','9.00','40',now())");
        }

        protected override void Down(MigrationBuilder mB)
        {
            mB.Sql("delete from Produtos");
        }
    }
}
