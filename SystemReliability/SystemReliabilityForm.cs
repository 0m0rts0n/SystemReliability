using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemReliability
{
    public partial class SystemReliabilityForm : Form
    {
        public SystemReliabilityForm()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double block1 = Convert.ToDouble(BlockA_TB.Text.Replace(".", ","));
            double block2 = Convert.ToDouble(BlockB_TB.Text.Replace(".", ","));
            double block3 = Convert.ToDouble(BlockC_TB.Text.Replace(".", ","));
            string result = "";
            if (block1 <= 1 || block2 <= 1 || block3 <= 1) result = ReliabilityClass.Test(block1, block2, block3);
            else MessageBox.Show("Значения вероятностей некорректны. Повторите ввод.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Block_TB_TextChanged(object sender, EventArgs e)
        {
            CalcBtn.Enabled = (BlockA_TB.Text != "" && BlockB_TB.Text != "" && BlockC_TB.Text != "" && TestsCount_TB.Text != "");
        }
        private void Block_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 44;
        }

        private void ExampleBtn_Click(object sender, EventArgs e)
        {
            BlockA_TB.Text = "0,9";
            BlockB_TB.Text = "0,75";
            BlockC_TB.Text = "0,6";
        }
    }
}
