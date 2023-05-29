using System;
using System.Windows.Forms;

namespace CypherProgramm
{
    public partial class mainWindow : Form
    {
        private const int MinRandomRange = 1000;
        private const int MaxRandomRange = 10000;
        private Random random;
        private RSA rsa;

        public mainWindow()
        {
            InitializeComponent();

            random = new Random();
            rsa = new RSA();

            qField.Value = GetRandomValueIntoMinMaxRange();
            pField.Value = GetRandomValueIntoMinMaxRange();
        }

        #region Controll callbacks
        private void encodeText_TextChanged(object sender, EventArgs e)
        {
            rsa.Initialize(pField.Value.ToString(), qField.Value.ToString());
            string[] enryptedMessage = rsa.Encrypt(encodeText.Text);
            decodeText.Text = string.Join(" ", enryptedMessage);

            nField.Value = rsa.N;
            dField.Value = rsa.D;
            eField.Value = rsa.E;
        }

        private void decodeText_TextChanged(object sender, EventArgs e)
        {
            string[] enryptedMessage = decodeText.Text.Split(' ');
            decodeText.Text = rsa.Decrypt(enryptedMessage);
        }

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
    }
}
