using ALAYSchoolManager.Domain.Entidades;

namespace AlaySchoolManager.UnitTests.Domain.Entidades;

public class AnoAcademicoTest
{
    #region Instancia

    [Fact(DisplayName = nameof(Instancia))]
    [Trait("Domain", "Ano Academico")]
    public void Instancia()
    {
        //AAA
        //Arrange
        var anoAcademico = new AnoAcademico("2023-2024");
        //Act
        anoAcademico.
        //Assert
    }


    #endregion
}