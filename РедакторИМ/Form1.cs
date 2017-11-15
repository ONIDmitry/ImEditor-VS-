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
using System.IO;

namespace ImEditor
{
    public partial class Form1 : Form
    {
        public static int StringCount = 0;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i< ImModel.ListTypeResources.Count; i ++ )
            {
                cmbTypeResources.Items.Add(ImModel.ListTypeResources.ElementAt(i).TypeName);
            }

            for (int i = 0; i < ImModel.ListResources.Count; i++)
            {
                cmbResources.Items.Add(ImModel.ListResources.ElementAt(i).ResourceName);
            }

            for (int i = 0; i < ImModel.ListPatternOperations.Count; i++)
            {
                cmbPatternOperations.Items.Add(ImModel.ListPatternOperations.ElementAt(i).PatternName);
            }

            for (int i = 0; i < ImModel.ListOperations.Count; i++)
            {
                cmbOperations.Items.Add(ImModel.ListOperations.ElementAt(i).OperationName);
            }
        }

        private void типРесурсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void ресурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImModel.ListTypeResources.Count == 0)
            {
                MessageBox.Show("Сначала создайте хотя бы один тип ресурсов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
        }

        private void сгенерироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("D:\\ImModel.xml", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("<Модель>");

            for (int i = 0; i<ImModel.ListTypeResources.Count; i++)
            {
                writer.Write("       ");
                writer.WriteLine("<Тип_ресурсов Имя_типа_ресурсов=\"" + ImModel.ListTypeResources.ElementAt(i).TypeName + "\" Вид_типа_ресурсов=\"" + ImModel.ListTypeResources.ElementAt(i).TempValue + "\">");
                for (int j=0; j<ImModel.ListTypeResources.ElementAt(i).ParamName.Count; j++)
                {
                    writer.Write("               ");
                    writer.WriteLine("<Параметр_типа Имя_параметра=\"" + ImModel.ListTypeResources.ElementAt(i).ParamName.ElementAt(j) +"\" Тип_параметра=\"" + ImModel.ListTypeResources.ElementAt(i).ParamType.ElementAt(j) + ImModel.ListTypeResources.ElementAt(i).ParamVariant.ElementAt(j) + "\" Умолчание=\"" + ImModel.ListTypeResources.ElementAt(i).ParamDefault.ElementAt(j) + "\"/>");
                }
                writer.Write("       ");
                writer.WriteLine("</Тип_ресурсов>");
            }
            writer.WriteLine();

            for (int i = 0; i<ImModel.ListResources.Count; i ++)
            {
                writer.Write("       ");
                writer.Write("<Ресурс Имя_ресурса=\"" + ImModel.ListResources.ElementAt(i).ResourceName + "\" Имя_типа_ресурсов=\"" + ImModel.ListResources.ElementAt(i).TypeName + "\" Трассировка=\""+ ImModel.ListResources.ElementAt(i).TraseValue + "\" Начальные_значения=\"{");
                for (int j = 0; j < ImModel.ListResources.ElementAt(i).ParamValue.Count; j ++)
                {
                    writer.Write(ImModel.ListResources.ElementAt(i).ParamValue.ElementAt(j));

                    if (j != (ImModel.ListResources.ElementAt(i).ParamValue.Count - 1))
                    {
                        writer.Write(", ");
                    }
                }

                writer.WriteLine("}\"/>");
            }

            writer.WriteLine();

            for (int i = 0; i<ImModel.ListPatternOperations.Count; i ++)
            {
                writer.WriteLine("<Образец_операции Имя_образца=\"" + ImModel.ListPatternOperations.ElementAt(i).PatternName + "\" Тип_образца=\""+ ImModel.ListPatternOperations.ElementAt(i).PatternType +"\" Трассировка=\"" + ImModel.ListPatternOperations.ElementAt(i).PatternTrace +"\">");

                for (int j = 0; j<ImModel.ListPatternOperations.ElementAt(i).RelResName.Count; j++)
                {
                    writer.Write("                ");
                    writer.WriteLine("<Релевантный_ресурс Имя_релевантного_ресурса=\"" + ImModel.ListPatternOperations.ElementAt(i).RelResName.ElementAt(j) + "\" Описатель=\"" + ImModel.ListPatternOperations.ElementAt(i).TypeNameW.ElementAt(j) + "\" Статус_конвертора=\"" + ImModel.ListPatternOperations.ElementAt(i).ConvStatus.ElementAt(j) + "\" Статус_конвертора_начала=\"" + ImModel.ListPatternOperations.ElementAt(i).ConvBegin.ElementAt(j) + "\" Статус_конвертора_конца=\"" + ImModel.ListPatternOperations.ElementAt(i).ConvEnd.ElementAt(j) + "\"/>");
                }

                writer.Write("                ");
                writer.WriteLine("<Время Тип=\"" + ImModel.ListPatternOperations.ElementAt(i).TypeTime + "\" Закон=\"" + ImModel.ListPatternOperations.ElementAt(i).TimeLaw + "\" Значение=\"" + ImModel.ListPatternOperations.ElementAt(i).TimeValue + "\" Начало_интервала=\"" + ImModel.ListPatternOperations.ElementAt(i).StartInt + "\" Конец_интервала=\"" + ImModel.ListPatternOperations.ElementAt(i).EndInt + "\"/>");

                writer.Write("                ");
                writer.WriteLine("<Тело_образца>");
            
                for (int k=0; k<ImModel.ListPatternOperations.ElementAt(i).RelResName.Count; k++)
                {
                    writer.Write("                        ");
                    writer.WriteLine("<Релевантный_ресурс Имя_релевантного_ресурса=\"" + ImModel.ListPatternOperations.ElementAt(i).RelResName.ElementAt(k) + "\">");
                    writer.Write("                        ");
                    writer.WriteLine("<Правило_использования Предусловие=\"" + ImModel.ListPatternOperations.ElementAt(i).Condition.ElementAt(k) + "\" Convert_event=\"" + ImModel.ListPatternOperations.ElementAt(i).ConvertEvent.ElementAt(k)  + "\" Convert_rule=\"" + ImModel.ListPatternOperations.ElementAt(i).ConvertRule.ElementAt(k) + "\" Convert_begin=\"" + ImModel.ListPatternOperations.ElementAt(i).ConvertBegin.ElementAt(k) + "\" Convert_end=\"" + ImModel.ListPatternOperations.ElementAt(i).ConvertEnd.ElementAt(k) + "\"/>");
                    writer.Write("                        ");
                    writer.WriteLine("</Релевантный_ресурс>");

                }
                writer.Write("                ");
                writer.WriteLine("</Тело_образца>");
                writer.Write("         ");
                writer.WriteLine("</Образец_операции>");
                writer.WriteLine("");
            }

            for (int i = 0; i < ImModel.ListOperations.Count; i++)
            {
                writer.Write("        ");
                writer.Write("<Операция Имя_операции=\"" + ImModel.ListOperations.ElementAt(i).OperationName + "\" Имя_образца=\"" + ImModel.ListOperations.ElementAt(i).PatternName + "\" Тело_операции=\"" + ImModel.ListOperations.ElementAt(i).PatternName + "(");

                for (int j = 0; j < ImModel.ListOperations.ElementAt(i).ResourceNames.Count; j ++)
                {
                    writer.Write(ImModel.ListOperations.ElementAt(i).ResourceNames.ElementAt(j));

                    if (j != ImModel.ListOperations.ElementAt(i).ResourceNames.Count - 1)
                    {
                        writer.Write(", ");
                    }
                }
                writer.WriteLine(");\"/>");
            } 

            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine();
            writer.Write("        ");
            writer.WriteLine("<Функция Имя_функции=\"\" Возвращаемый_тип =\"\" Тело_функции=\"\" > ");
            writer.Write("               ");
            writer.WriteLine("<Параметр_функции Имя_параметра_функции=\"\" Тип_параметра_функции=\"\" />");
            writer.Write("        ");
            writer.WriteLine("</Функция>");
            writer.WriteLine();
            writer.WriteLine("</Модель>");
            writer.Close();
        }

        private void образецОперацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImModel.ListTypeResources.Count == 0)
            {
                MessageBox.Show("Сначала создайте хотя бы один тип ресурсов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Form4 frm4 = new Form4();
                frm4.Show();
            }           
        }

        private void операциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImModel.ListPatternOperations.Count == 0)
            {
                MessageBox.Show("Сначала создайте хотя бы один образец операции!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Form5 frm5 = new Form5();
                frm5.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check1 = true;
            int n = 0;
            int k = 0;

            if (cmbTypeResources.Text == "")
            {
                MessageBox.Show("Вы не выбрали тип ресурсов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }
         
            for (int  i = 0; i< ImModel.ListTypeResources.Count; i++)
            {
                if ((cmbTypeResources.Text == ImModel.ListTypeResources.ElementAt(i).TypeName) || (cmbTypeResources.Text == ""))
                {
                    n++;
                }
            }

            if ((n == 0) && (cmbTypeResources.Text != ""))
            {
                MessageBox.Show("Такого типа ресурсов нет!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (check1 == true)
            {
                for (int i = 0; i < ImModel.ListTypeResources.Count; i++)
                {
                    if (cmbTypeResources.Text == ImModel.ListTypeResources.ElementAt(i).TypeName) 
                    {
                        k = i;
                    }
                }

                ImModel.ChosenTypeResource = cmbTypeResources.Text;
                ImModel.NumberChosenTypeResource = k;
                Form6 frm6 = new Form6();
                frm6.Show();
            }         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmbTypeResources.BeginUpdate();
            cmbTypeResources.Items.Clear();
            for (int i = 0; i < ImModel.ListTypeResources.Count; i++)
            {
                cmbTypeResources.Items.Add(ImModel.ListTypeResources.ElementAt(i).TypeName);
            }
            cmbTypeResources.Text = "";
            cmbTypeResources.EndUpdate();

            cmbResources.BeginUpdate();
            cmbResources.Items.Clear();
            for (int i = 0; i < ImModel.ListResources.Count; i++)
            {
                cmbResources.Items.Add(ImModel.ListResources.ElementAt(i).ResourceName);
            }
            cmbResources.Text = "";
            cmbResources.EndUpdate();

            cmbPatternOperations.BeginUpdate();
            cmbPatternOperations.Items.Clear();
            for (int i = 0; i < ImModel.ListPatternOperations.Count; i++)
            {
                cmbPatternOperations.Items.Add(ImModel.ListPatternOperations.ElementAt(i).PatternName);
            }
            cmbPatternOperations.Text = "";
            cmbPatternOperations.EndUpdate();

            cmbOperations.BeginUpdate();
            cmbOperations.Items.Clear();
            for (int i = 0; i < ImModel.ListOperations.Count; i++)
            {
                cmbOperations.Items.Add(ImModel.ListOperations.ElementAt(i).OperationName);
            }
            cmbOperations.Text = "";
            cmbOperations.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check1 = true;
            int n = 0;
            int k = 0;

            if (cmbResources.Text == "")
            {
                MessageBox.Show("Вы не выбрали ресурс!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            for (int i = 0; i < ImModel.ListResources.Count; i++)
            {
                if ((cmbResources.Text == ImModel.ListResources.ElementAt(i).ResourceName) || (cmbResources.Text == ""))
                {
                    n++;
                }
            }

            if ((n == 0) && (cmbResources.Text != ""))
            {
                MessageBox.Show("Такого ресурса нет!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (check1 == true)
            {
                for (int i = 0; i < ImModel.ListResources.Count; i++)
                {
                    if (cmbResources.Text == ImModel.ListResources.ElementAt(i).ResourceName)
                    {
                        k = i;
                    }
                }

                ImModel.ChosenResource = cmbResources.Text;
                ImModel.NumberChosenResource = k;
                Form7 frm7 = new Form7();
                frm7.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool check1 = true;
            int n = 0;
            int k = 0;

            if (cmbPatternOperations.Text == "")
            {
                MessageBox.Show("Вы не выбрали образец операции!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            for (int i = 0; i < ImModel.ListPatternOperations.Count; i++)
            {
                if ((cmbPatternOperations.Text == ImModel.ListPatternOperations.ElementAt(i).PatternName) || (cmbPatternOperations.Text == ""))
                {
                    n++;
                }
            }

            if ((n == 0) && (cmbPatternOperations.Text != ""))
            {
                MessageBox.Show("Такого образца операций нет!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (check1 == true)
            {
                for (int i = 0; i < ImModel.ListPatternOperations.Count; i++)
                {
                    if (cmbPatternOperations.Text == ImModel.ListPatternOperations.ElementAt(i).PatternName)
                    {
                        k = i;
                    }
                }

                ImModel.ChosenPatternOperation = cmbPatternOperations.Text;
                ImModel.NumberChosenPatternOperation = k;
                Form8 frm8 = new Form8();
                frm8.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check1 = true;
            int n = 0;
            int k = 0;

            if (cmbOperations.Text == "")
            {
                MessageBox.Show("Вы не выбрали операцию!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            for (int i = 0; i < ImModel.ListOperations.Count; i++)
            {
                if ((cmbOperations.Text == ImModel.ListOperations.ElementAt(i).OperationName) || (cmbOperations.Text == ""))
                {
                    n++;
                }
            }

            if ((n == 0) && (cmbOperations.Text != ""))
            {
                MessageBox.Show("Такой операции нет!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                check1 = false;
            }

            if (check1 == true)
            {
                for (int i = 0; i < ImModel.ListOperations.Count; i++)
                {
                    if (cmbOperations.Text == ImModel.ListOperations.ElementAt(i).OperationName)
                    {
                        n++;
                    }
                }

                ImModel.ChosenOperation = cmbOperations.Text;
                ImModel.NumberChosenOperation = k;
                Form9 frm9 = new Form9();
                frm9.Show();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ImModel.ListTypeResources.Clear();
            ImModel.ListResources.Clear();
            ImModel.ListPatternOperations.Clear();
            ImModel.ListOperations.Clear();

            string FileNameString = " ";
            string begin = "\"";
            string end = "\"";

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML Files|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileNameString = dlg.FileName;
            }
            else
            {
                FileNameString = "D:\\ImModel.xml";
            }

                FileStream OpenFile = new FileStream(FileNameString, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(OpenFile);

            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                StringCount += 1;
                if (s.Contains("<Тип_ресурсов"))
                {
                    string TypeName = "";
                    string TraseValue = "Да";
                    string TempValue = "";
                    int n = 0;
                    List<string> ParamName = new List<string>();
                    List<string> ParamType = new List<string>();
                    List<string> ParamVariant = new List<string>();
                    List<string> ParamDefault = new List<string>();
                    n = s.IndexOf(begin);
                    if (n>=0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения имени типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        TypeName = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения имени типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения вида типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        TempValue = s.Substring(0, n);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения вида типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    s = reader.ReadLine();
                    StringCount += 1;
                    while (!s.Contains("</Тип_ресурсов>"))
                    {
                        string p;
                        string t;
                        n = s.IndexOf(begin);
                        if (n >= 0)
                        {
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ начала \"\" для определения имени параметра типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(end);
                        if (n >= 0)
                        {
                            p = s.Substring(0, n);
                            ParamName.Add(p);
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ конца \"\" для определения имени параметра типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(begin);
                        if (n >= 0)
                        {
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ начала \"\" для определения типа параметра типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(end);
                        if (n >= 0)
                        {
                            p = s.Substring(0, n);
                            if ((p.Contains("Enum")) || (p.Contains("enum")))
                            {
                                n = p.IndexOf("{");
                                if (n >= 0)
                                {
                                    ParamType.Add("Enum");
                                    p = p.Remove(0, n);
                                }
                                else
                                {
                                    MessageBox.Show("Не найден символ { начала описания возможных значений для типа Enum в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                n = p.IndexOf("}");
                                if (n >= 0)
                                {
                                    t = p.Substring(0, n + 1);
                                    ParamVariant.Add(t);
                                }
                                else
                                {
                                    MessageBox.Show("Не найден символ } окончания написания возможных значений для типа Enum в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                ParamType.Add(p);
                                ParamVariant.Add("");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Не найден символ конца \"\" для определения типа параметра типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        n = s.IndexOf(end);
                        if (n >= 0)
                        {
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ конца \"\" для определения типа параметра типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(begin);
                        if (n >= 0)
                        {
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ начала \"\" для определения начального значения параметра типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(end);
                        if (n >= 0)
                        {
                            p = s.Substring(0, n);
                            ParamDefault.Add(p);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ конца \"\" для определения начального значения параметра типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        s = reader.ReadLine();
                        StringCount += 1;
                    }

                    TypeResource type1 = new TypeResource(TypeName, TraseValue, TempValue, ParamName, ParamType, ParamVariant, ParamDefault);
                    ImModel.ListTypeResources.Add(type1);
                }

                if (s.Contains("Ресурс"))
                {
                    int n = 0;
                    string p;
                    string ResourceName = "";
                    string TypeName = "";
                    string TraseValue = "";
                    List<string> ParamValue = new List<string>();
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения имени ресурса в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        ResourceName = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения имени ресурса в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения имени типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        TypeName = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения имени типа ресурсов в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения трассировки ресурса в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        TraseValue = s.Substring(0, n);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения трассировки ресурса в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf("{");
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат определения начальных значений ресурса в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    while (s.Contains(","))
                    {
                        n = s.IndexOf(",");
                        if (n >= 0)
                        {
                            p = s.Substring(0, n);
                            if (p.IndexOf(" ") == 0)
                            {
                                p = p.Substring(1, p.Count() - 1);
                            }
                            ParamValue.Add(p);
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Неверный формат определения начальных значений ресурса в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    n = s.IndexOf("}");
                    if (n >= 0)
                    {
                        p = s.Substring(0, n);
                        if (p.IndexOf(" ") == 0)
                        {
                            p = p.Substring(1, p.Count() - 1);
                        }
                        ParamValue.Add(p);
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат определения начальных значений ресурса в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    Resource rs1 = new Resource(TypeName, ResourceName, ParamValue, TraseValue);
                    ImModel.ListResources.Add(rs1);
                }

                if (s.Contains("<Образец_операции"))
                {
                    int n = 0;
                    string PatternName = "";
                    string PatternType = "";
                    string PatternTrace = "";
                    string TypeTime = "";
                    string TimeValue = "";
                    string TimeLaw = "";
                    string StartInt = "";
                    string EndInt = "";
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

                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения имени образца операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        PatternName = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения имени образца операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения типа образца операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        PatternType = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения типа образца операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения трассировки образца операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        PatternTrace = s.Substring(0, n);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения трассировки образца операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    s = reader.ReadLine();
                    StringCount += 1;

                    while (s.Contains("<Релевантный_ресурс "))
                    {
                        n = s.IndexOf(begin);
                        if (n >= 0)
                        {
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ начала \"\" для определения имени релевантного ресурса в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(end);
                        if (n >= 0)
                        {
                            RelResName.Add(s.Substring(0, n));
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ конца \"\" для определения имени релевантного ресурса в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(begin);
                        if (n >= 0)
                        {
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ начала \"\" для определения описателя в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(end);
                        if (n >= 0)
                        {
                            TypeNameW.Add(s.Substring(0, n));
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ конца \"\" для определения описателя в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(begin);
                        if (n >= 0)
                        {
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ начала \"\" для определения статуса конвертора в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(end);
                        if (n >= 0)
                        {
                            ConvStatus.Add(s.Substring(0, n));
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ конца \"\" для определения статуса конвертора в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(begin);
                        if (n >= 0)
                        {
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ начала \"\" для определения статуса конвертора начала в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(end);
                        if (n >= 0)
                        {
                            ConvBegin.Add(s.Substring(0, n));
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ конца \"\" для определения статуса конвертора начала в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(begin);
                        if (n >= 0)
                        {
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ начала \"\" для определения статуса конвертора конца в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        n = s.IndexOf(end);
                        if (n >= 0)
                        {
                            ConvEnd.Add(s.Substring(0, n));
                        }
                        else
                        {
                            MessageBox.Show("Не найден символ конца \"\" для определения статуса конвертора конца в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        s = reader.ReadLine();
                        StringCount += 1;
                    }

                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения типа времени в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        TypeTime = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения типа времени в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения закона времени в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        TimeLaw = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения закона времени в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения значения времени в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        TimeValue = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения значения времени в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения начала интервала в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        StartInt = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения начала интервала в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения конца интервала в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        EndInt = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения конца интервала в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    s = reader.ReadLine();
                    StringCount += 1;

                    while (!s.Contains("</Образец_операции>"))
                    {
                        if (s.Contains("<Правило_использования"))
                        {
                            n = s.IndexOf(begin);
                            if (n >= 0)
                            {
                                s = s.Remove(0, n + 1);
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ начала \"\" для определения действий в предусловии в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            n = s.IndexOf(end);
                            if (n >= 0)
                            {
                                Condition.Add(s.Substring(0, n));
                                s = s.Remove(0, n + 1);
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ конца \"\" для определения действий в предусловии в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            n = s.IndexOf(begin);
                            if (n >= 0)
                            {
                                s = s.Remove(0, n + 1);
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ начала \"\" для определения действий в ConvertEvent в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            n = s.IndexOf(end);
                            if (n >= 0)
                            {
                                ConvertEvent.Add(s.Substring(0, n));
                                s = s.Remove(0, n + 1);
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ конца \"\" для определения действий в ConvertEvent в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            n = s.IndexOf(begin);
                            if (n >= 0)
                            {
                                s = s.Remove(0, n + 1);
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ начала \"\" для определения действий в ConvertRule в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            n = s.IndexOf(end);
                            if (n >= 0)
                            {
                                ConvertRule.Add(s.Substring(0, n));
                                s = s.Remove(0, n + 1);
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ конца \"\" для определения действий в ConvertRule в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            n = s.IndexOf(begin);
                            if (n >= 0)
                            {
                                s = s.Remove(0, n + 1);
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ начала \"\" для определения действий в ConvertBegin в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            n = s.IndexOf(end);
                            if (n >= 0)
                            {
                                ConvertBegin.Add(s.Substring(0, n));
                                s = s.Remove(0, n + 1);
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ конца \"\" для определения действий в ConvertBegin в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            n = s.IndexOf(begin);
                            if (n >= 0)
                            {
                                s = s.Remove(0, n + 1);
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ начала \"\" для определения действий в ConvertEnd в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            n = s.IndexOf(end);
                            if (n >= 0)
                            {
                                ConvertEnd.Add(s.Substring(0, n));
                            }
                            else
                            {
                                MessageBox.Show("Не найден символ конца \"\" для определения действий в ConvertEnd в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            s = reader.ReadLine();
                            StringCount += 1;
                        }
                        else
                        {
                            s = reader.ReadLine();
                            StringCount += 1;
                        }                      
                    }

                    PatternOperation ptr1 = new PatternOperation(PatternName, PatternType, PatternTrace, TypeTime, TimeValue, TimeLaw, StartInt, EndInt, RelResName, TypeNameW, ConvStatus, ConvBegin, ConvEnd, Condition, ConvertEvent, ConvertRule, ConvertBegin, ConvertEnd);
                    ImModel.ListPatternOperations.Add(ptr1);
                }

                if (s.Contains("<Операция"))
                {
                    int n = 0;
                    string p;
                    string OperationName = "";
                    string PatternName = "";
                    List<string> ResourceNames = new List<string>();

                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения имени операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        OperationName = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ конца \"\" для определения имени операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(begin);
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения имени образца операций в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf(end);
                    if (n >= 0)
                    {
                        PatternName = s.Substring(0, n);
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Не найден символ начала \"\" для определения имени образца операций в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    n = s.IndexOf("(");
                    if (n >= 0)
                    {
                        s = s.Remove(0, n + 1);
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат описания ресурсов, релевантных в операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    while (s.Contains(","))
                    {
                        n = s.IndexOf(",");
                        if (n >= 0)
                        {
                            p = s.Substring(0, n);
                            ResourceNames.Add(p);
                            s = s.Remove(0, n + 1);
                        }
                        else
                        {
                            MessageBox.Show("Неверный формат описания ресурсов, релевантных в операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    n = s.IndexOf(")");
                    if (n >= 0)
                    {
                        p = s.Substring(0, n);
                        ResourceNames.Add(p);
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат описания ресурсов, релевантных в операции в строке номер " + StringCount, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    Operation op1 = new Operation(OperationName, PatternName, ResourceNames);
                    ImModel.ListOperations.Add(op1);

                }
            }
            reader.Close();
            OpenFile.Close();
        }
    }
}
