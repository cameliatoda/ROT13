namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string mesaj_necriptat;
        string mesaj_criptat;
        string mesaj_decriptat;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesaj_necriptat = textBox1.Text;
            mesaj_criptat = "";
            for (int i = 0; i < mesaj_necriptat.Length; i++)
            {
                if (mesaj_necriptat[i] == ' ')
                    mesaj_criptat += ' ';
                if (mesaj_necriptat[i] >= 'A' && mesaj_necriptat[i] <= 'Z')
                {
                    mesaj_criptat += (char)
                        ((((mesaj_necriptat[i] - 'A') + 13) % 26) + 'A');
                }
                textBox2.Text = mesaj_criptat;
                if (mesaj_necriptat[i] >= 'a' && mesaj_necriptat[i] <= 'z')
                {
                    mesaj_criptat += (char)
                        ((((mesaj_necriptat[i] - 'a') + 13) % 26) + 'a');
                }
                textBox2.Text = mesaj_criptat;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            mesaj_decriptat = "";
            for (int i = 0; i < mesaj_criptat.Length; i++)
            {
                if (mesaj_criptat[i] == ' ')
                    mesaj_decriptat += ' ';
                else if (mesaj_criptat[i] >= 'A' && mesaj_criptat[i] <= 'Z')
                {
                    int t = mesaj_criptat[i] - 'A' - 13;
                    if (t < 0)
                    {
                        t = 26 + t;

                    }
                    mesaj_decriptat += (char)(t + 'A');

                }
                else if (mesaj_criptat[i] >= 'a' && mesaj_criptat[i] <= 'z')
                {
                    int t = mesaj_criptat[i] - 'a' - 13;
                    if (t < 0)
                    {
                        t = 26 + t;

                    }
                    mesaj_decriptat += (char)(t + 'a');

                }


                textBox3.Text = mesaj_decriptat;

            }

        }
    }
    
}