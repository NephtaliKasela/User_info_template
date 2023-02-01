using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_info_template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = lstCity.SelectedItem.ToString();
            city = city.ToUpper();
            //string city = lstCity.GetItemText(lstCity.SelectedItem);
            //string city = lstCity.GetItemText(lstCity.SelectedIndex);  <-- pour recuperer l'index de l'element selectionne
            MessageBox.Show(city);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToUpper();
            string adress = txtAdress.Text.ToUpper();
            if (name != "" && adress != "")
            {
                lstCity.Items.Add(name + " " + adress);
                txtAdress.Text = "";
                txtName.Text = "";
                MessageBox.Show(name + " " + adress, "Successful !");
                //lstCity.Items.Clear();
                MessageBox.Show(lstCity.Items.Count.ToString());
            }
            else MessageBox.Show("Your name and adress must be completed.", "Warning !");

        }

    }
}
