
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace KLAV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{	
			InitializeComponent();
     		synth.SetOutputToDefaultAudioDevice();  
     		synth.Volume = 100;
            pictureBox1.Image = botFunctions.Drawing("Привет!\nХочешь пройти тест? :-)", bmp);


        }
		
		SpeechSynthesizer synth = new SpeechSynthesizer();
		Bitmap bmp = new Bitmap("s.png");
        BotFunctions botFunctions = new BotFunctions("d.png", "b.txt");
        bool start = true;


		public void Synteses(string text)
		{
     		 synth.SpeakAsync(text);
		}
		
		void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
            if (vFlag.Checked)
            {
                vFlag.Text = "Голос ON";
                Synteses("Голос включен");
            }
            else
            {
                vFlag.Text = "Голос OFF";
                Synteses("Голос выключен");
            }
			
		}

        private void yes_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ImgAndS("Здорово!!!");
                timer1.Enabled = true;
                start = false;
            }
            else
            {
                Next("1");
            }

            


            
        }

        private void no_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ImgAndS("Встретимся позже..");
                start = false;
            }
            else
            {
                Next("0");
            }
           
        }

        /// <summary>
        /// Озвучка
        /// </summary>
        /// <param name="text"></param>
        void ImgAndS(string text)
        {
            pictureBox1.Image = botFunctions.Drawing(text, bmp);

            if (vFlag.Checked)
            Synteses(text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ImgAndS(botFunctions.Start());
            timer1.Enabled = false;
        }


        void Next(string str)
        {
            string str2 = botFunctions.Next(str);
            ImgAndS(str2);
        }
    }
}
