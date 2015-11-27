using System.Windows.Forms;

public class Instrutor : Pessoa
{
	private string login;
    public string Loogin
    {
        get { return login; }
        set { login = Loogin; }
    }

	private int senha;
    public int Senha
    {
        get { return senha; }
        set { senha = Senha; }
    }

	private bool ativo;
    public bool Ativo
    {
        get { return ativo; }
        set { ativo = Ativo; }
    }

	public void GeraRelatorio()
	{

	}

	public void Login()
	{
        if (this.Ativo == true)
        {
            MessageBox.Show("O usuário já está logado!");
        }else
        this.Ativo = true;
	}

	public void Logout()
	{
        this.Ativo = false;
	}

	public void RealizaAvaliacao()
	{

	}

	public void CadastrarAluno()
	{

	}

	public void BuscarAluno()
	{

	}

	public void ExcluirAluno()
	{

	}

	public void AlterarAluno()
	{

	}

	public void AlterarMensalidade()
	{

	}

	public void GerarMensalidade()
	{

	}

	public void ExcluirMensalidade()
	{

	}

	public void AlterarAvaliacao()
	{

	}

	public void ExcluirAvaliacao()
	{

	}

	public void CalcularIMC()
	{

	}

}

