using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsApp1;

namespace ADITYASINGHSAUD19030698
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public void List()
        {
            string json = Utility2.Read();
            try
            {
                List<VisitorDetail> lst = JsonConvert.DeserializeObject<List<VisitorDetail>>(json);
                dataGridView1.DataSource = lst;
            }
            catch (Exception ex)
            {

            }

        }

        public Form2()
        {
            InitializeComponent();
            List();
        }

        public void ID()
        {
            string json = Utility2.Read();
            try
            {
                List<VisitorDetail> lst = JsonConvert.DeserializeObject<List<VisitorDetail>>(json);
                for (var j = 0; j < lst.Count; j++)
                {
                    lst[j].ID = (j + 1).ToString();

                }
                string data = JsonConvert.SerializeObject(lst);
                data = JsonConvert.SerializeObject(lst);
                string outfromUtility = Utility2.Write(data);
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            Regex r = new Regex("^[0-9]{10}");
            Regex x = new Regex(@"^[A-Z][a-z]*(\s[A-Z][a-z]*)+$");
            bool isValid = r.IsMatch(textBox3.Text);

            if (textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedIndex == -1 || comboBox2.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please don't leave empty spaces !", "404", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (Int32.TryParse(textBox8.Text, out number).Equals(false))
            {

                MessageBox.Show("Invalid Price!", "404", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (!x.IsMatch(textBox2.Text))
            {
                MessageBox.Show("Plese provide Correct Name", "404", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
            else if (!isValid)
            {
                MessageBox.Show("Plese Give Correct Contact Number", "404", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }

            else
            {
                string id = textBox1.Text;
                string name = textBox2.Text;
                int contact = int.Parse(textBox3.Text);
                string agegroup = comboBox1.Text;
                string groupof = comboBox2.Text;
                string intime = textBox6.Text;
                string outtime = textBox7.Text;
                int price = int.Parse(textBox8.Text);
                string datentime = dateTimePicker1.Value.ToString();

                VisitorDetail P = new VisitorDetail();
                P.ID = id;
                P.Name = name;
                P.Contact = contact;
                P.AgeGroup = agegroup;
                P.GroupOf = groupof;
                P.Intime = intime;
                P.Etime = outtime;
                P.Price = price;
                P.Date = datentime;

                string json = Utility2.Read();

                List<VisitorDetail> lst = new List<VisitorDetail>();
                if (json != null && json != "")
                {
                    lst = JsonConvert.DeserializeObject<List<VisitorDetail>>(json);
                }
                lst.Add(P);
                string data = JsonConvert.SerializeObject(lst);
                string outfromUtility = Utility2.Write(data);
                MessageBox.Show(outfromUtility);
                if (checkBox1.Checked)
                {
                    ID();
                }
                List();


                comboBox1.Text = string.Empty;
                comboBox2.Text = string.Empty;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();

                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string json = Utility2.Read();

            List<VisitorDetail> lst = new List<VisitorDetail>();

            if (json != null && json != "")
            {
                lst = JsonConvert.DeserializeObject<List<VisitorDetail>>(json);
            }

            string data = JsonConvert.SerializeObject(lst);
            lst.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            data = JsonConvert.SerializeObject(lst);
            string outfromUtility = Utility2.Write(data);
            MessageBox.Show(outfromUtility);
            List();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedIndex == -1 || comboBox2.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields", "404", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (Int32.TryParse(textBox8.Text, out number).Equals(false))
            {

                MessageBox.Show("Invalid Price!", "404", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                string id = textBox1.Text;
                string name = textBox2.Text;
                int contact = int.Parse(textBox3.Text);
                string agegroup = comboBox1.Text;
                string groupof = comboBox2.Text;
                string intime = textBox6.Text;
                string outtime = textBox7.Text;
                int price = int.Parse(textBox8.Text);

                VisitorDetail P = new VisitorDetail();
                P.ID = id;
                P.Name = name;
                P.Contact = contact;
                P.AgeGroup = agegroup;
                P.GroupOf = groupof;
                P.Intime = intime;
                P.Etime = outtime;
                P.Price = price;

                string json = Utility2.Read();
                List<VisitorDetail> lst = new List<VisitorDetail>();

                if (json != null && json != "")
                {
                    lst = JsonConvert.DeserializeObject<List<VisitorDetail>>(json);
                }
                for (var i = 0; i < lst.Count; i++)
                {



                    if (dataGridView1.CurrentCell.RowIndex == i)
                    {
                        lst[dataGridView1.CurrentCell.RowIndex] = P;
                    }
                }
                string data = JsonConvert.SerializeObject(lst);
                string outfromUtility = Utility2.Write(data);
                MessageBox.Show(outfromUtility);
                List();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Delete Whole Table?", "Delete Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Utility2.Reset();
                List();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 10, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
