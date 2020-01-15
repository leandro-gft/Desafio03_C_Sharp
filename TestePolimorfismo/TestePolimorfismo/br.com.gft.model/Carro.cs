using System;
using System.Collections.Generic;
using System.Text;

namespace TestePolimorfismo.br.com.gft.model
{
	class Carro : Veiculo
	{

		public Carro(String _marca, String _modelo, String _cor, float _km, bool _isLigado, int _litrosCombustivel,
				int _velocidade, Double _preco) : base(_marca, _modelo, _cor, _km, _isLigado, _litrosCombustivel, _velocidade, _preco)
		{
		}


		public override void acelerar()
		{
			if (IsLigado == true)
			{
				Velocidade += 20;
				LitrosCombustivel -= 1;
				Console.WriteLine("Você acelerou. A velocidade atual é de " + Velocidade + " quilometros por hora");
				Console.WriteLine("O carro tem " + LitrosCombustivel + " litros de combustível");
			}
			else
			{
				Console.WriteLine("Não é possivel acelerar com o carro desligado");
			}
		}

		public override void abastecer(int qtdLitros)
		{
			if (LitrosCombustivel >= 100)
			{
				LitrosCombustivel = 100;
			}
			else
			{
				LitrosCombustivel += qtdLitros;
				if (LitrosCombustivel >= 100)
				{
					LitrosCombustivel = 100;
				}
			}
			Console.WriteLine("Você abasteceu. O carro agora tem " + LitrosCombustivel + " litros de combustível");
		}

		public override void ligar()
		{
			if (IsLigado == true)
			{
				Console.WriteLine("O carro já está ligado");
			}
			else
			{
				IsLigado = true;
				Console.WriteLine("Você ligou o carro.");
			}
		}


		public override void desligar()
		{
			if (IsLigado == false)
			{
				Console.WriteLine("O carro está desligado");
			}
			else
			{
				IsLigado = false;
				Console.WriteLine("Você desligou o carro");
			}

		}

	}
}


