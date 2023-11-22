using ALAYSchoolManager.Domain.Exceptions;

namespace ALAYSchoolManager.Domain.Entidades;

public class AnoAcademico
{
    public int AnoAcademicoId { get; set; }
    public string? AnoAcademicoDesignacao { get; private set; }
    public bool AnoAcademicoEstado { get; private set; }
    public DateTime AnoAcademicoDataCriacao { get; private set; }

    public void Actualizar(string anoAcademico)
    {

    }

    private void Validar()
    {
        if (string.IsNullOrEmpty(AnoAcademicoDesignacao))
            throw new EntityValidationException($"{nameof(AnoAcademicoDesignacao)} não pode ser vazio ou nulo");

    }

    public AnoAcademico(string anoAcademicoDesignacao, bool anoAcademicoEstado = true)
    {
        AnoAcademicoDesignacao = anoAcademicoDesignacao;
        AnoAcademicoEstado = anoAcademicoEstado;
        AnoAcademicoDataCriacao = DateTime.Now;
        Validar();

    }

}