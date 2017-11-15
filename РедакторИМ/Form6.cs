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
    public partial class Form6 : Form
    {
        int colTxtBox = 0;
        List<TextBox> listtxt1 = new List<TextBox>();
        List<TextBox> listtxt2 = new List<TextBox>();
        List<TextBox> listtxt3 = new List<TextBox>();
        List<ComboBox> listcmb = new List<ComboBox>();

        public Form6()
        {
            InitializeComponent();

            cmbTrase.Items.AddRange(new string[] { "Да", "Нет" });
            cmbTime.Items.AddRange(new string[] { "Временные", "Постоянные" });
            fldTypeName.Text = ImModel.ChosenTypeResource;

            cmbTrase.Text = ImModel.ListTypeResources.ElementAt(ImModel.NumberChosenTypeResource).TraseValue;
            cmbTime.Text = ImModel.ListTypeResources.ElementAt(ImModel.NumberChosenTypeResource).TempValue;

            for (int i = 0;  i < ImModel.ListTypeResources.ElementAt(ImModel.NumberChosenTypeResource).ParamName.Count; i ++)
            {
                TextBox txt1 = new TextBox();
                TextBox txt2 = new TextBox();
                TextBox txt3 = new TextBox();
                ComboBox cmb = new ComboBox();
                cmb.Items.AddRange(new string[] { "int", "bool", "Enum" });

                try
                {
                    txt1.Text = ImModel.ListTypeResources.ElementAt(ImModel.NumberChosenTypeResource).ParamName.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения имени параметра типа ресурсов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                try
                {
                    txt2.Text = ImModel.ListTypeResources.ElementAt(ImModel.NumberChosenTypeResource).ParamVariant.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения вариантов значений для типа Enum", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                try
                {
                    txt3.Text = ImModel.ListTypeResources.ElementAt(ImModel.NumberChosenTypeResource).ParamDefault.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения начального значения одного из параметров типа ресурсов ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                try
                {
                    cmb.Text = ImModel.ListTypeResources.ElementAt(ImModel.NumberChosenTypeResource).ParamType.ElementAt(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка определения типа одного из параметров типа ресурсов ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                txt1.Height = 21;
                txt2.Height = 21;
                txt3.Height = 21;
                cmb.Height = 21;
                txt1.Width = 100;
                cmb.Width = 121;
                txt2.Width = 222;
                txt3.Width = 100;
                txt1.Location = new Point(12, 187 + i * 31);
                cmb.Location = new Point(131, 188 + i  * 31);
                txt2.Location = new Point(275, 187 + i* 31);
                txt3.Location = new Point(519, 187 + i *31);

                this.Controls.Add(txt1);
                this.Controls.Add(txt2);
                this.Controls.Add(txt3);
                this.Controls.Add(cmb);
                listtxt1.Add(txt1);
                listtxt2.Add(txt2);
                listtxt3.Add(txt3);
                listcmb.Add(cmb);
                colTxtBox += 1;
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
            ImModel.ListTypeResources.RemoveAt(ImModel.NumberChosenTypeResource);
            MessageBox.Show("Тип ресурса '" + ImModel.ChosenTypeResource + "' успешно удален!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ImModel.ChosenTypeResource = "";
            ImModel.NumberChosenTypeResource = -1;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox newtxt1 = new TextBox();
            TextBox newtxt2 = new TextBox();
            TextBox newtxt3 = new TextBox();
            ComboBox newcmb = new ComboBox();
            colTxtBox += 1;
            newcmb.Items.AddRange(new string[] { "int", "bool", "Enum" });

            newtxt1.Height = 21;
            newtxt2.Height = 21;
            newtxt3.Height = 21;
            newcmb.Height = 21;
            newtxt1.Width = 100;
            newcmb.Width = 121;
            newtxt2.Width = 222;
            newtxt3.Width = 100;
            newtxt1.Location = new Point(12, 187 + (colTxtBox-1) * 31);
            newcmb.Location = new Point(132, 188 + (colTxtBox - 1) * 31);
            newtxt2.Location = new Point(275, 187 + (colTxtBox - 1) * 31);
            newtxt3.Location = new Point(519, 187 + (colTxtBox - 1) * 31);
            this.Controls.Add(newtxt1);
            this.Controls.Add(newtxt2);
            this.Controls.Add(newtxt3);
            this.Controls.Add(newcmb);
            listtxt1.Add(newtxt1);
            listtxt2.Add(newtxt2);
            listtxt3.Add(newtxt3);
            listcmb.Add(newcmb);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colTxtBox > 1)
            {
                this.Controls.Remove(listtxt1.ElementAt(listtxt1.Count - 1));
                listtxt1.RemoveAt(listtxt1.Count - 1);
                this.Controls.Remove(listcmb.ElementAt(listcmb.Count - 1));
                listcmb.RemoveAt(listcmb.Count - 1);
                this.Controls.Remove(listtxt2.ElementAt(listtxt2.Count - 1));
                listtxt2.RemoveAt(listtxt2.Count - 1);
                this.Controls.Remove(listtxt3.ElementAt(listtxt3.Count - 1));
                listtxt3.RemoveAt(listtxt3.Count - 1);
                colTxtBox--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool check1 = true;
            bool check2 = true;
            bool check3 = true;
            bool check4 = true;
            bool check5 = true;

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

            foreach (TextBox t in listtxt1)
            {
                foreach (ComboBox c in listcmb)
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

            for (int i = 0; i < listtxt1.Count; i++)
            {
                if ((listcmb.ElementAt(i).Text == "int") && ((!Int32.TryParse(listtxt3.ElementAt(i).Text, out value)) && (listtxt3.ElementAt(i).Text != "")))
                {
                    MessageBox.Show("Введенное начальное значение для типа int в параметре № " + (i + 1) + " не является числом! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check3 = false;
                }
                else if ((listcmb.ElementAt(i).Text == "bool") && (listtxt3.ElementAt(i).Text != "false") && (listtxt3.ElementAt(i).Text != "False") && (listtxt3.ElementAt(i).Text != "true") && (listtxt3.ElementAt(i).Text != "True") && (listtxt3.ElementAt(i).Text != ""))
                {
                    MessageBox.Show("Введенное начальное значение для типа bool в параметре № " + (i + 1) + " выбрано неверно!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check3 = false;
                }
            }

            for (int i = 0; i < listtxt1.Count; i++)
            {
                if ((listcmb.ElementAt(i).Text == "int") && (listtxt2.ElementAt(i).Text != ""))
                {
                    MessageBox.Show("Возможные значения выбираются только для типа параметра Enum! Введены возможные значения для типа не Enum в параметре № " + (i + 1), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
                else if ((listcmb.ElementAt(i).Text == "bool") && (listtxt2.ElementAt(i).Text != ""))
                {
                    MessageBox.Show("Возможные значения выбираются только для типа параметра Enum! Введены возможные значения для типа не Enum в параметре № " + (i + 1), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listtxt1.Count; i++)
            {
                if ((listcmb.ElementAt(i).Text == "Enum") && (listtxt2.ElementAt(i).Text == ""))
                {
                    MessageBox.Show("В параметре " + (i + 1) + " не указаны возможные значения для типа Enum!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }
            }

            if ((check1 == true) && (check2 == true) && (check3 == true) && (check4 == true) && (check5 == true))
            {
                List<string> ParamName = new List<string>();
                List<string> ParamType = new List<string>();
                List<string> ParamVariant = new List<string>();
                List<string> ParamDefault = new List<string>();

                foreach (TextBox t in listtxt1)
                {
                    ParamName.Add(t.Text);
                }

                foreach (ComboBox c in listcmb)
                {
                    ParamType.Add(c.Text);
                }
                foreach (TextBox c1 in listtxt2)
                {
                    ParamVariant.Add(c1.Text);
                }
                foreach (TextBox c2 in listtxt3)
                {
                    ParamDefault.Add(c2.Text);
                }

                TypeResource tprss = new TypeResource(fldTypeName.Text, cmbTrase.Text, cmbTime.Text, ParamName, ParamType, ParamVariant, ParamDefault);
                ImModel.ListTypeResources.RemoveAt(ImModel.NumberChosenTypeResource);
                ImModel.ListTypeResources.Insert(ImModel.NumberChosenTypeResource, tprss);
                MessageBox.Show("Тип ресурса '" + ImModel.ChosenTypeResource + "' успешно изменен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ImModel.ChosenTypeResource = "";
                ImModel.NumberChosenTypeResource = -1;
                Close();
            }

        }
    }
}
