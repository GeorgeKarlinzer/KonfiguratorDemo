using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonfiguratorDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SecondaryComboBoxesSystem.secondaryPanels = new Dictionary<string, Panel>
            {
                { "colors", colorPanel },
                { "params 1", param1Panel },
                { "params 2", param2Panel }
            };
            _ = new ComboBoxModel(mainComboBox);
        }

        Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            headerTop.Focus();
        }

        private void MainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecondaryComboBoxesSystem.SetSecondaryBoxes(mainComboBox.SelectedItem.ToString());
        }
    }
}
