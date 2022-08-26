using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BaseApi.Tests
{
    public class ItemRepositoryDatabaseTeste
    {
        [Fact(DisplayName="Deve retornar os itens do bd.")]
        public void retornaItemBd()
        {
            ItemRepositoryDatabase itemRepositoryDatabase = new ItemRepositoryDatabase(new AppDbContext());

            Assert.Equal(0,itemRepositoryDatabase.getList().Count);
        }
    }
}