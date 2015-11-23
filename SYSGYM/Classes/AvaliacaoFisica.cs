using System;

public class AvaliacaoFisica
{
	private DateTime _dataAvaliacao;
    public DateTime DataAvaliacao
    {
        get { return _dataAvaliacao; }
        set { _dataAvaliacao = DataAvaliacao; }
    }    

    private double peso;
    public double Peso
    {
        get { return peso; }
        set { peso = Peso; }
    }

	private double altura;
    public double Altura
    {
        get { return altura; }
        set { altura = Altura; }
    }

	private double imc;
    public double IMC
    {
        get
        {
            imc = Peso / Altura * Altura;
            return imc;
        }
    }

	private double peito;
    public double Peito
    {
        get { return peito; }
        set { peito = Peito; }
    }

	private double cintura;
    public double Cintura
    {
        get { return cintura; }
        set { cintura = Cintura; }
    }

	private double panturrilhaDireita;
    public double PanturrilhaDireita
    {
        get { return panturrilhaDireita; }
        set { panturrilhaDireita = PanturrilhaDireita; }
    }

	private double panturrilhaEsquerta;
    public double PanturrilhaEsquerda
    {
        get { return panturrilhaEsquerta; }
        set { panturrilhaEsquerta = PanturrilhaEsquerda; }
    }

	private double coxaDireira;
    public double CoxaDireira
    {
        get { return coxaDireira; }
        set { coxaDireira = CoxaDireira; }
    }

    private double coxaEsquerda;
    public double CoxaEsquerda
    {
        get { return coxaEsquerda; }
        set { coxaEsquerda = CoxaEsquerda; }
    }

	private double bracoDireito;
    public double BracoDireito
    {
        get { return bracoDireito; }
        set { bracoDireito = BracoDireito; }
    }

	private double bracoEsquerdo;
    public double BracoEsquerdo
    {
        get { return bracoEsquerdo; }
        set { bracoEsquerdo = BracoEsquerdo; }
    }

	private double antebracoDireito;
    public double AntebracoDireito
    {
        get { return antebracoDireito; }
        set { antebracoDireito = AntebracoDireito; }
    }

	private double antebracoEsquerdo;
    public double AntebracoEsquerdo
    {
        get { return antebracoEsquerdo; }
        set { antebracoEsquerdo = AntebracoEsquerdo; }
    }

	private double gluteo;
    public double Gluteo
    {
        get { return gluteo; }
        set { gluteo = Gluteo; }
    }

	private Instrutor instrutor;
    public Instrutor Instruto
    {
        get { return instrutor; }
        set { instrutor = Instruto; }
    }

}

