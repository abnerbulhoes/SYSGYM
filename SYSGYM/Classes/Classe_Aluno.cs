using System.Windows.Forms;

public class Classe_Aluno : Classe_Pessoa
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

	private Classe_Mensalidade mensalidade;
    public Classe_Mensalidade Mesnsalidade
    {
        get { return mensalidade; }
        set { mensalidade = Mesnsalidade; }
    }

	public void SairAcademia()
	{
        if (Ativo == false)
        {
            MessageBox.Show("N�o est� dentro da Academia!");
        }
        else
            Ativo = false;
    }

    public void EntraAcademia()
    {
        if (Ativo == true)
        {
            MessageBox.Show("J� est� dentro da Academia!");
        }
        else
            Ativo = true;
    }

}

