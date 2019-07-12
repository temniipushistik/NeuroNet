using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuronsPet
{
    public partial class NeiroGUI : Form
    {
        public NeiroGUI()
        {
            InitializeComponent();
        }

        NeuroCalc SwitchOn = new NeuroCalc();

        // проверяем включенность водки
        private void VodkaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vodkaCheckBox.Checked == true)
            {
                SwitchOn.Vodka = 1;
                result.Text = "Водка включена";
            }
            else 
            {
                SwitchOn.Vodka = 0;
                result.Text = "Водка выключена";
            }


        }

        private void RainCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RainCheckBox.Checked == true)
            {
                SwitchOn.Rain = 1;
                result.Text = "дождь включен";
            }
            else
            {
                SwitchOn.Rain = 0;
                result.Text = "дождь выключен";
            }
        }

        private void BestFriendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bestFriendCheckBox.Checked == true)
            {
                SwitchOn.Friend = 1;
                result.Text = "друг включен";
            }
            else
            {
                SwitchOn.Friend = 0;
                result.Text = "друг выключен";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SwitchOn.CreateArray();
        }
    }
}
