using ImageProcess2;
using System.ComponentModel;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;

namespace CoinsActivity
{
    public partial class Form1 : Form
    {
        Bitmap processedLoaded, loaded, processed;
        public Form1()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processedLoaded = new Bitmap(openFileDialog1.FileName);
            loaded = new Bitmap(processedLoaded);
            pbLoaded.Image = processedLoaded;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            processed = CoinCounter.ProcessCoin(loaded, 218);
            double amount = CoinCounter.CountCoins(processed);

            pbProcessed.Image = processed;
            lblCount.Text = "Total Amount: P" + amount.ToString();
        }
    }
}

