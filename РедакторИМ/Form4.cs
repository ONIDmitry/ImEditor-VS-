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
    public partial class Form4 : Form
    {
        int colTxtBox = 1;
        List<Label> listlbl1 = new List<Label>();
        List<Label> listlbl2 = new List<Label>();
        List<Label> listlbl3 = new List<Label>();
        List<Label> listlbl4 = new List<Label>();
        List<Label> listlbl5 = new List<Label>();
        List<Label> listlbl6 = new List<Label>();
        List<Label> listlbl7 = new List<Label>();
        List<Label> listlbl8 = new List<Label>();
        List<Label> listlbl9 = new List<Label>();
        List<Label> listlbl10 = new List<Label>();

        List<TextBox> listtxt1 = new List<TextBox>();
        List<TextBox> listtxt2 = new List<TextBox>();
        List<TextBox> listtxt3 = new List<TextBox>();
        List<TextBox> listtxt4 = new List<TextBox>();
        List<TextBox> listtxt5 = new List<TextBox>();
        List<TextBox> listtxt6 = new List<TextBox>();

        List<ComboBox> listcmb1 = new List<ComboBox>();
        List<ComboBox> listcmb2 = new List<ComboBox>();
        List<ComboBox> listcmb3 = new List<ComboBox>();
        List<ComboBox> listcmb4 = new List<ComboBox>();

        public Form4()
        {
            InitializeComponent();
            
            for (int i=0; i < ImModel.ListTypeResources.Count; i++)
            {
                cmbTypeNameW.Items.Add(ImModel.ListTypeResources.ElementAt(i).TypeName);
            }

            cmbPatternType.Items.AddRange(new string[] { "Нерегулярное событие", "Правило", "Операция" });
            cmbTrase.Items.AddRange(new string[] { "Да", "Нет" });
            cmbTypeTime.Items.AddRange(new string[] { "Точное", "Случайное" });
            cmbLaw.Items.AddRange(new string[] { "@normal@", "@exponential@", "@uniform@" });
            cmbConvStatus.Items.AddRange(new string[] { "Не_изменять", "Сохранить" });
            cmbConvBegin.Items.AddRange(new string[] { "Не_изменять", "Сохранить" });
            cmbConvEnd.Items.AddRange(new string[] { "Не_изменять", "Сохранить" });
            listlbl1.Add(label9);
            listlbl2.Add(label10);
            listlbl3.Add(label14);
            listlbl4.Add(label15);
            listlbl5.Add(label16);
            listlbl6.Add(label11);
            listlbl7.Add(label12);
            listlbl8.Add(label13);
            listlbl9.Add(label17);
            listlbl10.Add(label18);

            listtxt1.Add(fldRelResName);
            listtxt2.Add(fldCondition);
            listtxt3.Add(fldConvertEvent);
            listtxt4.Add(fldConvertRule);
            listtxt5.Add(fldConvertBegin);
            listtxt6.Add(fldConvertEnd);

            listcmb1.Add(cmbTypeNameW);
            listcmb2.Add(cmbConvStatus);
            listcmb3.Add(cmbConvBegin);
            listcmb4.Add(cmbConvEnd);
        }

        private void butAddRelRes_Click(object sender, EventArgs e)
        {
            Label lbl1 = new Label();
            Label lbl2 = new Label();
            Label lbl3 = new Label();
            Label lbl4 = new Label();
            Label lbl5 = new Label();
            Label lbl6 = new Label();
            Label lbl7 = new Label();
            Label lbl8 = new Label();
            Label lbl9 = new Label();
            Label lbl10 = new Label();
            colTxtBox += 1;
            lbl1.Width = label9.Width;
            lbl2.Width = label10.Width;
            lbl3.Width = label14.Width;
            lbl4.Width = label15.Width;
            lbl5.Width = label16.Width;
            lbl6.Width = label11.Width;
            lbl7.Width = label12.Width;
            lbl8.Width = label13.Width;
            lbl9.Width = label17.Width;
            lbl10.Width = label18.Width;
            lbl1.Height = label9.Height;
            lbl2.Height = label10.Height;
            lbl3.Height = label14.Height;
            lbl4.Height = label15.Height;
            lbl5.Height = label16.Height;
            lbl6.Height = label11.Height;
            lbl7.Height = label12.Height;
            lbl8.Height = label13.Height;
            lbl9.Height = label17.Height;
            lbl10.Height = label18.Height;

            lbl1.Text = "Релевантный ресурс";
            lbl2.Text = "Описатель";
            lbl3.Text = "Статус конвертора";
            lbl4.Text = "Статус конвертора начала";
            lbl5.Text = "Статус конвертора конца";
            lbl6.Text = "Предусловие";
            lbl7.Text = "Convert Event";
            lbl8.Text = "Convert Rule";
            lbl9.Text = "Convert Begin";
            lbl10.Text = "Convert End";
            lbl1.Location = new Point(label9.Location.X, label9.Location.Y + (colTxtBox - 1) * 230);
            lbl2.Location = new Point(label10.Location.X, label10.Location.Y + (colTxtBox - 1) * 230);
            lbl3.Location = new Point(label14.Location.X, label14.Location.Y + (colTxtBox - 1) * 230);
            lbl4.Location = new Point(label15.Location.X, label15.Location.Y + (colTxtBox - 1) * 230);
            lbl5.Location = new Point(label16.Location.X, label16.Location.Y + (colTxtBox - 1) * 230);
            lbl6.Location = new Point(label11.Location.X, label11.Location.Y + (colTxtBox - 1) * 230);
            lbl7.Location = new Point(label12.Location.X, label12.Location.Y + (colTxtBox - 1) * 230);
            lbl8.Location = new Point(label13.Location.X, label13.Location.Y + (colTxtBox - 1) * 230);
            lbl9.Location = new Point(label17.Location.X, label17.Location.Y + (colTxtBox - 1) * 230);
            lbl10.Location = new Point(label18.Location.X, label18.Location.Y + (colTxtBox - 1) * 230);
            this.Controls.Add(lbl1);
            this.Controls.Add(lbl2);
            this.Controls.Add(lbl3);
            this.Controls.Add(lbl4);
            this.Controls.Add(lbl5);
            this.Controls.Add(lbl6);
            this.Controls.Add(lbl7);
            this.Controls.Add(lbl8);
            this.Controls.Add(lbl9);
            this.Controls.Add(lbl10);
            listlbl1.Add(lbl1);
            listlbl2.Add(lbl2);
            listlbl3.Add(lbl3);
            listlbl4.Add(lbl4);
            listlbl5.Add(lbl5);
            listlbl6.Add(lbl6);
            listlbl7.Add(lbl7);
            listlbl8.Add(lbl8);
            listlbl9.Add(lbl9);
            listlbl10.Add(lbl10);

            TextBox txt1 = new TextBox();
            TextBox txt2 = new TextBox();
            TextBox txt3 = new TextBox();
            TextBox txt4 = new TextBox();
            TextBox txt5 = new TextBox();
            TextBox txt6 = new TextBox();

            ComboBox cmb1 = new ComboBox();
            ComboBox cmb2 = new ComboBox();
            ComboBox cmb3 = new ComboBox();
            ComboBox cmb4 = new ComboBox();

            txt1.Width = fldRelResName.Width;
            txt1.Height = fldRelResName.Height;
            txt2.Width = fldCondition.Width;
            txt2.Height = fldCondition.Height;
            txt3.Width = fldConvertEvent.Width;
            txt3.Height = fldConvertEvent.Height;
            txt4.Width = fldConvertRule.Width;
            txt4.Height = fldConvertRule.Height;
            txt5.Width = fldConvertBegin.Width;
            txt5.Height = fldConvertBegin.Height;
            txt6.Width = fldConvertEnd.Width;
            txt6.Height = fldConvertEnd.Height;

            cmb1.Width = cmbTypeNameW.Width;
            cmb1.Height = cmbTypeNameW.Height;
            cmb2.Width = cmbConvStatus.Width;
            cmb2.Height = cmbConvStatus.Height;
            cmb3.Width = cmbConvBegin.Width;
            cmb3.Height = cmbConvBegin.Height;
            cmb4.Width = cmbConvEnd.Width;
            cmb4.Height = cmbConvEnd.Height;

            for (int i = 0; i < ImModel.ListTypeResources.Count; i++)
            {
                cmb1.Items.Add(ImModel.ListTypeResources.ElementAt(i).TypeName);
            }

            cmb2.Items.AddRange(new string[] { "Не_изменять", "Сохранить" });
            cmb3.Items.AddRange(new string[] { "Не_изменять", "Сохранить" });
            cmb4.Items.AddRange(new string[] { "Не_изменять", "Сохранить" });

            txt1.Location = new Point(fldRelResName.Location.X, fldRelResName.Location.Y + (colTxtBox - 1) * 230);
            txt2.Location = new Point(fldCondition.Location.X, fldCondition.Location.Y + (colTxtBox - 1) * 230);
            txt3.Location = new Point(fldConvertEvent.Location.X, fldConvertEvent.Location.Y + (colTxtBox - 1) * 230);
            txt4.Location = new Point(fldConvertRule.Location.X, fldConvertRule.Location.Y + (colTxtBox - 1) * 230);
            txt5.Location = new Point(fldConvertBegin.Location.X, fldConvertBegin.Location.Y + (colTxtBox - 1) * 230);
            txt6.Location = new Point(fldConvertEnd.Location.X, fldConvertEnd.Location.Y + (colTxtBox - 1) * 230);
            cmb1.Location = new Point(cmbTypeNameW.Location.X, cmbTypeNameW.Location.Y + (colTxtBox - 1) * 230);
            cmb2.Location = new Point(cmbConvStatus.Location.X, cmbConvStatus.Location.Y + (colTxtBox - 1) * 230);
            cmb3.Location = new Point(cmbConvBegin.Location.X, cmbConvBegin.Location.Y + (colTxtBox - 1) * 230);
            cmb4.Location = new Point(cmbConvEnd.Location.X, cmbConvEnd.Location.Y + (colTxtBox - 1) * 230);

            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
            this.Controls.Add(txt3);
            this.Controls.Add(txt4);
            this.Controls.Add(txt5);
            this.Controls.Add(txt6);
            this.Controls.Add(cmb1);
            this.Controls.Add(cmb2);
            this.Controls.Add(cmb3);
            this.Controls.Add(cmb4);

            listtxt1.Add(txt1);
            listtxt2.Add(txt2);
            listtxt3.Add(txt3);
            listtxt4.Add(txt4);
            listtxt5.Add(txt5);
            listtxt6.Add(txt6);
            listcmb1.Add(cmb1);
            listcmb2.Add(cmb2);
            listcmb3.Add(cmb3);
            listcmb4.Add(cmb4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colTxtBox > 1)
            {
                this.Controls.Remove(listtxt1.ElementAt(listtxt1.Count - 1));
                listtxt1.RemoveAt(listtxt1.Count - 1);
                this.Controls.Remove(listtxt2.ElementAt(listtxt2.Count - 1));
                listtxt2.RemoveAt(listtxt2.Count - 1);
                this.Controls.Remove(listtxt3.ElementAt(listtxt3.Count - 1));
                listtxt3.RemoveAt(listtxt3.Count - 1);
                this.Controls.Remove(listtxt4.ElementAt(listtxt4.Count - 1));
                listtxt4.RemoveAt(listtxt4.Count - 1);
                this.Controls.Remove(listtxt5.ElementAt(listtxt5.Count - 1));
                listtxt5.RemoveAt(listtxt5.Count - 1);
                this.Controls.Remove(listtxt6.ElementAt(listtxt6.Count - 1));
                listtxt6.RemoveAt(listtxt6.Count - 1);
                this.Controls.Remove(listcmb1.ElementAt(listcmb1.Count - 1));
                listcmb1.RemoveAt(listcmb1.Count - 1);
                this.Controls.Remove(listcmb2.ElementAt(listcmb2.Count - 1));
                listcmb2.RemoveAt(listcmb2.Count - 1);
                this.Controls.Remove(listcmb3.ElementAt(listcmb3.Count - 1));
                listcmb3.RemoveAt(listcmb3.Count - 1);
                this.Controls.Remove(listcmb4.ElementAt(listcmb4.Count - 1));
                listcmb4.RemoveAt(listcmb4.Count - 1);

                this.Controls.Remove(listlbl1.ElementAt(listlbl1.Count - 1));
                listlbl1.RemoveAt(listlbl1.Count - 1);
                this.Controls.Remove(listlbl2.ElementAt(listlbl2.Count - 1));
                listlbl2.RemoveAt(listlbl2.Count - 1);
                this.Controls.Remove(listlbl3.ElementAt(listlbl3.Count - 1));
                listlbl3.RemoveAt(listlbl3.Count - 1);
                this.Controls.Remove(listlbl4.ElementAt(listlbl4.Count - 1));
                listlbl4.RemoveAt(listlbl4.Count - 1);
                this.Controls.Remove(listlbl5.ElementAt(listlbl5.Count - 1));
                listlbl5.RemoveAt(listlbl5.Count - 1);
                this.Controls.Remove(listlbl6.ElementAt(listlbl6.Count - 1));
                listlbl6.RemoveAt(listlbl6.Count - 1);
                this.Controls.Remove(listlbl7.ElementAt(listlbl7.Count - 1));
                listlbl7.RemoveAt(listlbl7.Count - 1);
                this.Controls.Remove(listlbl8.ElementAt(listlbl8.Count - 1));
                listlbl8.RemoveAt(listlbl8.Count - 1);
                this.Controls.Remove(listlbl9.ElementAt(listlbl9.Count - 1));
                listlbl9.RemoveAt(listlbl9.Count - 1);
                this.Controls.Remove(listlbl10.ElementAt(listlbl10.Count - 1));
                listlbl10.RemoveAt(listlbl10.Count - 1);

                colTxtBox--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check1 = true;
            bool check2 = true;
            bool check3 = true;
            bool check4 = true;
            bool check5 = true;

            int n = 0;
            int value;

            if (fldPatternName.Text == "")
            {
                MessageBox.Show("Вы не ввели имя образца операции!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (cmbPatternType.Text == "")
            {
                MessageBox.Show("Вы не выбрали тип операции!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (cmbTrase.Text == "")
            {
                MessageBox.Show("Вы не выбрали трассировку!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (cmbTypeTime.Text == "")
            {
                MessageBox.Show("Вы не выбрали тип времени!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            for (int i = 0; i<listtxt1.Count; i++)
            {
                if (listtxt1.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Не введено имя релевантного ресурса № " + (i+1) + " !", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check1 = false;
                }
            }

            for (int i = 0; i < listtxt1.Count; i++)
            {
                if (listcmb1.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Не выбран описатель для релевантного ресурса № " + (i + 1) + " !", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check1 = false;
                }
            }

            if ((cmbPatternType.Text != "Нерегулярное событие") && (cmbPatternType.Text != "Операция") && (cmbPatternType.Text != "Правило") && (cmbPatternType.Text != ""))
            {
                MessageBox.Show("Неверно выбран тип операции (должен быть Нерегулярное событие, Операция или Правило)!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check2 = false;
            }

            if ((cmbTrase.Text != "Да") && (cmbTrase.Text != "Нет") && (cmbTrase.Text != ""))
            {
                MessageBox.Show("Неверно выбрана трассировка!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check2 = false;
            }

            if ((cmbTypeTime.Text != "Точное") && (cmbTypeTime.Text != "Случайное") && (cmbTypeTime.Text != ""))
            {
                MessageBox.Show("Неверно выбран тип времени (должно быть Случайное или Точное)!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check2 = false;
            }

            for (int i = 0; i<listcmb1.Count; i++)
            {
                foreach (TypeResource c in ImModel.ListTypeResources)
                {
                    if (listcmb1.ElementAt(i).Text == c.TypeName)
                    {
                        n++;
                    }
                    else if (listcmb1.ElementAt(i).Text == "")
                    {
                        n++;
                    }
                }

                if (n==0)
                {
                    MessageBox.Show("Для релевантного ресурса № " + (i+1) + " неверно выбран описатель: такого типа ресурсов нет!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check2 = false;
                }

                n = 0;
            }

            if (cmbTypeTime.Text == "Точное" && fldTimeValue.Text == "")
            {
                MessageBox.Show("Для точного типа времени не может быть пустое значение времени!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }


            if ((cmbTypeTime.Text == "Точное") && (fldTimeValue.Text != "") && (!Int32.TryParse(fldTimeValue.Text, out value)))
            {
                MessageBox.Show("Для точного типа времени заданное значение времени не является числом!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }

            if ((cmbTypeTime.Text == "Точное") && ((cmbLaw.Text != "") || (fldBeginInt.Text != "") || (fldEndInt.Text != "")))
            {
                MessageBox.Show("Для точного типа времени нельзя указывать закон, начало и конец интервала!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }

            if ((cmbTypeTime.Text == "Случайное") && (cmbLaw.Text == ""))
            {
                MessageBox.Show("Для случайного типа времени не задан закон!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }


            if ((cmbTypeTime.Text == "Случайное") && (cmbLaw.Text != "") && (cmbLaw.Text != "@normal") && (cmbLaw.Text != "@uniform") && (cmbLaw.Text != "@exponential@"))
            {
                MessageBox.Show("Для случайного типа времени неверно задан закон!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }

            if ((cmbTypeTime.Text == "Случайное") && (fldBeginInt.Text == ""))
            {
                MessageBox.Show("Для случайного типа времени не задано начало интервала!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }

            if ((cmbTypeTime.Text == "Случайное") && (fldEndInt.Text == ""))
            {
                MessageBox.Show("Для случайного типа времени не задан конец интервала!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }

            if ((cmbTypeTime.Text == "Случайное") && (fldBeginInt.Text != "") && (!Int32.TryParse(fldBeginInt.Text, out value)))
            {
                MessageBox.Show("Для случайного типа времени заданное значение начала интервала не является числом!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }

            if ((cmbTypeTime.Text == "Случайное") && (fldEndInt.Text != "") && (!Int32.TryParse(fldEndInt.Text, out value)))
            {
                MessageBox.Show("Для случайного типа времени заданное значение конца интервала не является числом!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }

            if ((cmbTypeTime.Text == "Случайное") && (fldTimeValue.Text != ""))
            {
                MessageBox.Show("Для случайного типа времени нельзя задавать конкретное значение времени!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check3 = false;
            }

            for (int i = 0; i < listcmb2.Count; i ++)
            {
                if (cmbPatternType.Text == "Нерегулярное событие" &&  listcmb2.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для нерегулярного события необходимо задать статус конвертора! Не задан для релевантного ресурса № " + (i+1), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb2.Count; i++)
            {
                if (cmbPatternType.Text == "Нерегулярное событие" && listcmb2.ElementAt(i).Text != "Сохранить" && listcmb2.ElementAt(i).Text != "Не_изменять" && listcmb2.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для нерегулярного события неверно задан статус конвертора (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb2.Count; i++)
            {
                if (cmbPatternType.Text == "Нерегулярное событие" && (listcmb3.ElementAt(i).Text != "" || listcmb4.ElementAt(i).Text != ""))
                {
                    MessageBox.Show("Для нерегулярного события нельзя задавать статус конвертора начала или конца (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb2.Count; i++)
            {
                if (cmbPatternType.Text == "Правило" && listcmb2.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для правила необходимо задать статус конвертора! Не задан для релевантного ресурса № " + (i + 1), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb2.Count; i++)
            {
                if (cmbPatternType.Text == "Правило" && listcmb2.ElementAt(i).Text != "Сохранить" && listcmb2.ElementAt(i).Text != "Не_изменять" && listcmb2.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для правила неверно задан статус конвертора (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb2.Count; i++)
            {
                if (cmbPatternType.Text == "Правило" && (listcmb3.ElementAt(i).Text != "" || listcmb4.ElementAt(i).Text != ""))
                {
                    MessageBox.Show("Для правила нельзя задавать статус конвертора начала или конца (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb3.Count; i++)
            {
                if (cmbPatternType.Text == "Операция" && listcmb3.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для операции необходимо задать статус конвертора начала! Не задан для релевантного ресурса № " + (i + 1), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb3.Count; i++)
            {
                if (cmbPatternType.Text == "Операция" && listcmb3.ElementAt(i).Text != "Сохранить" && listcmb3.ElementAt(i).Text != "Не_изменять" && listcmb3.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для операции неверно задан статус конвертора начала(релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb4.Count; i++)
            {
                if (cmbPatternType.Text == "Операция" && listcmb4.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для операции необходимо задать статус конвертора конца! Не задан для релевантного ресурса № " + (i + 1), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb4.Count; i++)
            {
                if (cmbPatternType.Text == "Операция" && listcmb4.ElementAt(i).Text != "Сохранить" && listcmb4.ElementAt(i).Text != "Не_изменять" && listcmb4.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для операции неверно задан статус конвертора конца(релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }

            for (int i = 0; i < listcmb2.Count; i++)
            {
                if (cmbPatternType.Text == "Операция" && listcmb2.ElementAt(i).Text != "" )
                {
                    MessageBox.Show("Для операции нельзя задавать статус конвертора (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check4 = false;
                }
            }


            for (int i = 0; i<listtxt2.Count; i++)
            {
                if (cmbPatternType.Text == "Нерегулярное событие" && listtxt2.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для нерегулярного события нельзя задавать предусловие! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Правило" && listtxt2.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для правила необходимо задавать предусловие! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Операция" && listtxt2.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для операции необходимо задавать предусловие! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }
            }

            for (int i = 0; i < listtxt3.Count; i++)
            {
                if (cmbPatternType.Text == "Нерегулярное событие" && listtxt3.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для нерегулярного события необходимо описать действия в convert Event! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Правило" && listtxt3.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для правила нельзя описывать действия в Convert Event! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Операция" && listtxt3.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для операции нельзя описывать действия в Convert Event! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }
            }

            for (int i = 0; i < listtxt4.Count; i++)
            {
                if (cmbPatternType.Text == "Нерегулярное событие" && listtxt4.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для нерегулярного события нельзя задавать действия в Convert Rule! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Правило" && listtxt4.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для правила необходимо задавать действия в Convert Rule! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Операция" && listtxt4.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для операции нельзя задавать действия в Convert Rule! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }
            }

            for (int i = 0; i < listtxt5.Count; i++)
            {
                if (cmbPatternType.Text == "Нерегулярное событие" && listtxt5.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для нерегулярного события нельзя задавать действия в Convert Begin! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Правило" && listtxt5.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для правила нельзя задавать действия в Convert Begin! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Операция" && listtxt5.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для операции необходимо задавать начальные действия в Convert Begin! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }
            }

            for (int i = 0; i < listtxt6.Count; i++)
            {
                if (cmbPatternType.Text == "Нерегулярное событие" && listtxt6.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для нерегулярного события нельзя задавать действия в Convert End! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Правило" && listtxt6.ElementAt(i).Text != "")
                {
                    MessageBox.Show("Для правила нельзя задавать действия в Convert End! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }

                if (cmbPatternType.Text == "Операция" && listtxt6.ElementAt(i).Text == "")
                {
                    MessageBox.Show("Для операции необходимо задавать конечные действия в Convert End! (релевантный ресурс № " + (i + 1) + " )", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    check5 = false;
                }
            }

            if ((check1 == true) && (check2 == true) && (check3 == true) && (check4 == true) && (check5 == true))
            {
                List<string> RelResName = new List<string>();
                List<string> TypeNameW = new List<string>();
                List<string> ConvStatus = new List<string>();
                List<string> ConvBegin = new List<string>();
                List<string> ConvEnd = new List<string>();
                List<string> Condition = new List<string>();
                List<string> ConvertEvent = new List<string>();
                List<string> ConvertRule = new List<string>();
                List<string> ConvertBegin = new List<string>();
                List<string> ConvertEnd = new List<string>();

                foreach (TextBox t1 in listtxt1)
                {
                    RelResName.Add(t1.Text);
                }

                foreach (TextBox t2 in listtxt2)
                {
                    Condition.Add(t2.Text);
                }

                foreach (TextBox t3 in listtxt3)
                {
                    ConvertEvent.Add(t3.Text);
                }

                foreach (TextBox t4 in listtxt4)
                {
                    ConvertRule.Add(t4.Text);
                }

                foreach (TextBox t5 in listtxt5)
                {
                    ConvertBegin.Add(t5.Text);
                }

                foreach (TextBox t6 in listtxt6)
                {
                    ConvertEnd.Add(t6.Text);
                }

                foreach (ComboBox c1 in listcmb1)
                {
                    TypeNameW.Add(c1.Text);
                }

                foreach (ComboBox c2 in listcmb2)
                {
                    ConvStatus.Add(c2.Text);
                }

                foreach (ComboBox c3 in listcmb3)
                {
                    ConvBegin.Add(c3.Text);
                }

                foreach (ComboBox c4 in listcmb4)
                {
                    ConvEnd.Add(c4.Text);
                }
                PatternOperation ptr1 = new PatternOperation(fldPatternName.Text, cmbPatternType.Text, cmbTrase.Text, cmbTypeTime.Text, fldTimeValue.Text, cmbLaw.Text, fldBeginInt.Text, fldEndInt.Text, RelResName, TypeNameW, ConvStatus, ConvBegin, ConvEnd, Condition, ConvertEvent, ConvertRule, ConvertBegin, ConvertEnd);
                ImModel.ListPatternOperations.Add(ptr1);
                MessageBox.Show("Образец операции '" + fldPatternName.Text + "' успешно создан!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
        }
    }
}
