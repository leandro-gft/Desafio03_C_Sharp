using System;
using System.Collections.Generic;
using System.Text;

namespace TestePolimorfismo.br.com.gft.model
{
    abstract class Veiculo
    {
		public Veiculo(string _marca, string _modelo, string _cor, float _km, bool _isLigado,
			int _litrosCombustivel, int _velocidade, double _preco)
		{
			
			this.marca = _marca;
			this.modelo = _modelo;
			this.cor = _cor;
			this.km = _km;
			this.isLigado = _isLigado;
			this.litrosCombustivel = _litrosCombustivel;
			this.velocidade = _velocidade;
			this.preco = _preco;
		}

		private string marca;
		private string modelo;
		private string placa;
		private string cor;
		private float km;
		private bool isLigado;
		private int litrosCombustivel;
		private int velocidade;
		private double preco;

		public string Marca { get; set; }
		public string Modelo { get; set; }
		public string Placa { get; set; }
		public string Cor { get; set; }
		public float Km { get; set; }
		public bool IsLigado { get; set; }
		public int LitrosCombustivel { get; set; }
		public int Velocidade { get; set; }
		public double Preco { get; set; }

		public virtual void abastecer(int qtdLitros)
		{

		}
		public virtual void acelerar()
		{

		}
		public virtual void ligar()
		{

		}
		public virtual void desligar()
		{

		}

		
	}
}
