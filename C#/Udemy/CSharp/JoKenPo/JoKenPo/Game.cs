using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
	class Game
	{
		public enum Resultado
		{
			Ganhar, Perder, Empatar
		}

		public static Image[] images = //Inseri as imagens numa array
        {
			Image.FromFile("imagens/Pedra.png"),   //indice 0
            Image.FromFile("imagens/Tesoura.png"),  //indice 1
            Image.FromFile("imagens/Papel.png")   //indice 2
        };

		public Image ImgPC { get; private set; }
		public Image ImgJogador { get; private set; }

		public Resultado Jogar(int jogador)
		{
			int pc = JogadaPC();

			ImgJogador = images[jogador];  // Vincula as imagens a ambos jogadores, quando utiliza a jogada
			ImgPC = images[pc];

			if (jogador == pc)
			{
				return Resultado.Empatar;
			}
			else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))
			{
				return Resultado.Ganhar;
			}
			else
			{
				return Resultado.Perder;
			}

		}

		private int JogadaPC()  //Utiliza os milisegundos para decidir a jogada do PC
		{
			int mil = DateTime.Now.Millisecond;

			if (mil < 33)
			{
				return 0;
			}
			else if (mil >= 333 && mil < 667)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}
	}
}
