using System;
using System.Collections.Generic;
using System.Text;

namespace TestePolimorfismo.br.com.gft.model
{
	class Aviao: Veiculo
	{

	public Aviao(String _marca, String _modelo, String _cor, float _km, bool _isLigado, int _LitrosCombustivel,
			int _Velocidade, Double _preco): base(_marca, _modelo, _cor, _km, _isLigado, _LitrosCombustivel, _Velocidade, _preco)
	{
		

	}

	
	public override void acelerar()
	{
		if (this.IsLigado == true)
		{
			this.Velocidade += 100;
			this.LitrosCombustivel -= 200;
			Console.WriteLine("Você acelerou. A Velocidade atual é de " + this.Velocidade + " quilometros por hora");
			Console.WriteLine("O avião tem " + this.LitrosCombustivel + " litros de combustível");
		}
		else
		{
			Console.WriteLine("Não é possivel acelerar com o avião desligado");
		}
	}

	public void abastecer(String qtdLitros)
	{
		int qtd = Convert.ToInt32(qtdLitros);
		if (this.LitrosCombustivel >= 300000)
		{
			this.LitrosCombustivel = 300000;
		}
		else
		{
			this.LitrosCombustivel += qtd;
			if (this.LitrosCombustivel >= 300000)
			{
				this.LitrosCombustivel = 300000;
			}
		}
		Console.WriteLine("Você abasteceu. O avião tem agora " + this.LitrosCombustivel + " litros de combustível");
	}

	
	public override void ligar()
	{
		if (this.IsLigado == true)
		{
			Console.WriteLine("O avião já está ligado");
		}
		else
		{
			this.IsLigado = true;
			Console.WriteLine("Você ligou o avião.");
		}
	}

	
	public override void desligar()
	{
		if (this.IsLigado == false)
		{
			Console.WriteLine("O avião está desligado");
		}
		else
		{
			this.IsLigado = false;
			Console.WriteLine("Você desligou o avião");
		}

	}

}
}
