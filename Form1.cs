using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace files
{
    public partial class Form1 : Form
    {
        static string pathSave = Application.StartupPath + @"\text.txt";
        string path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(pathSave);
            File.AppendAllText(pathSave, textBox1.Text);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Process.Start(pathSave);
            textBox1.Text = String.Empty;
            openDial.ShowDialog();
            string openPath = openDial.FileName;
            if (File.Exists(openPath))
            {
                textBox1.Text = File.ReadAllText(openPath);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveAsDial.ShowDialog();
            path = saveAsDial.FileName;
            
            File.AppendAllText(path, textBox1.Text);
        }
    }
}
