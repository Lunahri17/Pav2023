using System;
using System.Windows.Forms;

namespace Cards
{
    public partial class MainView : Form
    {
        public const int NumHands = 4;
        private Pack _pack = null;
        private Hand[] _hands = new Hand[NumHands];

        public MainView()
        {
            InitializeComponent();
        }

        private void DealClick(object sender, EventArgs e)
        {
            try
            {
                _pack = new Pack();
                for (int handNum = 0; handNum < NumHands; handNum++)
                {
                    _hands[handNum] = new Hand();

                    for (int numCards = 0; numCards < Hand.HandSize; numCards++)
                    {
                        PlayingCard cardDealt = _pack.DealCardFromPack();
                        _hands[handNum].AddCardToHand(cardDealt);
                    }
                }

                north.Text = _hands[0].ToString();
                south.Text = _hands[1].ToString();
                east.Text = _hands[2].ToString();
                west.Text = _hands[3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
