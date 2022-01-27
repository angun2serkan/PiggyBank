using marathon2.siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kumbara kumbara = new Kumbara();
        BozukPara bozukPara = new BozukPara();
        KagitPara kagitPara = new KagitPara();
        double kumbaradakiToplamParaHacmi;
        int kirilmaSayisi = 0;
        double paralarinHacmi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbParalar.Text = "-PARALAR-";
            cmbParalar.Items.AddRange(Enum.GetNames(typeof(ParaCesitleri)));
        }

        private void btnParaAt_Click(object sender, EventArgs e)
        {
            if (kumbaradakiToplamParaHacmi  < kumbara.Hacim)
            {
                string secilenPara = cmbParalar.Text;
                if (secilenPara == "BirKurus" || secilenPara == "BesKurus" || secilenPara == "OnKurus" || secilenPara == "YirmibesKurus" || secilenPara == "ElliKurus" || secilenPara == "BirLira")
                {
                    bozukPara.isim = (ParaCesitleri)cmbParalar.SelectedIndex;
                    kumbara.ParaEkle(bozukPara);
                    paralarinHacmi += bozukPara.Hacim;
                    kumbaradakiToplamParaHacmi = paralarinHacmi;
                    lblToplamHacim.Text = kumbaradakiToplamParaHacmi.ToString();
                }

                if (secilenPara == "BesLira" || secilenPara == "OnLira" || secilenPara == "YirmiLira" || secilenPara == "ElliLira" || secilenPara == "YuzLira" || secilenPara == "İkiyuzLira")
                {
                    kagitPara.isim = (ParaCesitleri)cmbParalar.SelectedIndex;
                    kumbara.ParaEkle(kagitPara);
                    paralarinHacmi += kagitPara.Hacim;
                    kumbaradakiToplamParaHacmi = paralarinHacmi;
                    lblToplamHacim.Text = kumbaradakiToplamParaHacmi.ToString();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(UyariKutuphanesi.KumbaraDoldu());
            }
        }

        private void btnSalla_Click(object sender, EventArgs e)
        {
            if (paralarinHacmi==0)
            {
                System.Windows.Forms.MessageBox.Show(UyariKutuphanesi.KumbaraSuanSallanamaz());
            }
            else
            {
                kumbara.Shake(kumbaradakiToplamParaHacmi);
                paralarinHacmi = kumbaradakiToplamParaHacmi - kumbara.ParaninFazlaHacmi;
                lblToplamHacim.Text = paralarinHacmi.ToString();
                MessageBox.Show(UyariKutuphanesi.HacimGenisletildi());
            }
            
        }

        private void btnKir_Click(object sender, EventArgs e)
        {
            lblToplamPara.Text = kumbara.Break().ToString();
            kirilmaSayisi++;

        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            if (kumbara.Durum == KumbaraDurumu.Kirik)
            {
                if (kirilmaSayisi<2)
                {
                    lblToplamPara.Text = "";
                    kumbara.Durum = KumbaraDurumu.Yapistirilmis;

                }
                else
                {
                    MessageBox.Show(UyariKutuphanesi.YapistirmaUyarisi());
                }
            }
            else
            {
                MessageBox.Show("Kumbara kırık değilken yapıştırılamaz");
            }
        }
    }
}
