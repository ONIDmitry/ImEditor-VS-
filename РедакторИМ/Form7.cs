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
    public partial class Form7 : Form
    {
        List<TextBox> listtxt = new List<TextBox>();
        List<Label> listlbl1 = new List<Label>();
        List<Label> listlbl2 = new List<Label>();
        List<Label> listlbl3 = new List<Label>();
        List<Label> listlbl4 = new List<Label>();

        public Form7()
        {
            InitializeComponent();
            int n = 0;

            cmbTypes.Text = ImModel.ListResources.ElementAt(ImModel.NumberChosenResource).TypeName;
            fldResName.Text = ImModel.ListResources.ElementAt(ImModel.NumberChosenResource).ResourceName;
            for (int i = 0; i < ImModel.ListTypeResources.Count; i++)
            {
                cmbTypes.Items.Add(ImModel.ListTypeResources.ElementAt(i).TypeName);

                if (ImModel.ListTypeResources.ElementAt(i).TypeName == ImModel.ListResources.ElementAt(ImModel.NumberChosenResource).TypeName)
                {
                    n = i;
                }
            }

            for (int i =0; i < ImModel.ListTypeResources.ElementAt(n).ParamName.Count; i ++)
            {
                Label newl1 = new Label();
                Label newl2 = new Label();
                Label newl3 = new Label();
                Label newl4 = new Label();
                TextBox txt = new TextBox();

                newl1.TextAlign = ContentAlignment.MiddleCenter;
                newl2.TextAlign = ContentAlignment.MiddleCenter;
                newl3.TextAlign = ContentAlignment.MiddleLeft;
                newl4.TextAlign = ContentAlignment.MiddleCenter;

                newl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                try
                {
                    newl1.Text = ImModel.ListTypeResources.ElementAt(n).ParamName.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения имени одного из параметров типа ресурсов ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                try
                {
                    newl2.Text = ImModel.ListTypeResources.ElementAt(n).ParamType.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения типа одного из параметров типа ресурсов ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                try
                {
                    newl3.Text = ImModel.ListTypeResources.ElementAt(n).ParamVariant.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения возможных вариантов типа Enum для одного из параметров типа ресурсов ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                try
                {
                    newl4.Text = ImModel.ListTypeResources.ElementAt(n).ParamDefault.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения начального значения для одного из параметров типа ресурсов ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                try
                {
                    txt.Text = ImModel.ListResources.ElementAt(ImModel.NumberChosenResource).ParamValue.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения начального значения для одного из параметров ресурса ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                newl1.Height = 20;
                newl2.Height = 20;
                newl3.Height = 20;
                newl4.Height = 20;
                newl1.Width = 130;
                newl2.Width = 100;
                newl3.Width = 140;
                newl4.Width = 90;
                txt.Width = 100;
                

                newl1.Location = new Point(13, 160 + (i + 1) * (label3.Height + 10));
                newl2.Location = new Point(160, 160 + (i + 1) * (label4.Height + 10));
                newl3.Location = new Point(278, 160 + (i + 1) * (label5.Height + 10));
                newl4.Location = new Point(445, 160 + (i + 1) * (label6.Height + 10));
                txt.Location = new Point(650, 160 + (i + 1) * (label7.Height + 10));

                this.Controls.Add(newl1);
                this.Controls.Add(newl2);
                this.Controls.Add(newl3);
                this.Controls.Add(newl4);
                this.Controls.Add(txt);

                listlbl1.Add(newl1);
                listlbl2.Add(newl2);
                listlbl3.Add(newl3);
                listlbl4.Add(newl4);
                listtxt.Add(txt);
            }

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImModel.ChosenTypeResource = "";
            ImModel.NumberChosenTypeResource = -1;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ImModel.ListResources.RemoveAt(ImModel.NumberChosenResource);
            MessageBox.Show("Ресурс '" + ImModel.ChosenResource + "' успешно удален!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ImModel.ChosenResource = "";
            ImModel.NumberChosenResource = -1;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool check1 = true;
            bool check2 = true;
            bool check3 = true;
            bool check4 = true;
            bool check5 = true;
            bool check6 = true;
            int value;
            int k = 0;
            int n = 0;
            int m = 0;

            for (int i = 0; i < ImModel.ListTypeResources.Count; i++)
            {
                if (cmbTypes.Text == ImModel.ListTypeResources.ElementAt(i).TypeName)
                {
                    k++;
                    n = i;
                }
            }

            if (k == 1)
            {
                if (listlbl1.Count == ImModel.ListTypeResources.ElementAt(n).ParamName.Count)
                {
                    for (int j = 0; j < ImModel.ListTypeResources.ElementAt(n).ParamName.Count; j++)
                    {
                        if (ImModel.ListTypeResources.ElementAt(n).ParamName.ElementAt(j) == listlbl1.ElementAt(j).Text) m++;
                    }

                    if (m != ImModel.ListTypeResources.ElementAt(n).ParamName.Count)
                    {
                        MessageBox.Show("Тип ресурсов " + ImModel.ListTypeResources.ElementAt(n).TypeName + " не содержит такие параметры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check6 = false;
                    }
                }
                else
                {
                    MessageBox.Show("Тип ресурсов " + ImModel.ListTypeResources.ElementAt(n).TypeName + " не содержит такие параметры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check6 = false;
                }
            }

            if (k == 0)
            {
                MessageBox.Show("Такого типа ресурсов нет!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (fldResName.Text == "")
            {
                MessageBox.Show("Введите имя ресурса!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check2 = false;
            }

            for (int i = 0; i < listlbl4.Count; i++)
            {
                if (listlbl4.ElementAt(i).Text == "")
                {
                    if (listtxt.ElementAt(i).Text == "")
                    {
                        MessageBox.Show("В параметре № " + (i + 1) + " не задано начальное значение параметра ресурса, в то время, как начальное значение параметра в типе ресурсов также пустое!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check3 = false;
                    }
                    else if (listtxt.ElementAt(i).Text == "*")
                    {
                        MessageBox.Show("В параметре № " + (i + 1) + " указано начальное значение параметра ресурса '*', в то время, как начальное значение параметра в типе ресурсов пустое!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check3 = false;
                    }
                }
                else if (listtxt.ElementAt(i).Text == "")
                {
                    MessageBox.Show("В параметре № " + (i + 1) + " указано пустое начальное значение параметра ресурса! Поставьте '*' или конкретное значение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check3 = false;
                }
            }

            for (int i = 0; i < listtxt.Count; i++)
            {
                if (listlbl2.ElementAt(i).Text == "int" && !Int32.TryParse(listtxt.ElementAt(i).Text, out value) && listtxt.ElementAt(i).Text != "" && listtxt.ElementAt(i).Text != "*" && listtxt.ElementAt(i).Text != " *")
                {
                    MessageBox.Show("Введенное начальное значение для типа int в параметре № " + (i + 1) + " не является числом! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
                else if (listlbl2.ElementAt(i).Text == "bool" && listtxt.ElementAt(i).Text != "false" && listtxt.ElementAt(i).Text != "true" && listtxt.ElementAt(i).Text != "False" && listtxt.ElementAt(i).Text != "True" && listtxt.ElementAt(i).Text != "" && listtxt.ElementAt(i).Text != "*" && listtxt.ElementAt(i).Text != " *")
                {
                    MessageBox.Show("Введенное начальное значение для типа bool в параметре № " + (i + 1) + " задано неверно! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            if ((check1 == true) && (check2 == true) && (check3 == true) && (check4 == true) && (check5 == true) && (check6 == true))
            {
                List<string> ParamValue = new List<string>();

                foreach (TextBox t in listtxt)
                {
                    ParamValue.Add(t.Text);
                }

                string s = "";

                for (int i = 0; i < ImModel.ListTypeResources.Count; i++)
                {
                    if (ImModel.ListTypeResources.ElementAt(i).TypeName == cmbTypes.Text)
                    {
                        s = ImModel.ListTypeResources.ElementAt(i).TraseValue;
                    }
                }

                Resource rss = new Resource(cmbTypes.Text, fldResName.Text, ParamValue, s);
                ImModel.ListResources.RemoveAt(ImModel.NumberChosenResource);
                ImModel.ListResources.Insert(ImModel.NumberChosenResource, rss);
                MessageBox.Show("Ресурс '" + fldResName.Text + "' успешно изменен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ImModel.ChosenResource = "";
                ImModel.NumberChosenResource = -1;
                Close();
            }
        }
    }
}
