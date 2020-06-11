using BlackJack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BlackJack());
        }
    }




    public class Deck
    {
        static readonly Bitmap[,] Card = new Bitmap[4, 13];
        public Bitmap pic;
        static int v = 0;
        static int dc = 0, pc = 0;

        public Deck()
        {
        }

        public Deck(int n, Bitmap b)
        {
            if (n >= 1 && n < 9)
            {
                v = n + 1;
            }
            else if (n >= 9)
            {
                v = 10;
            }
            else 
            {
                if (pc + 11 > 21) v = 1;
                else v = 11;
            }
            pic = b;
        }      

        public void SetValue(int n)
        {
            if (n >= 1 && n< 9)
            {
                v = n + 1;
            }
            else if (n >= 9)
            {
                v = 10;
            }
            else 
            {
                if (pc + 11 > 21) v = 1;
                else v = 11;
            }
           
        }      

        public static void SetDeck()
        {
            ResourceManager rm = Resources.ResourceManager;

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    string c = "_" + (((i + 1) * 100) + (j + 1)).ToString();
                    Card[i, j] = (Bitmap)rm.GetObject(string.Format(c));

                }

            }
        }

        public int GetValue()
        {
            pc = pc + v;
            return pc;

        }

        public int GetDealerValue()
        {
            dc = dc + v;
            return dc;

        }


        public Bitmap this[int i, int j]
        {
            get
            {
                return Card[i, j];
            }
            set
            {
                Card[i, j] = value;
            }
        }
    }

}