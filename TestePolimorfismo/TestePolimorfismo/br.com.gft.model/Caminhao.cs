using System;
using System.Collections.Generic;
using System.Text;

namespace TestePolimorfismo.br.com.gft.model
{
	class Caminhao : Veiculo
	{

		public Caminhao(String _marca, String _modelo, String _cor, float _km, bool _isLigado, int _litrosCombustivel,
				int _velocidade, Double _preco) : base(_marca, _modelo, _cor, _km, _isLigado, _litrosCombustivel, _velocidade, _preco)
		{
		}


		public override void acelerar()
		{
			if (IsLigado == true)
			{
				Velocidade += 20;
				LitrosCombustivel -= 50;
				Console.WriteLine("Você acelerou. A velocidade atual é de " + Velocidade + " quilometros por hora");
				Console.WriteLine("O caminhão tem " + LitrosCombustivel + " litros de combustível");
			}
			else
			{
				Console.WriteLine("Não é possivel acelerar com o caminhão desligado");
			}
		}

		public void abastecer(float qtdLitros)
		{
			int qtd = Convert.ToInt32(qtdLitros);

			if (LitrosCombustivel >= 15000)
			{
				LitrosCombustivel = 15000;
			}
			else
			{
				LitrosCombustivel += qtd;
				if (LitrosCombustivel >= 15000)
				{
					LitrosCombustivel = 15000;
				}
			}
			Console.WriteLine("Você abasteceu. O caminhão agora tem " + LitrosCombustivel + " litros de combustível");
		}

		public override void ligar()
		{
			if (IsLigado == true)
			{
				Console.WriteLine("O caminhão já está ligado");
			}
			else
			{
				IsLigado = true;
				Console.WriteLine("Você ligou o caminhão.");
			}
		}


		public override void desligar()
		{
			if (IsLigado == false)
			{
				Console.WriteLine("O caminhão está desligado");
			}
			else
			{
				IsLigado = false;
				Console.WriteLine("Você desligou o caminhão");
			}

		}

	}
}
