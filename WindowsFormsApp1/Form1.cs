using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.DataFormats;

namespace WindowsFormsApp1
{

    // Не смог понять почему с дочерней формы на дочернюю и с родидельской на дочернюю
    // сообщения доходят только при обновлении формы.Виноват класс tmp а не я )))
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form Form_B = new Form();
            Form_B.Text = "Форма B";

            Button button_B_hi_A = new Button();
            Form_B.Controls.Add(button_B_hi_A);
            button_B_hi_A.Text = "Пивет А";
            button_B_hi_A.Click += BA_Click;

            Button button_B_hi_C = new Button();
            Form_B.Controls.Add(button_B_hi_C);
            button_B_hi_C.Location = new Point(70, 0);
            button_B_hi_C.Text = "Пивет C";
            button_B_hi_C.Click += BC_Click;


            TextBox text_B = new TextBox();
            Form_B.Controls.Add(text_B);
            text_B.Location = new Point(0, 30);
            text_B.Text = tmp._tmp;
            Form_B.Controls.Add(text_B);

            Form_B.Show();







            Form Form_C = new Form();
            Form_C.Text = "Форма C";

            Button button_C_hi_A = new Button();
            Form_C.Controls.Add(button_C_hi_A);
            button_C_hi_A.Text = "Привет А";
            button_C_hi_A.Click += CA_Click;

            Button button_С_hi_B = new Button();
            Form_C.Controls.Add(button_С_hi_B);
            button_С_hi_B.Location = new Point(70, 0);
            button_С_hi_B.Text = "Пивет B";
            button_С_hi_B.Click += CB_Click;

            TextBox text_C = new TextBox();
            Form_C.Controls.Add(text_C);
            text_C.Text = tmp._tmp2;
            text_C.Location = new Point(0, 30);
            Form_C.Controls.Add(text_C);

            Form_C.Show();

        }
       

        private void BC_Click(object sender, EventArgs e)
        {
            tmp._tmp2 = "Привет от В";
        }
        private void BA_Click(object sender, EventArgs e)
        {
            this.textBox1_A.Text = "Привет от формы B";
        }




        private void CB_Click(object sender, EventArgs e)
        {
            tmp._tmp = "Привет от C";
        }
        private void CA_Click(object sender, EventArgs e)
        {
            this.textBox1_A.Text = "Привет от формы C";

        }




        private void AC_Click(object sender, EventArgs e)
        {
            tmp._tmp2 = "Привет от A";
        }

        private void AB_Click(object sender, EventArgs e)
        {
            tmp._tmp = "Привет от A";
        }
    }
    
}
