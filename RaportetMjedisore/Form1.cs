using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaportetMjedisore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {


        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(700, 1000);
            tabPage2.Size = new Size(695, 990);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                this.Size = new Size(700, 1000);

                tabControl1.Size = new Size(700, 955);
            }
            else if (tabControl1.SelectedTab == tabPage1)
            {
                this.Size = new Size(630, 931);
                tabControl1.Size = new Size(607, 886);
            }
            else if (tabControl1.SelectedTab == tabPage6)
            {
                this.Size = new Size(1300, 931);
                tabControl1.Size = new Size(1274, 886);
            }
            
            //else if()

            //615, 889
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String txtKey = "Drenasi";
            List<String> txtKomunat = new List<string> {"Drenas", "Rruga Osman gjoka", "www.drenasiflet.com"};
            List<Label> labelat = new List<Label>() { lblKomuna, lblAddresaK, lblWeb };
            Dictionary<string, List<String>> komunat = new Dictionary<string, List<string>>();
            komunat.Add(txtKey, txtKomunat);
            int i = 0;
            
                foreach (var item in komunat[txtKey])
                {
                    labelat[i].Text = item;
                    i++;
                }
            
           

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
