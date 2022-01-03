using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADITYASINGHSAUD19030698;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public void List()
        {
            string json = Utility.Read();
            try
            {
                List<PriceRateDetail> lst = JsonConvert.DeserializeObject<List<PriceRateDetail>>(json);
                detailsview.DataSource = lst;
            }
            catch (Exception ex)
            {

            }

        }
        public Form1()
        {
            InitializeComponent();
            List();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Utility.Reset();
                List();
            }
        }

        private void delbutt_Click(object sender, EventArgs e)
        {
            string json = Utility.Read();

            List<PriceRateDetail> lst = new List<PriceRateDetail>();

            if (json != null && json != "")
            {
                lst = JsonConvert.DeserializeObject<List<PriceRateDetail>>(json);
            }

            string data = JsonConvert.SerializeObject(lst);
            lst.RemoveAt(detailsview.CurrentCell.RowIndex);
            data = JsonConvert.SerializeObject(lst);
            string outfromUtility = Utility.Write(data);
            MessageBox.Show(outfromUtility);
            List();
        }

        private void addbutt_Click_1(object sender, EventArgs e)
        {
            int number;

            if (durbox.SelectedIndex == -1 || groupbox.SelectedIndex == -1 || Cweek.Text == "" || cweekend.Text == "" || aweek.Text == "" || aweekend.Text == "" || aaweek.Text == "" || aaweekend.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields", "404", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (Int32.TryParse(Cweek.Text, out number).Equals(false) || Int32.TryParse(cweekend.Text, out number).Equals(false) || Int32.TryParse(aweek.Text, out number).Equals(false) || Int32.TryParse(aweekend.Text, out number).Equals(false) || Int32.TryParse(aaweek.Text, out number).Equals(false) || Int32.TryParse(aaweekend.Text, out number).Equals(false))
            {

                MessageBox.Show("Please Fill All the Fields", "404", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                string group = groupbox.Text;
                string dur = durbox.Text;
                int ChildWeekdays = int.Parse(Cweek.Text);
                int ChildWeekend = int.Parse(cweekend.Text);
                int AdultWeekdays = int.Parse(aweek.Text);
                int AdultWeekdend = int.Parse(aweekend.Text);
                int AgedWeekdays = int.Parse(aaweek.Text);
                int AgedWeekend = int.Parse(aaweekend.Text);

                PriceRateDetail P = new PriceRateDetail();
                P.Group = group;
                P.Duration = dur;
                P.Cweekdays = ChildWeekdays;
                P.Cweekdend = ChildWeekend;
                P.Aweekdays = AdultWeekdays;
                P.Aweekend = AdultWeekdend;
                P.Agweekdays = AgedWeekdays;
                P.Agweekend = AgedWeekend;

                string json = Utility.Read();

                List<PriceRateDetail> lst = new List<PriceRateDetail>();
                if (json != null && json != "")
                {
                    lst = JsonConvert.DeserializeObject<List<PriceRateDetail>>(json);
                }
                lst.Add(P);
                string data = JsonConvert.SerializeObject(lst);
                string outfromUtility = Utility.Write(data);
                MessageBox.Show(outfromUtility);
                List();
                groupbox.Text = string.Empty;
                durbox.Text = string.Empty;
                Cweek.Clear();
                cweekend.Clear();
                aweek.Clear();
                aweekend.Clear();
                aaweek.Clear();
                aaweekend.Clear();
            }
        }

        private void updatebutt_Click_1(object sender, EventArgs e)
        {
            int number;

            if (durbox.SelectedIndex == -1 || groupbox.SelectedIndex == -1 || Cweek.Text == "" || cweekend.Text == "" || aweek.Text == "" || aweekend.Text == "" || aaweek.Text == "" || aaweekend.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields", "404", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (Int32.TryParse(Cweek.Text, out number).Equals(false) || Int32.TryParse(cweekend.Text, out number).Equals(false) || Int32.TryParse(aweek.Text, out number).Equals(false) || Int32.TryParse(aweekend.Text, out number).Equals(false) || Int32.TryParse(aaweek.Text, out number).Equals(false) || Int32.TryParse(aaweekend.Text, out number).Equals(false))
            {

                MessageBox.Show("Please Fill All the Fields", "404", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                string group = groupbox.Text;
                string dur = durbox.Text;
                int ChildWeekdays = int.Parse(Cweek.Text);
                int ChildWeekend = int.Parse(cweekend.Text);
                int AdultWeekdays = int.Parse(aweek.Text);
                int AdultWeekdend = int.Parse(aweekend.Text);
                int AgedWeekdays = int.Parse(aaweek.Text);
                int AgedWeekend = int.Parse(aaweekend.Text);

                PriceRateDetail P = new PriceRateDetail();
                P.Group = group;
                P.Duration = dur;
                P.Cweekdays = ChildWeekdays;
                P.Cweekdend = ChildWeekend;
                P.Aweekdays = AdultWeekdays;
                P.Aweekend = AdultWeekdend;
                P.Agweekdays = AgedWeekdays;
                P.Agweekend = AgedWeekend;

                string json = Utility.Read();
                List<PriceRateDetail> lst = new List<PriceRateDetail>();

                if (json != null && json != "")
                {
                    lst = JsonConvert.DeserializeObject<List<PriceRateDetail>>(json);
                }
                for (var i = 0; i < lst.Count; i++)
                {

                    if (detailsview.CurrentCell.RowIndex == i)
                    {
                        lst[detailsview.CurrentCell.RowIndex] = P;
                    }

                }

                string data = JsonConvert.SerializeObject(lst);

                string outfromUtility = Utility.Write(data);
                MessageBox.Show(outfromUtility);
                List();
            }
        }

        private void clearbutt_Click_1(object sender, EventArgs e)
        {
            groupbox.Text = string.Empty;
            durbox.Text = string.Empty;
            Cweek.Clear();
            cweekend.Clear();
            aweek.Clear();
            aweekend.Clear();
            aaweek.Clear();
            aaweekend.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

        }

        private void delbutt_Click_1(object sender, EventArgs e)
        {
            string json = Utility.Read();

            List<PriceRateDetail> lst = new List<PriceRateDetail>();

            if (json != null && json != "")
            {
                lst = JsonConvert.DeserializeObject<List<PriceRateDetail>>(json);
            }

            string data = JsonConvert.SerializeObject(lst);
            lst.RemoveAt(detailsview.CurrentCell.RowIndex);
            data = JsonConvert.SerializeObject(lst);
            string outfromUtility = Utility.Write(data);
            MessageBox.Show(outfromUtility);
            List();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           detailsview.EnableHeadersVisualStyles = false;

            detailsview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            detailsview.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 10, FontStyle.Bold);
            detailsview.ForeColor = Color.Black;
        }

        private void groupbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cweek_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void childlabel_Click(object sender, EventArgs e)
        {

        }

        private void detailsGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
