using System;
using System.Windows.Forms;

namespace CypherProgramm
{
    public partial class mainWindow : Form
    {
        private const int MinRandomRange = 1000;
        private const int MaxRandomRange = 10000;

        private Random random = new Random();
        private RSA rsa = new RSA();

        public mainWindow()
        {
            InitializeComponent();

            qField.Value = GetRandomValueIntoMinMaxRange();
            pField.Value = GetRandomValueIntoMinMaxRange();
        }

        #region Controll callbacks
        private void randomPButton_Click(object sender, EventArgs e)
        {
            pField.Value = GetRandomValueIntoMinMaxRange();
        }

        private void randomQButton_Click(object sender, EventArgs e)
        {
            qField.Value = GetRandomValueIntoMinMaxRange();
        }
        #endregion

        #region Random
        private int GetRandomValueIntoMinMaxRange()
        {
            var values = random.Next(MinRandomRange, MaxRandomRange);
            while (!IsPrime(values))
                values++;
            return values;
        }

        private bool IsPrime(int values)
        {
            for (var i = 2; i <= values / 2; i++)
                if (values % i == 0)
                    return false;
            return true;
        }
        #endregion

        private void encodeButton_Click(object sender, EventArgs e)
        {
            EncodeField();
        }

        private void EncodeField()
        {
            rsa.Initialize(pField.Value.ToString(), qField.Value.ToString());
            decodeText.Text = string.Join(" ", rsa.Encrypt(encodeText.Text));

            nField.Value = rsa.N;
            dField.Value = rsa.D;
            eField.Value = rsa.E;
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            DecodeField();
        }

        private void DecodeField ()
        {
            var enryptedMessage = decodeText.Text.Split(' ');
            encodeText.Text = rsa.Decrypt(enryptedMessage);
        }
    }
}
