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
    public partial class Form9 : Form
    {
        int colTxtBox = 0;
        List<ComboBox> listcmb = new List<ComboBox>();

        public Form9()
        {
            InitializeComponent();

            for (int i = 0; i < ImModel.ListPatternOperations.Count; i++)
            {
                cmbPatternName.Items.Add(ImModel.ListPatternOperations.ElementAt(i).PatternName);
            }

            fldOperationName.Text = ImModel.ListOperations.ElementAt(ImModel.NumberChosenOperation).OperationName;
            cmbPatternName.Text = ImModel.ListOperations.ElementAt(ImModel.NumberChosenOperation).PatternName;

            for (int i=0; i<ImModel.ListOperations.ElementAt(ImModel.NumberChosenOperation).ResourceNames.Count; i ++)
            {
                ComboBox cmb = new ComboBox();

                for (int j = 0; j < ImModel.ListResources.Count; j++)
                {
                    cmb.Items.Add(ImModel.ListResources.ElementAt(j).ResourceName);
                }

                try
                {
                    cmb.Text = ImModel.ListOperations.ElementAt(ImModel.NumberChosenOperation).ResourceNames.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения одного из ресурсов для операции ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                cmb.Height = 21;
                cmb.Width = 121;
                cmb.Location = new Point(121 + i * (121 + 10), 130);
                this.Controls.Add(cmb);
                listcmb.Add(cmb);

                colTxtBox += 1;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox cmb = new ComboBox();
            colTxtBox += 1;

            for (int j = 0; j < ImModel.ListResources.Count; j++)
            {
                cmb.Items.Add(ImModel.ListResources.ElementAt(j).ResourceName);
            }

            cmb.Height = 21;
            cmb.Width = 121;
            cmb.Location = new Point(121 + (colTxtBox -1) * (121 + 10), 130);
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

        private void button5_Click(object sender, EventArgs e)
        {
            ImModel.ChosenOperation = "";
            ImModel.NumberChosenOperation = -1;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ImModel.ListOperations.RemoveAt(ImModel.NumberChosenOperation);
            MessageBox.Show("Операция '" + ImModel.ChosenOperation + "' успешно удалена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ImModel.ChosenOperation = "";
            ImModel.NumberChosenOperation = -1;
            Close();
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

            if (n == 0)
            {
                MessageBox.Show("Такого имени образца операции нет! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check2 = false;
            }

            for (int i = 0; i < listcmb.Count; i++)
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
                ImModel.ListOperations.RemoveAt(ImModel.NumberChosenOperation);
                ImModel.ListOperations.Insert(ImModel.NumberChosenOperation, opr);
                MessageBox.Show("Операция '" + ImModel.ChosenOperation + "' успешно изменена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ImModel.ChosenOperation = "";
                ImModel.NumberChosenOperation = -1;
                Close();
            }
        }
    }
}
