using System.Diagnostics.Eventing.Reader;

namespace WinForms26._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            cbsum.Enabled = true;
            cbsub.Enabled = false;


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbsub_CheckedChanged(object sender, EventArgs e)
        {
            cbsub.Enabled = true;
            cbsum.Enabled = false;


        }

        private void bt_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbsum.Enabled == true)
                {
                    double x = double.Parse(tbfirst.Text);
                    double y = double.Parse(tbsecond.Text);
                    double s = x + y;
                    tbres.Text = $" Результат {x} + {y} = {s}";
                    cbsub.Enabled = true;
                }
                else
                {
                    double x = double.Parse(tbfirst.Text);
                    double y = double.Parse(tbsecond.Text);
                    double s = x - y;
                    tbres.Text = $" Результат {x} - {y} = {s}";
                    cbsum.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbfirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void btclear_Click(object sender, EventArgs e)
        {
            cbsum.Enabled = true;
            cbsub.Enabled = true;
            tbfirst.Clear();
            tbsecond.Clear();
            tbres.Clear();
        }
    }


}

