namespace Dojo4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAlunos2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Alunoes(Faixa_Id, TipoDeAssociacao_Id, Nome, Cpf) VALUES (15, 09 , 'Martim Castro Ribeiro', '158.778.735-04')");
            Sql("INSERT INTO Alunoes(Faixa_Id, TipoDeAssociacao_Id, Nome, Cpf) VALUES (18, 11 , 'Lucas Alves Melo', '916.749.332-74')");
            Sql("INSERT INTO Alunoes(Faixa_Id, TipoDeAssociacao_Id, Nome, Cpf) VALUES (16, 10 , 'Breno Castro Carvalho', '454.019.800-94')");
            Sql("INSERT INTO Alunoes(Faixa_Id, TipoDeAssociacao_Id, Nome, Cpf) VALUES (20, 12 , 'Laura Cardoso Rocha', '361.089.665-56')");
        }
        
        public override void Down()
        {
        }
    }
}
