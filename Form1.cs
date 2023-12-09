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

namespace QRCode_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Dosyası|*.png|JPEG Dosyası|*.jpg;*.jpeg|Bitmap Dosyası|*.bmp|GIF Dosyası|*.gif";
                saveFileDialog.Title = "QR Kaydet";
                saveFileDialog.FileName = "QRKod"; // Varsayılan dosya adı
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // PictureBox'taki görseli seçilen dosyaya kaydetme
                    string filePath = saveFileDialog.FileName;
                    pictureBox1.Image.Save(filePath);

                    MessageBox.Show("Görsel başarıyla kaydedildi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen önce QR Kod oluşturun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            Cozumle cozumle = new Cozumle();
            cozumle.Show();
            this.Hide();
        }
    }
}
