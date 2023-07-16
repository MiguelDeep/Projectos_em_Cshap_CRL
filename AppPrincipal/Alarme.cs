using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class Alarme : Form
    {
        private System.Timers.Timer tempo = new System.Timers.Timer();
        readonly SoundPlayer soundPlayer = new SoundPlayer();

        public Alarme()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            tempo.Interval = 1000;//intervalo de tempo
            tempo.Elapsed += Timer_Elapsed;
        }
     
        
        private void tempIniciado()
        {
            DateTime tempAtual = DateTime.Now;//pegando o tempo actual.
            DateTime temDigitado = dateTimePicker1.Value;
            if (tempAtual.Hour == temDigitado.Hour && tempAtual.Minute == temDigitado.Minute && tempAtual.Second == temDigitado.Second)
            {
                tempo.Stop();
                try
                {
                   soundPlayer.SoundLocation = "alarm-buzzer.wav";
                    soundPlayer.PlayLooping();
                }
                catch
                {
                    MessageBox.Show("Fim do tempo!!");
                }
            }
        }
    

        private void startButton_Click(object sender, EventArgs e)
        {
            tempo.Start();
            MessageBox.Show($"Tempo foi definido " + dateTimePicker1.Value.ToShortTimeString(), "Despertador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            startButton.Visible = false;
            stopButton.Visible = true;
        }

      

        private void stopButton_Click(object sender, EventArgs e)
        {
            tempo.Stop();//parando o tempo.
            soundPlayer.Stop();//parando o som.
            MessageBox.Show("Seu tempo chegou " + dateTimePicker1.Value.ToShortTimeString(), "Despertador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stopButton.Visible = false;
            startButton.Visible = true;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            tempIniciado();
        }

        private void Alarme_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            tempo.Stop();//parando o tempo.
            soundPlayer.Stop();//parando o som.
            MessageBox.Show("Seu tempo chegou " + dateTimePicker1.Value.ToShortTimeString(), "Despertador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stopButton.Visible = false;
            startButton.Visible = true;
        }
    }
}
