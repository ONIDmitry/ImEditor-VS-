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
    public partial class Form3 : Form
    {
        List<TextBox> txtbxes4 = new List<TextBox>();
        List<Label> lbl1 = new List<Label>();
        List<Label> lbl2 = new List<Label>();
        List<Label> lbl3  = new List<Label>();
        List<Label> lbl4 = new List<Label>();


        public Form3()
        {
            InitializeComponent();

            for (int i = 0; i< ImModel.ListTypeResources.Count; i++)
            {
                cmbTypes.Items.Add(ImModel.ListTypeResources.ElementAt(i).TypeName);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            for (int i=0; i < txtbxes4.Count; i++)
            {
                this.Controls.Remove(txtbxes4.ElementAt(i));
                this.Controls.Remove(lbl1.ElementAt(i));
                this.Controls.Remove(lbl2.ElementAt(i));
                this.Controls.Remove(lbl3.ElementAt(i));
                this.Controls.Remove(lbl4.ElementAt(i));
            }

            txtbxes4.Clear();
            lbl1.Clear();
            lbl2.Clear();
            lbl3.Clear();
            lbl4.Clear();

            int n = 0;
            int k = 0;
            for (int i = 0; i < ImModel.ListTypeResources.Count; i++)
            {

                if (cmbTypes.Text != ImModel.ListTypeResources.ElementAt(i).TypeName)
                {
                    n++;
                }
                else
                {
                    k++;
                    break;
                }
            }

            if (k == 0)
            {
                MessageBox.Show("Такого типа ресурсов нет!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Label l1 = new Label();
                Label l2 = new Label();
                Label l3 = new Label();
                Label l4 = new Label();
                Label l5 = new Label();
                Label l6 = new Label();
                fldResName.Visible = true;
                butCreateRes.Visible = true;
                l1.Text = "Имя параметра";
                l2.Text = "Тип параметра";
                l3.Text = "Возможные значения";
                l4.Text = "Значение по умолчанию";
                l5.Text = "Начальное значение параметра ресурса";
                l6.Text = "Введите имя ресурса";
                l1.Width = 87;
                l2.Width = 84;
                l3.Width = 140;
                l4.Width = 130;
                l5.Width = 250;
                l6.Width = 150;
                l1.Location = new Point(36, 130);
                l2.Location = new Point(167, 130);
                l3.Location = new Point(289, 130);
                l4.Location = new Point(430, 130);
                l5.Location = new Point(600, 130);
                l6.Location = new Point(135, 75);
                this.Controls.Add(l1);
                this.Controls.Add(l2);
                this.Controls.Add(l3);
                this.Controls.Add(l4);
                this.Controls.Add(l5);
                this.Controls.Add(l6);

                for (int i = 0; i < ImModel.ListTypeResources.ElementAt(n).ParamName.Count; i++)
                {
                    Label newl1 = new Label();
                    Label newl2 = new Label();
                    Label newl3 = new Label();
                    Label newl4 = new Label();
                    TextBox newtxt = new TextBox();
                    newl1.TextAlign = ContentAlignment.MiddleCenter;
                    newl2.TextAlign = ContentAlignment.MiddleCenter;
                    newl3.TextAlign = ContentAlignment.MiddleLeft;
                    newl4.TextAlign = ContentAlignment.MiddleCenter;
                    newl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    newl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    newl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    newl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    newl1.Text = ImModel.ListTypeResources.ElementAt(n).ParamName.ElementAt(i);
                    newl2.Text = ImModel.ListTypeResources.ElementAt(n).ParamType.ElementAt(i);
                    newl3.Text = ImModel.ListTypeResources.ElementAt(n).ParamVariant.ElementAt(i);
                    newl4.Text = ImModel.ListTypeResources.ElementAt(n).ParamDefault.ElementAt(i);
                    newl1.Height = 20;
                    newl2.Height = 20;
                    newl3.Height = 20;
                    newl4.Height = 20;
                    newl1.Width = 130;
                    newl2.Width = 100;
                    newl3.Width = 140;
                    newl4.Width = 90;
                    newl1.Location = new Point(13, 130 + (i+1)*(l1.Height + 10));
                    newl2.Location = new Point(160, 130 + (i + 1) * (l2.Height + 10));
                    newl3.Location = new Point(278, 130 + (i + 1) * (l3.Height + 10));
                    newl4.Location = new Point(445, 130 + (i + 1) * (l4.Height + 10));
                    this.Controls.Add(newl1);
                    this.Controls.Add(newl2);
                    this.Controls.Add(newl3);
                    this.Controls.Add(newl4);
                    newtxt.Width = 100;
                    newtxt.Location = new Point(650, 130 + (i + 1) * (l5.Height + 10));
                    this.Controls.Add(newtxt);
                    txtbxes4.Add(newtxt);
                    lbl1.Add(newl1);
                    lbl2.Add(newl2);
                    lbl3.Add(newl3);
                    lbl4.Add(newl4);
                }
            }
        }

        private void butCreateRes_Click(object sender, EventArgs e)
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

            if (k==1)
            {
                if (lbl1.Count == ImModel.ListTypeResources.ElementAt(n).ParamName.Count)
                {
                    for (int j = 0; j < ImModel.ListTypeResources.ElementAt(n).ParamName.Count; j++)
                    {
                        if (ImModel.ListTypeResources.ElementAt(n).ParamName.ElementAt(j) == lbl1.ElementAt(j).Text) m++;
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

            if (k==0)
            {
                MessageBox.Show("Такого типа ресурсов нет!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }
                
           if (fldResName.Text == "")
            {
                MessageBox.Show("Введите имя ресурса!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check2 = false;
            }

            for (int i = 0; i < lbl4.Count; i++)
            {
                if (lbl4.ElementAt(i).Text == "")
                {
                    if (txtbxes4.ElementAt(i).Text == "")
                    {
                        MessageBox.Show("В параметре № " + (i + 1) + " не задано начальное значение параметра ресурса, в то время, как начальное значение параметра в типе ресурсов также пустое!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check3 = false;
                    }
                    else if (txtbxes4.ElementAt(i).Text == "*")
                    {
                        MessageBox.Show("В параметре № " + (i + 1) + " указано начальное значение параметра ресурса '*', в то время, как начальное значение параметра в типе ресурсов пустое!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check3 = false;
                    }
                }
                else if (txtbxes4.ElementAt(i).Text == "")
                {
                    MessageBox.Show("В параметре № " + (i + 1) + " указано пустое начальное значение параметра ресурса! Поставьте '*' или конкретное значение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check3 = false;
                }
            }

            for (int i =0; i < txtbxes4.Count; i ++)
            {
                if (lbl2.ElementAt(i).Text == "int" && !Int32.TryParse(txtbxes4.ElementAt(i).Text, out value) && txtbxes4.ElementAt(i).Text != "" && txtbxes4.ElementAt(i).Text != "*")
                {
                    MessageBox.Show("Введенное начальное значение для типа int в параметре № " + (i + 1) + " не является числом! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
                else if (lbl2.ElementAt(i).Text == "bool" && txtbxes4.ElementAt(i).Text != "false" && txtbxes4.ElementAt(i).Text != "true" && txtbxes4.ElementAt(i).Text != "False" && txtbxes4.ElementAt(i).Text != "True" && txtbxes4.ElementAt(i).Text != "" && txtbxes4.ElementAt(i).Text != "*")
                {
                    MessageBox.Show("Введенное начальное значение для типа bool в параметре № " + (i + 1) + " задано неверно! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            foreach (Resource r in ImModel.ListResources)
            {
                if (check5 == true)
                {
                    if (r.ResourceName == fldResName.Text)
                    {
                        MessageBox.Show("Ресурс '" + fldResName.Text + "' уже существует", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check5 = false;
                    }
                }
            }

            if ((check1 == true) && (check2 == true) && (check3 == true) && (check4 == true) && (check5 == true) && (check6 == true))
            {
                List<string> ParamValue= new List<string>();

                foreach (TextBox t in txtbxes4)
                {
                    ParamValue.Add(t.Text);
                }

                string s = "";

                for (int i = 0; i < ImModel.ListTypeResources.Count; i ++)
                {
                    if (ImModel.ListTypeResources.ElementAt(i).TypeName == cmbTypes.Text)
                    {
                        s = ImModel.ListTypeResources.ElementAt(i).TraseValue;
                    }
                }

                Resource rss = new Resource(cmbTypes.Text, fldResName.Text, ParamValue, s);
                ImModel.ListResources.Add(rss);
                MessageBox.Show("Ресурс '" + fldResName.Text + "' успешно создан!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }


        }
    }
}
