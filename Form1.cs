using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaratProject
{
    public partial class Form1 : Form
    {
        public static int cnt = 0;
        public Point panelLockation = new Point(28, 150);
        public int a;
        public int b;

        public Form1()
        {
            InitializeComponent();
            FormSets();
            SetChanges();
        }

        public void FormSets()
        {
            this.BackColor = Color.FromArgb(212, 217, 202);
            mainPanel.BackColor = Color.White;//FromArgb(183, 178, 172);
            getDataPanel.BackColor = Color.White;//FromArgb(183, 178, 172);
            answerPanel.BackColor = Color.White;//FromArgb(183, 178, 172);
            boldLabel.Text = "Реализация умножения и деления в разрядной сетке";
            this.Size = new Size(756, 474);
        }


        private void SetChanges()
        {
            if(cnt == 1)
            {
                howWorkPanel.Visible = false;
                getDataPanel.Visible = true;
                getDataPanel.Location = panelLockation;
            }
            if(cnt==2)
            {
                try
                {
                    a = int.Parse(multiplicandTextBox.Text);
                    b = int.Parse(multiplierTextBox.Text);
                    
                }
                catch 
                {
                    MessageBox.Show("Иронау огурец куыд у?");
                    cnt--;
                }
            }
            if (cnt == 3) 
            {
                getDataPanel.Visible = false;
                answerPanel.Location = panelLockation;
                answerLabel.Text = Convert.ToString(a * b);
            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
            cnt++;
            SetChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
