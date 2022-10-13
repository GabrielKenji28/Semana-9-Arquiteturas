using AppFinalCaminhao.Infra.Models;
using AppFinalCaminhao.Service.Inteface;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppFinalCaminhao.Service.Test
{
    public class CaminhaoServiceTest
    {
        [Fact]
        public void TesteAnunciarCaminhao()
        {
            //arrange
            var caminhaoService = new Mock<ICaminhaoService>();
            var caminhao = new Caminhao()
            {
                Nome = "caminhao para teste",
                Descricao = "de carga teste",
                Modelo = Infra.Models.Enums.EnumModelo.Modelos.Jetta,
                DataCriacao = "1000"
            };
            


        }
    } 
}


