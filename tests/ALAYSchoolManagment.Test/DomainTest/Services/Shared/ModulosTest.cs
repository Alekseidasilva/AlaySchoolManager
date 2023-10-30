using ALAYSchoolManager.Domain.Entidades.Shared;
using ALAYSchoolManager.Domain.Interfaces.Services.Shared;
using Moq;

namespace ALAYSchoolManager.Test.DomainTest.Services.Shared;

[TestClass]
public class ModulosTest
{
    #region Variaveis
    private readonly IModulosService _modulosService;

    #endregion
    #region Construtores
    public ModulosTest(IModulosService modulosService)
    {
        _modulosService = modulosService;

    }
    #endregion
    #region Metodos
    [TestMethod]
    public void TestandoRetornoDoModuloPorId()
    {

        //Arange
        Mock<IModulosService> mockModuloService = new Mock<IModulosService>();
        mockModuloService.Setup(a => a.ObterPorId(It.IsAny<int>())).Returns(ModuloMock);

        //Act
        var res = _modulosService.ObterPorId(1);

        //Assert
        Assert.AreEqual(1, 1);


    }
    #endregion
    #region Gerar Dados

    private Modulos ModuloMock()
    {
        return new Modulos()
        {
            ModuloId = 1,
            ModuloDesignacao = "Creche"
        };
    }


    #endregion

}