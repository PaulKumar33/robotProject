using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp1
{
    public partial class FilterDebug : Form
    {
        public FilterDebug()
        {
            InitializeComponent();

            //Image lpfImage = new Image()
        }

        private void PopulateListbox()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox1.BeginUpdate();

            listBox1.Items.Add("Sallen Key Lowpass Filter");
            listBox1.Items.Add("Sallen Key Highpass Filter");
            listBox1.Items.Add("Band-stop Filter");
            listBox1.Items.Add("Notch Filter");

            listBox1.EndUpdate();
        }

        private void FilterDebug_Load(object sender, EventArgs e)
        {
            PopulateListbox();
            CapBox.Hide();
            ResistorBox.Hide();
            equalCheck.Hide();
            orderUpDown.Hide();
        }        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = listBox1.SelectedItem.ToString();
            if(item == "Sallen Key Lowpass Filter")
            {            
                CapBox.Show();
                ResistorBox.Show();
                ResistorBox.Text = "LPF Resistor";

                CapBox.Show();
                CapBox.Text = "LPF Capacitor";

                equalCheck.Show();
                orderUpDown.Show();
            }
            else if(item == "Sallen Key Highpass Filter")
            {
                CapBox.Show();
                ResistorBox.Show();
                ResistorBox.Text = "HPF Resistor";

                CapBox.Show();
                CapBox.Text = "HPF Capacitor";

                equalCheck.Show();
                orderUpDown.Show();
            }
        }

        private void fClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fHelp_Click(object sender, EventArgs e)
        {
            string message = "Enter in a resistor of cap value. Leave the value blank if" +
                "you want that calculated. Enter value seperated by commas. " +
                "Example: 2nd order LPF give 10k,10k as the resistor values";

            string caption = "Filter Help Box";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            
            if(result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                Console.WriteLine("See. Now thats odd");
            }
        }

        private void fCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
