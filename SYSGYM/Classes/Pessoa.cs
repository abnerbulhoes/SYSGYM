using System;

public class Pessoa
{
	private string nome;
    public string Nome
    {
        get { return nome; }
        set { nome = Nome; }
    }

	private int cpf;
    public int CPF
    {
        get { return cpf; }
        set { cpf = CPF; }
    }

	private char sexo;
    public char Sexo
    {
        get { return sexo; }
        set { sexo = Sexo; }
    }

	private string email;
    public string Email
    {
        get { return email; }
        set { email = Email; }
    }

	private DateTime _dataNascimento;
    public DateTime DataNascimento
    {
        get { return _dataNascimento; }
        set { _dataNascimento = DataNascimento; }
    }

	private DateTime _datacadastro;
    public DateTime DataCadastro
    {
        get { return _datacadastro; }
        set { _datacadastro = DataCadastro; }
    }

	private int numTelefone;
    public int NumTelefone
    {
        get { return numTelefone; }
        set { numTelefone = NumTelefone; }
    }

    private Endereco _endereco;
    public Endereco Endereco
    {
        get { return _endereco; }
        set { _endereco = Endereco; }
    }

}

