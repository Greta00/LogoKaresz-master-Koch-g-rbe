using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */
		void Koch_fraktál(int év, double méret)
        {
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
            {
				Koch_fraktál(év - 1, méret / 3);
				Balra(60);
				Koch_fraktál(év - 1, méret / 3);
				Jobbra(120);
				Koch_fraktál(év - 1, méret / 3);
				Balra(60);
				Koch_fraktál(év - 1, méret / 3);
			}
        }
		void Hópehely(int év, double méret)
        {
            for (int i = 0; i < 6; i++)
            {
				Koch_fraktál(év, méret);
				Jobbra(60);
            }
        }

		void Töröttvonal(int év, double méret)
        {
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				Balra(30);
				Töröttvonal(év - 1, méret / 3);
				Jobbra(60);
				Töröttvonal(év - 1, méret / 3);
				Balra(60);
				Töröttvonal(év - 1, méret / 3);
				Jobbra(30);
			}
		}
		void Törött_háromszög(int év, double méret)
        {
            for (int i = 0; i < 3; i++)
            {
				Töröttvonal(év, méret);
				Jobbra(120);
            }
			
        }
		void Görbe(int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				Jobbra(90);
				Görbe(év - 1, méret / 2);
				Balra(90);
				Görbe(év - 1, méret);
				Balra(90);
				Görbe(év - 1, méret / 2);
				Jobbra(90);
			}
		}
		
		void Szigetvonal(int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				Szigetvonal(év - 1, méret / 5);
				Jobbra(60);
				Szigetvonal(év - 1, méret / 5);
				Balra(120);
				Szigetvonal(év - 1, méret / 5);
				Szigetvonal(év - 1, méret / 5);
				Jobbra(120);
				Szigetvonal(év - 1, méret / 5);
			}
		}
		void Sziget(int év, double méret, int oldal)
		{
			for (int i = 0; i < oldal; i++)
			{
				Szigetvonal(év, méret);
			}

		}

		void Nyílhegy (int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				if (év % 2 != 0)
                {
                    for (int i = 0; i < év/2; i++)
                    {
					Jobbra(30);
					Nyílhegy(év - 1, méret / év);
					Jobbra(60);
					Nyílhegy(év - 1, méret / év);
					Jobbra(60);
					Nyílhegy(év - 1, méret / év);
					Balra(30);
						Jobbra(90);
						Nyílhegy(év - 1, méret / év);
						Balra(60);
						Nyílhegy(év - 1, méret / év);
						Balra(60);
						Nyílhegy(év - 1, méret / év);
						Jobbra(30);
					}
					Jobbra(30);
					Nyílhegy(év - 1, méret / év);
					Jobbra(60);
					Nyílhegy(év - 1, méret / év);
					Jobbra(60);
					Nyílhegy(év - 1, méret / év);
					Balra(30);
				}
                else
                {
					Jobbra(90);
					Nyílhegy(év - 1, méret / év);
					Balra(60);
					Nyílhegy(év - 1, méret / év);
					Balra(60);
					Nyílhegy(év - 1, méret / év);
					Jobbra(30);
				}
			}
			
		}
		void fra(int év, double méret)
        {
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				fra(év - 1, méret / 2);
				Jobbra(72);
				fra(év - 1, méret / 2);
				Balra(144);
				fra(év - 1, méret / 2);
				Balra(72);
				fra(év - 1, méret / 2);
				Jobbra(72);
				fra(év - 1, méret / 2);
				Jobbra(72);
				fra(év - 1, méret / 2);
				
			}
		}
		void fra5(int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
				Jobbra(72);
				Előre(méret);
				Jobbra(72);
				Előre(méret);
				Jobbra(72);
				Előre(méret);
				Jobbra(72);
				Előre(méret);
				Jobbra(72);
				Előre(méret);
				Jobbra(72);
			}
			else if (év > 1)
			{
				if (év == 1)
                {
					for (int i = 0; i < 5; i++)
					{
					fra(év - 1, méret / 2);
					Jobbra(72);
					fra(év - 1, méret / 2);
					Balra(144);
					fra(év - 1, méret / 2);
					Balra(72);
					fra(év - 1, méret / 2);
					Jobbra(72);
					fra(év - 1, méret / 2);
					Jobbra(72);
					fra(év - 1, méret / 2);
					Jobbra(72);
					}
                }
                else
                {
					Balra(144);
                    for (int i = 0; i < év; i++)
                    {
						for (int j = 0; j < 5; j++)
				{
					fra(év - 1, méret / 2);
					Jobbra(72);
					fra(év - 1, méret / 2);
					Balra(144);
					fra(év - 1, méret / 2);
					Balra(72);
					fra(év - 1, méret / 2);
					Jobbra(72);
					fra(év - 1, méret / 2);
					Jobbra(72);
					fra(év - 1, méret / 2);
					Jobbra(72);
				}
				Tollat(fel);
				Jobbra(72);
				Előre(méret / 2);
				Balra(36);
				Előre(méret / 2);
				Jobbra(72);
				Előre(méret / 2);
				Balra(72);
                }
                    }
				
                
				
			}
		}
		/* Függvények vége */
		void FELADAT()
		{
			/* Ezt indítja a START gomb! */
			Teleport(közép.X-150, közép.Y, észak);
			using (new Frissítés(false))
            {
            }
			fra5(5, 50);
			
				
		}
	}
}
