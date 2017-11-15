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
  
    public partial class Form2 : Form
    {
        int colTxtBox = 1;
        List<TextBox> txtbxes1 = new List<TextBox>();
        List<ComboBox> cmbbxes = new List<ComboBox>();
        List<TextBox> txtbxes2 = new List<TextBox>();
        List<TextBox> txtbxes3 = new List<TextBox>();

        public Form2()
        {
            InitializeComponent();
            cmbTrase.Items.AddRange(new string[] { "Да", "Нет" });
            cmbTime.Items.AddRange(new string[] { "Временные", "Постоянные"});
            cmbParam1.Items.AddRange(new string[] { "int", "bool", "Enum"});
            txtbxes1.Add(fldParam1);
            cmbbxes.Add(cmbParam1);
            txtbxes2.Add(fldVariants1);
            txtbxes3.Add(fldDefault1);
        }
  
        private void button2_Click(object sender, EventArgs e)
        {
            bool check1 = true;
            bool check2 = true;
            bool check3 = true;
            bool check4 = true;
            bool check5 = true;
            bool check6 = true;

            int value;

            if (fldTypeName.Text == "")
            {
                MessageBox.Show("Вы не выбрали имя типа ресурсов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }
             
            if (cmbTrase.Text == "")
            {
                MessageBox.Show("Вы не выбрали признак трассировки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            else if ((cmbTrase.Text != "Да") && (cmbTrase.Text != "Нет"))
            {
                MessageBox.Show("Вы указали неверный признак трассировки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (cmbTime.Text == "")
            {
                MessageBox.Show("Вы не выбрали статус типа ресурсов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

           else if ((cmbTime.Text != "Временные") && (cmbTime.Text != "Постоянные"))
            {
                MessageBox.Show("Вы указали неверный статус типа ресурсов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            foreach (TextBox t in txtbxes1)
            {
                foreach (ComboBox c in cmbbxes)
                {
                    if (check2 == true)
                    {
                        if (c.Text == "")
                        {
                            MessageBox.Show("Вы не выбрали значение для одного из типов параметра типа ресурсов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            check2 = false;
                        }
                        else if ((c.Text != "int") && (c.Text != "bool") && (c.Text != "Enum"))
                        {
                            MessageBox.Show("Вы ввели неверное значение для одного из типов параметра типа ресурсов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            check2 = false;
                        }
                    }
                }

                if (check2 == true)
                {
                    if (t.Text == "")
                    {
                        MessageBox.Show("Вы выбрали пустое значение одного из имени параметра типа ресурсов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check2 = false;
                    }
                }               
            }   

            for (int i = 0; i<txtbxes1.Count; i++)
            {
                if ((cmbbxes.ElementAt(i).Text == "int") &&  ((!Int32.TryParse(txtbxes3.ElementAt(i).Text, out value)) && (txtbxes3.ElementAt(i).Text != "")))
                    {
                        MessageBox.Show("Введенное начальное значение для типа int в параметре № " + (i+1) + " не является числом! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check3 = false;
                    }
                    else if ((cmbbxes.ElementAt(i).Text == "bool") && (txtbxes3.ElementAt(i).Text!= "false") && (txtbxes3.ElementAt(i).Text != "False") && (txtbxes3.ElementAt(i).Text != "true") && (txtbxes3.ElementAt(i).Text != "True") && (txtbxes3.ElementAt(i).Text != ""))
                    {
                        MessageBox.Show("Введенное начальное значение для типа bool в параметре № " + (i+1) + " выбрано неверно!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check3 = false;
                    }
            }

            for (int i = 0; i < txtbxes1.Count; i++)
            {
                    if ((cmbbxes.ElementAt(i).Text == "int") && (txtbxes2.ElementAt(i).Text != ""))
                    {
                        MessageBox.Show("Возможные значения выбираются только для типа параметра Enum! Введены возможные значения для типа не Enum в параметре № " + (i+1), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check4 = false;
                    }
                    else if ((cmbbxes.ElementAt(i).Text == "bool") && (txtbxes2.ElementAt(i).Text != ""))
                    {
                        MessageBox.Show("Возможные значения выбираются только для типа параметра Enum! Введены возможные значения для типа не Enum в параметре № " + (i + 1), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        check4 = false;
                    }
            }

            foreach (TypeResource t3 in ImModel.ListTypeResources)
            {
                    if (check5 == true)
                    {
                        if (t3.TypeName == fldTypeName.Text)
                        {
                            MessageBox.Show("Тип ресурса '" + fldTypeName.Text + "' уже существует", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            check5 = false;
                        }
                    }
            }

            for (int i =0; i < txtbxes1.Count; i++)
            {
                if ((cmbbxes.ElementAt(i).Text == "Enum") && (txtbxes2.ElementAt(i).Text == ""))
                {
                    MessageBox.Show("В параметре " + (i + 1) + " не указаны возможные значения для типа Enum!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check6 = false;
                }
            }

            if ((check1 == true) && (check2 == true) && (check3 == true) && (check4 == true) && (check5 == true) && (check6 = true))
            {
                List<string> ParamName = new List<string>();
                List<string> ParamType = new List<string>();
                List<string> ParamVariant = new List<string>();
                List<string> ParamDefault = new List<string>();

                foreach (TextBox t in txtbxes1)
                {
                    ParamName.Add(t.Text);
                }

                foreach (ComboBox c in cmbbxes)
                {
                    ParamType.Add(c.Text);
                }
                foreach (TextBox c1 in txtbxes2)
                {
                    ParamVariant.Add(c1.Text);
                }
                foreach (TextBox c2 in txtbxes3)
                {
                    ParamDefault.Add(c2.Text);
                }

                TypeResource tprss = new TypeResource(fldTypeName.Text, cmbTrase.Text, cmbTime.Text, ParamName, ParamType, ParamVariant, ParamDefault);
                ImModel.ListTypeResources.Add(tprss);
                MessageBox.Show("Тип ресурса '" + fldTypeName.Text + "' успешно создан!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }              
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox newtxtbx = new TextBox();
            TextBox newtxtbx2 = new TextBox();
            TextBox newtxtbx3 = new TextBox();
            ComboBox newcmbbx = new ComboBox();
            colTxtBox += 1;
            newcmbbx.Items.AddRange(new string[] {"int", "bool", "Enum"});
            newcmbbx.Width = cmbParam1.Width;
            newcmbbx.Height = cmbParam1.Height;
            newtxtbx.Width = fldParam1.Width;
            newtxtbx.Height = fldParam1.Height;
            newtxtbx2.Width = fldVariants1.Width;
            newtxtbx2.Height = fldVariants1.Height;
            newtxtbx3.Width = fldDefault1.Width;
            newtxtbx3.Height = fldDefault1.Height;
            newtxtbx.Location = new Point(fldParam1.Location.X, fldParam1.Location.Y + (colTxtBox - 1)*(fldParam1.Height + 10));
            newcmbbx.Location = new Point(cmbParam1.Location.X, cmbParam1.Location.Y + (colTxtBox - 1) * (cmbParam1.Height + 10));
            newtxtbx2.Location = new Point(fldVariants1.Location.X, fldVariants1.Location.Y + (colTxtBox - 1) * (fldVariants1.Height + 10));
            newtxtbx3.Location = new Point(fldDefault1.Location.X, fldDefault1.Location.Y + (colTxtBox - 1) * (fldDefault1.Height + 10));
            this.Controls.Add(newtxtbx);
            this.Controls.Add(newtxtbx2);
            this.Controls.Add(newtxtbx3);
            this.Controls.Add(newcmbbx);
            txtbxes1.Add(newtxtbx);
            txtbxes2.Add(newtxtbx2);
            txtbxes3.Add(newtxtbx3);
            cmbbxes.Add(newcmbbx);       
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (colTxtBox > 1)
            {
                this.Controls.Remove(txtbxes1.ElementAt(txtbxes1.Count - 1));
                txtbxes1.RemoveAt(txtbxes1.Count-1);
                this.Controls.Remove(cmbbxes.ElementAt(cmbbxes.Count - 1));
                cmbbxes.RemoveAt(cmbbxes.Count - 1);
                this.Controls.Remove(txtbxes2.ElementAt(txtbxes2.Count - 1));
                txtbxes2.RemoveAt(txtbxes2.Count - 1);
                this.Controls.Remove(txtbxes3.ElementAt(txtbxes3.Count - 1));
                txtbxes3.RemoveAt(txtbxes3.Count - 1);
                colTxtBox--;
            }
        }

    }
}
