using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
namespace QRCode_Proje
{
    public partial class Cozumle : Form
    {
        public Cozumle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QRCodeDecoder dnc = new QRCodeDecoder();
            textBox1.Text = dnc.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            openFileDialog1.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Tüm Dosyalar|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();

        }
    }
}
