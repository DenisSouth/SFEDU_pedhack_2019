/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 26.04.2019
 * Время: 15:27
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.IO;
using AI;

namespace KLAV
{
	/// <summary>
	/// Description of BotFunctions.
	/// </summary>
	public class BotFunctions
	{
        Image dial;
        string[] botData;
        int qN = 0;
        Vector vect = new Vector(3);

		public BotFunctions(string pathD, string pathBot)
		{
            dial = new Bitmap(pathD);
            botData = File.ReadAllLines(pathBot);
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Stand(string input)
        {
            string output = input.ToLower();

            while (output.Contains("  "))
            {
                output = output.Replace("  "," ");
            }

                output = output.Replace("4", "ч").Replace("!", "").Replace("?", "")
                .Replace("}{", "х").Replace("}|{", "ж").Replace("%", "").Replace(".", "")
                .Replace(";", "").Replace("_", " ").Replace("-", " ").Replace("c", "с")
                .Replace("a", "а").Replace("p", "р").Replace("y", "у").Replace(")", "")
                .Replace("(", "").Replace("{", "").Replace("}", "").Replace("[", "")
                .Replace("]", "").Replace("^", "")
                .Replace(",", "").Replace("*", "").Replace("@", "");

            return output;
        }
		
		public Bitmap Drawing(string text, Bitmap startImg)
		{
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            int countN = 0;
            

            if (text.Length > 10)
            {
                for (int i = 0, k = 0; i < text.Length; i++)
                {
                    k++;
                    if (k > 20 && text[i] == ' ')
                    {
                        text = text.Insert(i, "\n");
                        k = 0;
                        countN++;
                    }
                }
            }

            Bitmap endImg = new Bitmap(startImg, 660, 468);
			Graphics gr = Graphics.FromImage(endImg);

            if (text.Length > 10)
                gr.DrawImage(dial, 200, 130, (float)(200 + 4.5 * text.Length-40*countN), 113+12*countN);
            else
                gr.DrawImage(dial, 200, 130);

            gr.DrawString(text, drawFont, drawBrush, (float)(230+ text.Length), 160);

			return endImg;
		}

        public string Start()
        {
            qN += 2;
            return botData[0];
        }

        public string Next(string str)
        {
            try
            {
                string nS = botData[qN];

                if (nS != "end")
                {

                    if (str == botData[qN - 1].Split(';')[0])
                        vect += new Vector(botData[qN - 1].Split(';')[1].Split(' '));

                    qN += 2;
                    return nS;
                }

                string str2;
                int a = vect.IndexMax();

                if (a == 0)
                    str2 = "Визуал";
                else if (a == 1)
                {
                    str2 = "Аудиал";
                }
                else
                    str2 = "Кинестет";

                vect /= vect.Sum();
                vect *= 100;

                File.WriteAllText("data.d", vect.DataInVector.Transform(x => Math.Round(x, 3)).ToStr("% "));

                return str2;
            }

            catch
            {
                string str2;
                int a = vect.IndexMax();

                if (a == 0)
                    str2 = "Визуал";
                else if (a == 1)
                {
                    str2 = "Аудиал";
                }
                else
                    str2 = "Кинестет";

                vect /= vect.Sum();
                vect *= 100;

                File.WriteAllText("data.d", vect.DataInVector.Transform(x => Math.Round(x, 3)).ToStr("% "));

                return str2;
            }
            
        }
		
	}
}
