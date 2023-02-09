using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        string[] stages = { "1-Salt the roast and let it come to room temp before cooking.", "2-Preheat the oven to 375°F.", "3-Rub the roast with olive oil.", "4-Put the roast on the rack with a pan and brown at 375°F.", "5-Rest it and salt the roast, use some pepper or garlic powder." ,"6-Serve it." };

        int index = 0;

        private void btnClick_Click(object sender, EventArgs e)
        {
            if(index <= stages.Length -1)
            {
                lstStage.Items.Add(stages[index]);
                index++;
            }
            else
            {
                MessageBox.Show("The reciept has finished.");
            }
        }

    }
}
