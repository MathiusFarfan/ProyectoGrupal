using Infra.DataAccess.Repository;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var resultado = new MaterialRepository().ReservarMaterial(2, 2);
            Assert.Equal(true,resultado);
        }
    }
}
