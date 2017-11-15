using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImEditor;

namespace ImEditor
{
    public partial class Form5 : Form
    {
        int colTxtBox = 1;
        List<ComboBox> listcmb = new List<ComboBox>();

        public Form5()
        {
            InitializeComponent();

            for (int i = 0; i < ImModel.ListPatternOperations.Count; i++)
            {
                cmbPatternName.Items.Add(ImModel.ListPatternOperations.ElementAt(i).PatternName);
            }

            for (int i = 0; i < ImModel.ListResources.Count; i++)
            {
                cmbResourceName.Items.Add(ImModel.ListResources.ElementAt(i).ResourceName);
            }

            listcmb.Add(cmbResourceName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox cmb = new ComboBox();
            colTxtBox += 1;

            for (int i = 0; i < ImModel.ListResources.Count; i++)
            {
                cmb.Items.Add(ImModel.ListResources.ElementAt(i).ResourceName);
            }

            cmb.Width = cmbResourceName.Width;
            cmb.Height = cmbResourceName.Height;
            cmb.Location = new Point(cmbResourceName.Location.X + (colTxtBox - 1) *(cmbResourceName.Width + 10), cmbResourceName.Location.Y);
            this.Controls.Add(cmb);
            listcmb.Add(cmb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colTxtBox > 1)
            {
                this.Controls.Remove(listcmb.ElementAt(listcmb.Count - 1));
                listcmb.RemoveAt(listcmb.Count - 1);
                colTxtBox--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool check1 = true;
            bool check2 = true;
            bool check3 = true;
            int n = 0;
            int k = 0;

            if (fldOperationName.Text == "")
            {
                MessageBox.Show("Введите имя операции! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (cmbPatternName.Text == "")
            {
                MessageBox.Show("Не выбрано имя образца операции! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check2 = false;
            }

            foreach (PatternOperation p in ImModel.ListPatternOperations)
            {
                if (cmbPatternName.Text == p.PatternName)
                {
                    n++;
                }
                else if (cmbPatternName.Text == "")
                {
                    n++;
                }
            }

            if (n==0)
            {
                MessageBox.Show("Такого имени образца операции нет! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check2 = false;
            }

            for (int i = 0; i < listcmb.Count; i ++)
            {
                if (listcmb.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Не выбрано имя ресурса № " + (i + 1) + " !", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check3 = false;
                }

                foreach (Resource r in ImModel.ListResources)
                {
                    if (listcmb.ElementAt(i).Text == r.ResourceName)
                    {
                        k++;
                    }
                    else if (listcmb.ElementAt(i).Text == "")
                    {
                        k++;
                    }
                }

                if (k == 0)
                {
                    MessageBox.Show("Неверно выбран ресурс № " + (i + 1) + " !", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check3 = false;
                }
                k = 0;
            }

            if ((check1 == true) && (check2 == true) && (check3 == true))
            {
                List<string> ResourceNames = new List<string>();

                foreach (ComboBox c in listcmb)
                {
                    ResourceNames.Add(c.Text);
                }

                Operation opr = new Operation(fldOperationName.Text, cmbPatternName.Text, ResourceNames);
                ImModel.ListOperations.Add(opr);
                MessageBox.Show("Операция '" + fldOperationName.Text + "' успешно создана!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }
    }
}
