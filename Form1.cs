using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using BlackJack.Properties;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class BlackJack : Form
    {
        ResourceManager resm = Resources.ResourceManager;
        int c;
        int cd;
        Random r = new Random();
        Deck d = new Deck();

        int i, j;

        public Image ImageLocation { get; private set; }

        public BlackJack()
        {
            InitializeComponent();
            GameOver.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = r.Next(0, 3);
            j = r.Next(0, 12);

            if (Dealer1.Image == null)
            {
                Deck DealOne = new Deck(j, d[i, j]);
                Dealer1.Image = DealOne.pic;
                Dealer1.Visible = true;

                d[i, j] = null;
                cd = DealOne.GetDealerValue();
                DealCountText.Text = cd.ToString();
            }

            if (Card1.Image == null)
            {
                if (d[i, j] == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);

                    Deck Uno = new Deck(j, d[i, j]);
                    Card1.Image = Uno.pic;
                    Card1.Visible = true;

                    d[i, j] = null;
                    c = Uno.GetValue();
                    CountText.Text = c.ToString();
                }

                else
                {
                    Deck Uno = new Deck(j, d[i, j]);
                    Card1.Image = Uno.pic;
                    Card1.Visible = true;

                    d[i, j] = null;
                    c = Uno.GetValue();
                    CountText.Text = c.ToString();
                }
            }

            else if (Card2.Image == null)
            {

                if (d[i, j] == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);

                    Deck Dos = new Deck(j, d[i, j]);
                    Card2.Image = Dos.pic;
                    Card2.Visible = true;

                    d[i, j] = null;
                    c = Dos.GetValue();
                    CountText.Text = c.ToString();
                }

                else
                {
                    Deck Dos = new Deck(j, d[i, j]);
                    Card2.Image = Dos.pic;
                    Card2.Visible = true;

                    d[i, j] = null;
                    c = Dos.GetValue();
                    CountText.Text = c.ToString();
                }
            }

            else if (Card3.Image == null)
            {
                if (d[i, j] == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);

                    Deck Tres = new Deck(j, d[i, j]);
                    Card3.Image = Tres.pic;
                    Card3.Visible = true;

                    d[i, j] = null;
                    c = Tres.GetValue();
                    CountText.Text = c.ToString();
                }
                else
                {
                    Deck Tres = new Deck(j, d[i, j]);
                    Card3.Image = Tres.pic;
                    Card3.Visible = true;

                    d[i, j] = null;
                    c = Tres.GetValue();
                    CountText.Text = c.ToString();
                }
            }

            else if (Card4.Image == null)
            {
                if (d[i, j] == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);

                    Deck Cuatro = new Deck(j, d[i, j]);
                    Card4.Image = Cuatro.pic;
                    Card4.Visible = true;

                    d[i, j] = null;
                    c = Cuatro.GetValue();
                    CountText.Text = c.ToString();
                }

                else
                {
                    Deck Cuatro = new Deck(j, d[i, j]);
                    Card4.Image = Cuatro.pic;
                    Card4.Visible = true;

                    d[i, j] = null;
                    c = Cuatro.GetValue();
                    CountText.Text = c.ToString();
                }
            }

            else if (Card5.Image == null)
            {
                if (d[i, j] == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);

                    Deck Cinco = new Deck(j, d[i, j]);
                    Card5.Image = Cinco.pic;
                    Card5.Visible = true;

                    d[i, j] = null;
                    c = Cinco.GetValue();
                    CountText.Text = c.ToString();
                }
                else
                {
                    Deck Cinco = new Deck(j, d[i, j]);
                    Card5.Image = Cinco.pic;
                    Card5.Visible = true;

                    d[i, j] = null;
                    c = Cinco.GetValue();
                    CountText.Text = c.ToString();
                }
            }

            else if (Card6.Image == null)
            {
                if (d[i, j] == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);

                    Deck Seis = new Deck(j, d[i, j]);
                    Card6.Image = Seis.pic;
                    Card6.Visible = true;

                    d[i, j] = null;
                    c = Seis.GetValue();
                    CountText.Text = c.ToString();
                }
                else
                {
                    Deck Seis = new Deck(j, d[i, j]);
                    Card6.Image = Seis.pic;
                    Card6.Visible = true;

                    d[i, j] = null;
                    c = Seis.GetValue();
                    CountText.Text = c.ToString();
                }
            }

            else if (Card7.Image == null)
            {
                if (d[i, j] == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);

                    Deck Siete = new Deck(j, d[i, j]);
                    Card7.Image = Siete.pic;
                    Card7.Visible = true;

                    d[i, j] = null;
                    c = Siete.GetValue();
                    CountText.Text = c.ToString();
                }

                else
                {
                    Deck Siete = new Deck(j, d[i, j]);
                    Card7.Image = Siete.pic;
                    Card7.Visible = true;

                    d[i, j] = null;
                    c = Siete.GetValue();
                    CountText.Text = c.ToString();
                }
            }

            else if (Card8.Image == null)
            {
                if (d[i, j] == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);

                    Deck Ocho = new Deck(j, d[i, j]);
                    Card8.Image = Ocho.pic;
                    Card8.Visible = true;

                    d[i, j] = null;
                    c = Ocho.GetValue();
                    CountText.Text = c.ToString();
                }

                else
                {
                    Deck Ocho = new Deck(j, d[i, j]);
                    Card8.Image = Ocho.pic;
                    Card8.Visible = true;

                    d[i, j] = null;
                    c = Ocho.GetValue();
                    CountText.Text = c.ToString();
                }
            }

            if (c > 21)
            {
                GameOver.Image = (Bitmap)resm.GetObject("DEFEAT");
                GameOver.Visible = true;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            global::BlackJack.Deck.SetDeck();
            c = 0;
            cd = 0;
            DealCountText.Text = null;
            CountText.Text = null;
            Deck.Enabled = true;
            Card1.Visible = false;
            Card2.Visible = false;
            Card3.Visible = false;
            Card4.Visible = false;
            Card5.Visible = false;
            Card6.Visible = false;
            Card7.Visible = false;
            Card8.Visible = false;
            Card1.Image = null;
            Card2.Image = null;
            Card3.Image = null;
            Card4.Image = null;
            Card5.Image = null;
            Card6.Image = null;
            Card7.Image = null;
            Card8.Image = null;
            Dealer1.Visible = false;
            Dealer2.Visible = false;
            Dealer3.Visible = false;
            Dealer4.Visible = false;
            Dealer5.Visible = false;
            Dealer6.Visible = false;
            Dealer7.Visible = false;
            Dealer8.Visible = false;
            Dealer1.Image = null;
            Dealer2.Image = null;
            Dealer3.Image = null;
            Dealer4.Image = null;
            Dealer5.Image = null;
            Dealer6.Image = null;
            Dealer7.Image = null;
            Dealer8.Image = null;
            Start.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            Deck.Enabled = false;
            DealerGetCards: while (cd <= 16)
            {
                if (Dealer2.Image == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);
                    while (d[i, j] == null)
                    {
                        i = r.Next(0, 3);
                        j = r.Next(0, 12);
                    }

                    Deck DealTwo = new Deck(j, d[i, j]);
                    Dealer2.Image = DealTwo.pic;
                    Dealer2.Visible = true;

                    d[i, j] = null;
                    cd = DealTwo.GetDealerValue();
                    DealCountText.Text = cd.ToString();

                    goto DealerGetCards;
                }

                else if (Dealer3.Image == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);
                    while (d[i, j] == null)
                    {
                        i = r.Next(0, 3);
                        j = r.Next(0, 12);
                    }

                    Deck DealThree = new Deck(j, d[i, j]);
                    Dealer3.Image = DealThree.pic;
                    Dealer3.Visible = true;

                    d[i, j] = null;
                    cd = DealThree.GetDealerValue();
                    DealCountText.Text = cd.ToString();

                    goto DealerGetCards;
                }
                else if (Dealer4.Image == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);
                    while (d[i, j] == null)
                    {
                        i = r.Next(0, 3);
                        j = r.Next(0, 12);
                    }

                    Deck DealFour = new Deck(j, d[i, j]);
                    Dealer4.Image = DealFour.pic;
                    Dealer4.Visible = true;

                    d[i, j] = null;
                    cd = DealFour.GetDealerValue();
                    DealCountText.Text = cd.ToString();

                    goto DealerGetCards;
                }
                else if (Dealer5.Image == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);
                    while (d[i, j] == null)
                    {
                        i = r.Next(0, 3);
                        j = r.Next(0, 12);
                    }

                    Deck DealFive = new Deck(j, d[i, j]);
                    Dealer5.Image = DealFive.pic;
                    Dealer5.Visible = true;

                    d[i, j] = null;
                    cd = DealFive.GetDealerValue();
                    DealCountText.Text = cd.ToString();

                    goto DealerGetCards;
                }
                else if (Dealer6.Image == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);
                    while (d[i, j] == null)
                    {
                        i = r.Next(0, 3);
                        j = r.Next(0, 12);
                    }

                    Deck DealSix = new Deck(j, d[i, j]);
                    Dealer6.Image = DealSix.pic;
                    Dealer6.Visible = true;

                    d[i, j] = null;
                    cd = DealSix.GetDealerValue();
                    DealCountText.Text = cd.ToString();

                    goto DealerGetCards;
                }
                else if (Dealer7.Image == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);
                    while (d[i, j] == null)
                    {
                        i = r.Next(0, 3);
                        j = r.Next(0, 12);
                    }

                    Deck DealSeven = new Deck(j, d[i, j]);
                    Dealer7.Image = DealSeven.pic;
                    Dealer7.Visible = true;

                    d[i, j] = null;
                    cd = DealSeven.GetDealerValue();
                    DealCountText.Text = cd.ToString();

                    goto DealerGetCards;
                }
                else if (Dealer8.Image == null)
                {
                    i = r.Next(0, 3);
                    j = r.Next(0, 12);
                    while (d[i, j] == null)
                    {
                        i = r.Next(0, 3);
                        j = r.Next(0, 12);
                    }

                    Deck DealEight = new Deck(j, d[i, j]);
                    Dealer8.Image = DealEight.pic;
                    Dealer8.Visible = true;

                    d[i, j] = null;
                    cd = DealEight.GetDealerValue();
                    DealCountText.Text = cd.ToString();

                    goto DealerGetCards;
                }

            }

            if (cd <= 21)
            {

                if (cd > c)
                {
                    GameOver.Image = (Bitmap)resm.GetObject("DEFEAT");
                    GameOver.Visible = true;
                }
                else if (cd == c)
                {
                    GameOver.Image = (Bitmap)resm.GetObject("GameOver");
                    GameOver.Visible = true;
                }
                else
                {
                    GameOver.Image = (Bitmap)resm.GetObject("VICTORY");
                    GameOver.Visible = true;
                }
            }
            else
            {
                GameOver.Image = (Bitmap)resm.GetObject("VICTORY");
                GameOver.Visible = true;
            }

        }
    }
}
