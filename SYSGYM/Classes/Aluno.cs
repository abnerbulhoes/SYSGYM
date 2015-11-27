using System.Windows.Forms;

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

	public void SairAcademia()
	{
        if (Ativo == false)
        {
            MessageBox.Show("Não está dentro da Academia!");
        }
        else
            Ativo = false;
    }

    public void EntraAcademia()
    {
        if (Ativo == true)
        {
            MessageBox.Show("Já está dentro da Academia!");
        }
        else
            Ativo = true;
    }

}

