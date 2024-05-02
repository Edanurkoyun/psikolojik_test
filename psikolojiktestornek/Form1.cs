using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psikolojiktestornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru = 0;
        int puan = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Sonraki";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            soru++;
            if(soru==1)
            {
                textBox1.Text = "Yeni bir deneyime girerken genellikle ne hissedersiniz?";
                button1.Text = "Heyecanlanırım";
                button2.Text = "Endişelenirim";
                button3.Text = "Merak Ederim";
                button4.Text = "Kaygılanırım";

            }
            if(soru==2)
            {
                textBox1.Text = "Bir grup insanla etkileşime geçtiğinizde, genellikle hangi rolü üstlenirsiniz?";
                button1.Text = "Liderlik rolü";
                button2.Text = "Arka planda kalmayı tercih ederim";
                button3.Text = "Tartışmaları yönlendiririm";
                button4.Text = "Diğerlerinin fikirlerini dinlemeyi tercih ederim";
            }
            if(soru==3)
            {
                textBox1.Text = "Stresli bir durumla karşılaştığınızda, genellikle nasıl tepki verirsiniz?";
                button1.Text = "Hemen çözüm aramaya başlarım";
                button2.Text = "Paniklerim";
                button3.Text = "Durumu değerlendirir ve sakin kalırım";
                button4.Text = "Diğerlerinden yardım isterim";
            }
            if (soru == 4)
            {
                textBox1.Text = "Yeni bir projeye başlarken, genellikle ne tür bir yaklaşım benimserdiniz?";
                button1.Text = "Detaylı bir plan hazırlarım ve adım adım ilerlerim";
                button2.Text = "Esnek bir plan yaparım ve duruma göre değişiklik yaparım";
                button3.Text = "Doğrudan eyleme geçerim ve detaylara çok fazla takılmam";
                button4.Text = "Başkalarının fikirlerini dinler ve onlara göre hareket ederim";
            }
            if (soru == 5)
            {
                textBox1.Text = "Zor bir karar vermeniz gerektiğinde, genellikle hangi faktörlere öncelik verirsiniz?";
                button1.Text = "Mantıklı ve akılcı çözümler";
                button2.Text = "Kişisel duygularım ve içsel hislerim";
                button3.Text = "Çevremdekilerin fikirleri ve etkileşimler";
                button4.Text = "Gelecekteki sonuçların değerlendirmesi";
            }
            if (soru == 6)
            {
                textBox1.Text = "Kendinizi en rahat hissettiğiniz ortam nasıldır?";
                button1.Text = "Sessiz ve sakin bir ortam";
                button2.Text = "Canlı ve hareketli bir ortam";
                button3.Text = "Doğa ile iç içe olan bir ortam";
                button4.Text = "İnsanlarla dolu ve sosyal bir ortam";
            }
            if (soru == 7)
            {
                textBox1.Text = "Bir problemle karşılaştığınızda, genellikle nasıl bir yaklaşım izlersiniz?";
                button1.Text = "Problemi sistematik bir şekilde analiz ederim ve çözüm yolları ararım";
                button2.Text = "Problemi bir süre unutur ve sonrasında çözüm bulmaya çalışırım";
                button3.Text = "Yakın çevremdeki kişilerden yardım alırım";
                button4.Text = "Problemi erteleyerek, doğal bir şekilde çözülmesini beklerim";
            }
            if(soru == 8)
            {
                textBox1.Text = "Hayatınızda çok önemli olduğunu düşündüğünüz bir hedefiniz var mı?";
                button1.Text = "Evet, belirli bir hedefim var ve ona ulaşmak için çalışıyorum";
                button2.Text = "İlgimi çeken birkaç hedefim var, ama net bir odak noktam yok";
                button3.Text = "Hedef belirlemek yerine, hayatın getirdiği fırsatları değerlendiriyorum";
                button4.Text = "Hedef koymaktan ziyade, anın tadını çıkarmayı tercih ediyorum";

            }
            if(soru==9)
            {
                textBox1.Text = "Yeni bir konsepti öğrenirken, genellikle hangi öğrenme yöntemini tercih edersiniz?";
                button1.Text = "Kitaplar ve yazılı kaynaklar aracılığıyla öğrenmeyi tercih ederim";
                button2.Text = "Pratik yaparak öğrenmeyi tercih ederim";
                button3.Text = "Görsel materyallerle öğrenmeyi tercih ederim";
                button4.Text = "Bir öğretmenden birebir öğrenmeyi tercih ederim";
            }
            if (soru == 10)
            {
                textBox1.Text = "Bir tartışma sırasında, genellikle nasıl bir tavır takınırsınız?";
                button1.Text = "Fikirlerimi net bir şekilde ifade eder ve savunurum";
                button2.Text = "Dinlerim ve diğerlerinin fikirlerini anlamaya çalışırım";
                button3.Text = "Tartışmadan kaçınırım ve konuyu değiştirmeye çalışırım";
                button4.Text = "Ortamı yumuşatır ve tartışmayı sakinleştirmeye çalışırım";
            }
            if (soru == 11)
            {
                textBox1.Text = "Testiniz Sona Ermiştir:)";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                label2.Text=puan.ToString();
                if(puan>=10 && puan <= 15)
                {
                    textBox1.Text = "Bu puan aralığındaki bir kişi genellikle sakin, dengeli ve düşünceli bir yapıya sahip olabilir. İçe dönük olabilir ve genellikle karmaşık durumlarda ve problem çözme süreçlerinde sabırlı ve mantıklı bir yaklaşım sergileyebilir. İletişimde daha içsel ve derin olabilirler.";

                }
                if(puan>=16 && puan <= 20)
                {
                    textBox1.Text = "Bu puan aralığındaki bir kişi, hem içe dönük hem de dışa dönük özellikleri dengeli bir şekilde sergileyebilir. Hem analitik düşünme becerilerine hem de empati yeteneğine sahip olabilirler. İnsanlarla etkileşimde bulunmaktan hoşlanabilir ve grup içinde uyum sağlama yetenekleri gelişmiş olabilir.";

                }
                if(puan>=21 && puan <= 25)
                {
                    textBox1.Text = "Bu puan aralığındaki bir kişi genellikle dışa dönük, enerjik ve liderlik özellikleri sergileyebilir. Kararlılıkla hareket ederken, başkalarının duygularını ve ihtiyaçlarını anlama yeteneğine sahip olabilirler. Grup içinde liderlik rolünü üstlenebilir ve insanları motive etme konusunda etkili olabilirler.";

                }
                if(puan>=26 && puan <= 30)
                {
                    textBox1.Text = "Bu puan aralığındaki bir kişi genellikle kararlı, motive edici ve liderlik vasıflarına sahip olabilir. Olaylara pozitif bir bakış açısına sahip olabilirler ve zorluklarla karşılaştıklarında bile iyimserliklerini koruyabilirler. Kararlılıkları ve enerjileriyle etraflarındaki insanları etkileyebilirler.";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puan = puan + 3;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = false;
            button5.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puan = puan + 1;
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            puan=puan + 2;
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            puan = puan + 1;
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL= "C:\\Users\\edanu\\Desktop\\emotional.mp3";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
