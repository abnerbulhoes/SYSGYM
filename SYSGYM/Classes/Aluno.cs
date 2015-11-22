public class Aluno : Pessoa
{
	private bool ativo;
    public bool Ativo
    {
        get { return ativo; }
        set { ativo = Ativo; }
    }

    private long matricula;
    public long Matricula
    {
        get { return matricula; }
        set { matricula = Matricula; }
    }

	private Mensalidade mensalidade;
    public Mensalidade Mesnsalidade
    {
        get { return mensalidade; }
        set { mensalidade = Mesnsalidade; }
    }

	public void AcessaAcademia()
	{

	}

}

