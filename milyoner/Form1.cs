using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milyoner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] cevaplar = {{"Mumbai","Kuala Lumpur","Yeni Delhi","Pekin"},{"Mavi","Yeşil","Kırmızı","Sarı"},  // [10,4]
        {"İzmir","İstanbul","Mersin","Bursa"},{"Avrupa","Asya","Afrika","Avrasya"},{"Fransa","İtalya","Belçika","İspanya"},
        {"12","5","8","23"},{"M","A","K","L"},{"Microsoft","Apple","Amazon","Coca Cola"},{"2","3","4","6"},
        {"Poseidon","Ares","Zeus","Artemis"} };
        int soruSayaci = 0;
        int satirArttirici = 0;
        int cevapArttirici = 0;
        int paraArttirici = 0;
        string[] sorular = { "Hindistan'ın başkenti neresidir?", "Gökkuşağının ortasındaki renk hangisidir?", "35 plakalı ilimiz hangisidir?",
        "Aşağıdakilerden hangisi bir kıta ismi belirtmez?","UEFA EURO 2020 şampiyonasını hangi ülke kazanmıştır?",
        "Üçün üç katından ikinin iki katı çıkarılırsa sonuç ne olur?","Türkçe'de kelimeler en çok hangi harfle başlar?",
        "2011 yılında vefat eden Steve Jobs hangi markanın CEO'luk görevini üstlenmiştir?","İnsan kalbi kaç odacıktan oluşmaktadır?",
        "Yunan mitolojisinde ''tanrıların tanrısı'' olarak bilinen tanrının adı nedir?"
        };
        string[] dogruCevaplar = { "Yeni Delhi", "Yeşil", "İzmir", "Avrasya", "İtalya", "5", "K", "Apple", "4", "Zeus" };


        private void button1_Click(object sender, EventArgs e)
        {
            soruSayaci++;
            satirArttirici++;
            if (cevap1Btn.Checked == true)
            {
                if (cevap1Btn.Text == dogruCevaplar[cevapArttirici])
                {
                    if (soruSayaci > 9)
                    {
                        label2.ForeColor = Color.Lime;
                        MessageBox.Show("Tebrikler! 1 Milyon TL'lik büyük ödüle ulaştınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }

                    else
                    {
                        MessageBox.Show("Tebrikler! Sonraki soru geliyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        soruLbl.Text = sorular[soruSayaci];

                        cevap1Btn.Text = cevaplar[satirArttirici, 0];
                        cevap2Btn.Text = cevaplar[satirArttirici, 1];
                        cevap3Btn.Text = cevaplar[satirArttirici, 2];
                        cevap4Btn.Text = cevaplar[satirArttirici, 3];
                        cevapArttirici++;
                        cevap1Btn.Checked = false;
                        paraArttirici++;
                    }

                }
                else
                {
                    if (paraArttirici == 0)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 0 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 1)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 1000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 2)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 5000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 3)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 10000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 4)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 15000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 5)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 30000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 6)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 60000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 7)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 100000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 8)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 250000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 9)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 500000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }


                }

            }
            else if (cevap2Btn.Checked == true)
            {
                if (cevap2Btn.Text == dogruCevaplar[cevapArttirici])
                {
                    if (soruSayaci > 9)
                    {
                        label2.ForeColor = Color.Lime;
                        MessageBox.Show("Tebrikler! 1 Milyon TL'lik büyük ödüle ulaştınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tebrikler! Sonraki soru geliyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        soruLbl.Text = sorular[soruSayaci];

                        cevap1Btn.Text = cevaplar[satirArttirici, 0];
                        cevap2Btn.Text = cevaplar[satirArttirici, 1];
                        cevap3Btn.Text = cevaplar[satirArttirici, 2];
                        cevap4Btn.Text = cevaplar[satirArttirici, 3];
                        cevapArttirici++;
                        cevap2Btn.Checked = false;
                        paraArttirici++;
                    }

                }
                else
                {
                    if (paraArttirici == 0)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 0 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 1)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 1000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 2)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 5000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 3)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 10000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 4)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 15000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 5)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 30000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 6)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 60000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 7)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 100000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 8)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 250000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 9)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 500000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                }

            }
            else if (cevap3Btn.Checked == true)
            {
                if (cevap3Btn.Text == dogruCevaplar[cevapArttirici])
                {
                    if (soruSayaci > 9)
                    {
                        label2.ForeColor = Color.Lime;
                        MessageBox.Show("Tebrikler! 1 Milyon TL'lik büyük ödüle ulaştınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tebrikler! Sonraki soru geliyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        soruLbl.Text = sorular[soruSayaci];

                        cevap1Btn.Text = cevaplar[satirArttirici, 0];
                        cevap2Btn.Text = cevaplar[satirArttirici, 1];
                        cevap3Btn.Text = cevaplar[satirArttirici, 2];
                        cevap4Btn.Text = cevaplar[satirArttirici, 3];
                        cevapArttirici++;
                        cevap3Btn.Checked = false;
                        paraArttirici++;
                    }

                }
                else
                {
                    if (paraArttirici == 0)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 0 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 1)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 1000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 2)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 5000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 3)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 10000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 4)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 15000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 5)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 30000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 6)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 60000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 7)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 100000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 8)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 250000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 9)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 500000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                }

            }
            else if (cevap4Btn.Checked == true)
            {

                if (cevap4Btn.Text == dogruCevaplar[cevapArttirici])
                {
                    if (soruSayaci > 9)
                    {
                        label2.ForeColor = Color.Lime;
                        MessageBox.Show("Tebrikler! 1 Milyon TL'lik büyük ödüle ulaştınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Tebrikler! Sonraki soru geliyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        soruLbl.Text = sorular[soruSayaci];

                        cevap1Btn.Text = cevaplar[satirArttirici, 0];
                        cevap2Btn.Text = cevaplar[satirArttirici, 1];
                        cevap3Btn.Text = cevaplar[satirArttirici, 2];
                        cevap4Btn.Text = cevaplar[satirArttirici, 3];
                        cevapArttirici++;
                        cevap4Btn.Checked = false;
                        paraArttirici++;
                    }
                    
                }

                else
                {
                    if (paraArttirici == 0)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 0 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 1)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 1000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 2)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 5000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 3)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 10000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 4)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 15000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 5)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 30000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 6)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 60000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 7)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 100000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 8)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 250000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                    else if (paraArttirici == 9)
                    {
                        MessageBox.Show("Maalesef yanlış cevap... 500000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Environment.Exit(0);
                    }
                }


            }
            else
            {
                MessageBox.Show("Sonraki soruya geçmeden önce lütfen bu soruyu cevaplayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (paraArttirici == 1)
            {
                label11.ForeColor = Color.Lime;
            }
            if (paraArttirici == 2)
            {
                label10.ForeColor = Color.Lime;
            }
            if (paraArttirici == 3)
            {
                label9.ForeColor = Color.Lime;
            }
            if (paraArttirici == 4)
            {
                label8.ForeColor = Color.Lime;
            }
            if (paraArttirici == 5)
            {
                label7.ForeColor = Color.Lime;
            }
            if (paraArttirici == 6)
            {
                label6.ForeColor = Color.Lime;
            }
            if (paraArttirici == 7)
            {
                label5.ForeColor = Color.Lime;
            }
            if (paraArttirici == 8)
            {
                label4.ForeColor = Color.Lime;
            }
            if (paraArttirici == 9)
            {
                label3.ForeColor = Color.Lime;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soruLbl.Visible = true;
            soruLbl.Text = sorular[soruSayaci];

            cevap1Btn.Visible = true;
            cevap2Btn.Visible = true;
            cevap3Btn.Visible = true;
            cevap4Btn.Visible = true;

            cevap1Btn.Text = cevaplar[0, 0];
            cevap2Btn.Text = cevaplar[0, 1];
            cevap3Btn.Text = cevaplar[0, 2];
            cevap4Btn.Text = cevaplar[0, 3];
            button2.Visible = false;
            button1.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çekilmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (paraArttirici == 0)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 0 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
                else if (paraArttirici == 1)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 1000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
                else if (paraArttirici == 2)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 5000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
                else if (paraArttirici == 3)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 10000 TL kazandınız!","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
                else if (paraArttirici == 4)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 15000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
                else if (paraArttirici == 5)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 30000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
                else if (paraArttirici == 6)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 60000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
                else if (paraArttirici == 7)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 100000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
                else if (paraArttirici == 8)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 250000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
                else if (paraArttirici == 9)
                {
                    MessageBox.Show("Yarışmadan çekildiniz ve 500000 TL kazandınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
            }
            else
            {
                
            }
        }
    }
}
