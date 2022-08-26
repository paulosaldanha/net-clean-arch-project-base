using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.domain.entity;
using Xunit;

namespace BaseApi.Tests
{
    public class DimensionTest
    {
        [Fact(DisplayName="Deve criar as dimensoes")]
        public void criarDimensoes()
        {
            Dimension dimension = new Dimension(15,5,2);
            
            Assert.Equal(0.00015,dimension.getVolume());
        }
    }
}