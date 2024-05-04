using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wwwwwwwwwwwww
{
    public partial class frmMass : Form
    {
        public frmMass()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtm.Text = "";
            txtn.Text = "";
            txtRez.Text = "";
            dgvMass.Rows.Clear();
            dgvMass.Columns.Clear();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            int n, m, nn = 0;
            float summ = 0, sr = 0;
            n = Int32.Parse(txtn.Text);
            m = Int32.Parse(txtm.Text);
            int[,] A = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rnd.Next(-50, 50);
                }    
            }
            dgvMass.RowCount = n;
            dgvMass.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    dgvMass.Rows[i].Cells[j].Value = A[i, j];
                }
            }
            for (int j = 0; j < m; j++)
                dgvMass.Columns[j].Width = 50;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i,j] > 0)
                    {
                        summ = summ + A[i,j];
                        nn += 1;
                    }
                }
            }
            sr = summ / nn;
            txtRez.Text = "Середнє арефметичне = " + Math.Round(sr, 5).ToString() + Environment.NewLine + "Кількість позитивних елементів = " + nn.ToString();
        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
