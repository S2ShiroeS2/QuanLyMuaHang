using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    static class UIBuilder
    {
        static Color color= Color.FromArgb(192, 255, 255);
        public static void Border(Form form)
        {
            int width = 1;
            Color color = UIBuilder.color;
            Panel pnBd1 = new Panel();
            pnBd1.Width = form.Width;
            pnBd1.Height = width;
            pnBd1.BackColor = color;
            pnBd1.Location = new Point(0, 0);

            Panel pnBd2 = new Panel();
            pnBd2.Width = form.Width;
            pnBd2.Height = width;
            pnBd2.BackColor = color;
            pnBd2.Location = new Point(0, form.Height - width);

            Panel pnBd3 = new Panel();
            pnBd3.Width = width;
            pnBd3.Height = form.Height;
            pnBd3.BackColor = color;
            pnBd3.Location = new Point(0, 0);

            Panel pnBd4 = new Panel();
            pnBd4.Width = width;
            pnBd4.Height = form.Height;
            pnBd4.BackColor = color;
            pnBd4.Location = new Point(form.Width - width, 0);

            form.Controls.Add(pnBd1);
            form.Controls.Add(pnBd2);
            form.Controls.Add(pnBd3);
            form.Controls.Add(pnBd4);
        }


        public static void RenderButton(Form form)
        {
            int size = 35;
            //UIBuilder.form = form;

            Button bt1 = new Button();
            bt1.Text = "X";
            bt1.Width = size;
            bt1.Height = size;
            bt1.Location = new Point(form.Width - size, -1);
            bt1.FlatStyle = FlatStyle.Flat;
            bt1.Click += Bt1_Click;

            Button bt2 = new Button();
            bt2.Text = "_";
            bt2.Width = size;
            bt2.Height = size;
            bt2.FlatStyle = FlatStyle.Flat;
            bt2.Location = new Point(form.Width - size * 2+1, -1);
            bt2.Click += Bt2_Click;

            form.Controls.Add(bt1);
            form.Controls.Add(bt2);
        }

        private static void Bt2_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            Form form = bt.Parent as Form;
            form.WindowState = FormWindowState.Minimized; 
            //UIBuilder.form.WindowState = FormWindowState.Minimized;
        }

        private static void Bt1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            Form form = bt.Parent as Form;
            form.Close();
            //UIBuilder.form.Close();
        }
    }
}
