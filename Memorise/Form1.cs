using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<question> qlist = new List<question>();
        int page_min = 0;
        int page_no = 0;
        int page_max = 0;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = "txt";
            openFileDlg.ShowDialog();
            if (openFileDlg.FileName.Length > 0)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    this.text_path.Text = filename;
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(text_path.Text))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(text_path.Text);
                String line;

                int j = 0;
                int no = 1;
                question q = new question();
                while ((line = file.ReadLine()) != null)
                {
                    if (line == "")
                    {
                        if(q == null || (q.ans == "" && q.qus == ""))
                        {
                            continue;
                        }

                        j = 0;
                        qlist.Add(q);

                        q = null;
                        q = new question();
                    }
                    else if (j == 0)
                    {
                        q.no = no++;
                        q.ans = line;
                        j++;
                    }
                    else if (j == 1)
                    {
                        q.qus += line;
                    }
                }
                file.Close();

                text_min.Text = "0";
                text_no.Text = "0";
                text_max.Text = qlist.Count.ToString();

                page_min = 1;
                page_no = 0;
                page_max = qlist.Count;

                for (int i = 0; i < qlist.Count; i++)
                {
                    question temp = qlist[i];
                    int randomIndex = r.Next(page_max);
                    qlist[i] = qlist[randomIndex];
                    qlist[randomIndex] = temp;
                }
            }
            else
            {
                MessageBox.Show("그런 파일이 없습니다.");
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (page_no - 1 >= page_min)
            {
                page_no--;
                text_no.Text = page_no.ToString();
                text_goal.Visible = false;

                bool b = r.Next(100) > 20 && qlist[page_no - 1].qus != null;
                if (check_title.Checked)
                {
                    b = !b;
                }

                if (b)
                {
                    text_qus.Text = qlist[page_no - 1].qus;
                    text_goal.Text = qlist[page_no - 1].ans;
                }
                else
                {
                    text_qus.Text = qlist[page_no - 1].ans;
                    text_goal.Text = qlist[page_no - 1].qus;
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (page_no + 1 <= page_max)
            {
                page_no++;
                text_no.Text = page_no.ToString();
                text_goal.Visible = false;

                bool b = r.Next(100) > 10 && qlist[page_no - 1].qus != null;
                if (check_title.Checked)
                {
                    b = !b;
                }

                if (b)
                {
                    text_qus.Text = qlist[page_no - 1].qus;
                    text_goal.Text = qlist[page_no - 1].ans;
                }
                else
                {
                    text_qus.Text = qlist[page_no - 1].ans;
                    text_goal.Text = qlist[page_no - 1].qus;
                }
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            text_goal.Visible = false;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            text_goal.Visible = true;
        }

        private void text_goal_TextChanged(object sender, EventArgs e)
        {
            if(text_goal.Visible == true)
            {
                text_goal.Visible = false;
            }
            else
            {
                text_goal.Visible = true;
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("X.txt", true);

            file.WriteLine(qlist[page_no - 1].ans);
            file.WriteLine(qlist[page_no - 1].qus);
            file.WriteLine("");

            file.Close();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            qlist.Clear();
            page_no = 0;
            page_max = 0;

            text_qus.Text = "";
            text_goal.Text = "";
            text_max.Text = "0";
            text_no.Text = "";
        }
    }

    public class question
    {
        public String qus;
        public String ans;
        public int no;
    }
}
