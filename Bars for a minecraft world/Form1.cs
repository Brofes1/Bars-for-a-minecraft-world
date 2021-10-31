using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bars_for_a_minecraft_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int exitprogram = 0;
            InitializeComponent();
            string fileName = @"C:\Users\anims\OneDrive\Desktop\playerdata.txt";
            List<string> playerdata = new List<string>(System.IO.File.ReadAllLines(fileName));
            if (playerdata.Count == 0)
                for (int i = 0; i < 20; i++)
                    playerdata.Add("0");
            int currentprogress = int.Parse(playerdata[0]);
            progressBar1.Value = int.Parse(playerdata[1]);
            while (exitprogram == 0)
            {
                for (int i = currentprogress; i < 100; i++)
                {
                    Task.Delay(100);
                    currentprogress = i;
                }
                currentprogress = 0;
                progressBar1.Value = progressBar1.Value + 10;
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            while (0 == 0)
            {
            }
        }
        public static async Task WriteData()
        {
            
            await File.WriteAllLinesAsync("Stats Info.txt", playerdata);
        }
    }
}
