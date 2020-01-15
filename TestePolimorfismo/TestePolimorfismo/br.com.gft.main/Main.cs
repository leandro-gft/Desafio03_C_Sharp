using System;
using TestePolimorfismo.br.com.gft.model;

namespace TestePolimorfismo
{
    class main
    {
        static void Main(string[] args)
        {
			Carro c1 = new Carro("Fiat", "Palio", "Azul", 1000, false, 0, 0, 20000.0);
			Aviao a1 = new Aviao("Boeing", "747", "Vermelho", 1000000, false, 0, 0, 3500000.0);
			Caminhao cam1 = new Caminhao("Volvo", "FH400", "Verde", 10000, false, 0, 0, 50000.0);

			Console.WriteLine("Apresentando métodos do carro: ");
			c1.ligar();
			c1.abastecer(50);
			c1.acelerar();
			c1.acelerar();
			c1.acelerar();
			c1.acelerar();
			c1.abastecer(10);
			c1.desligar();
			Console.WriteLine();
			Console.WriteLine("Apresentando métodos do avião: ");
			a1.ligar();
			a1.abastecer("100000");
			a1.acelerar();
			a1.acelerar();
			a1.acelerar();
			a1.acelerar();
			a1.abastecer("50000");
			a1.desligar();
			Console.WriteLine();
			Console.WriteLine("Apresentando métodos do caminhão: ");
			cam1.ligar();
			cam1.abastecer(1000f);
			cam1.acelerar();
			cam1.acelerar();
			cam1.acelerar();
			cam1.acelerar();
			cam1.abastecer(500f);
			cam1.desligar();
			Console.ReadKey();
		}
    }
}
