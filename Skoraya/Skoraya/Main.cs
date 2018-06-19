using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Skoraya
{
    public partial class Main : Form
    {
        public static MySqlConnection c = new MySqlConnection("Server=localhost; Database=krest; User id = root; password=;");
        public static MySqlCommand cmd = c.CreateCommand();
        public static MySqlDataReader r;

        public static List<Call> calls = new List<Call>();
        public static List<Doc> docs = new List<Doc>();
        public static List<MedPers> mPerss = new List<MedPers>();
        public static List<Mash> mashs = new List<Mash>();
        public static List<Boln> bolns = new List<Boln>();
        static bool exists;
        public Main()
        {
            InitializeComponent();
        }

        void Update()
        {
            h_dgv_calls.Rows.Clear();
            object[] res = new object[2];

            c.Open();
            cmd.CommandText = "select IDV, Data from visov";
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < 2; i++)
                    res[i] = r[i];
                h_dgv_calls.Rows.Add(res);
            }
            r.Close();
            c.Close();

            //get visov
            c.Open();
            cmd.CommandText = "select * from visov";
            r = cmd.ExecuteReader();
            Call cl;
            calls.Clear();
            while (r.Read())
            {
                cl = new Call();
                cl.id = r[0];
                cl.prichina = r[1];
                cl.pomosh = r[2];
                cl.dostavka = r[3];
                cl.data = r[4];
                cl.idd = r[5];
                cl.idm = r[6];
                cl.idmash = r[7];
                cl.idb = r[8];

                calls.Add(cl);
            }
            r.Close();
            c.Close();
            
            //get docs
            c.Open();
            cmd.CommandText = "select * from doctor";
            r = cmd.ExecuteReader();
            Doc dc;
            docs.Clear();
            while (r.Read())
            {
                dc = new Doc();
                dc.id = r[0];
                dc.name = r[1];
                dc.spec = r[2];
                dc.dolj = r[3];

                docs.Add(dc);
            }
            r.Close();
            c.Close();

            //get medperss
            c.Open();
            cmd.CommandText = "select * from medpersonal";
            r = cmd.ExecuteReader();
            MedPers mp;
            mPerss.Clear();
            while (r.Read())
            {
                mp = new MedPers();
                mp.id = r[0];
                mp.name = r[1];

                mPerss.Add(mp);
            }
            r.Close();
            c.Close();

            //get mashs
            c.Open();
            cmd.CommandText = "select * from mashina";
            r = cmd.ExecuteReader();
            Mash msh;
            mashs.Clear();
            while (r.Read())
            {
                msh = new Mash();
                msh.id = r[0];
                msh.num = r[1];
                msh.gosNum = r[2];
                msh.godVip = r[3];
                msh.driverName = r[4];
                msh.vodUdost = r[5];

                mashs.Add(msh);
            }
            r.Close();
            c.Close();

            //get bolns
            c.Open();
            cmd.CommandText = "select * from boln";
            r = cmd.ExecuteReader();
            Boln b;
            bolns.Clear();
            while (r.Read())
            {
                b = new Boln();
                b.id = r[0];
                b.name = r[1];
                b.date = r[2];
                b.address = r[3];

                bolns.Add(b);
            }
            r.Close();
            c.Close();

            cb_vrach.Items.Clear();
            foreach (var v in docs)
                cb_vrach.Items.Add(v.name);
            cb_medPersonal.Items.Clear();
            foreach (var v in mPerss)
                cb_medPersonal.Items.Add(v.name);
            cb_nBorta.Items.Clear();
            foreach (var v in mashs)
                cb_nBorta.Items.Add(v.num);

            cb_fio.Items.Clear();
            foreach (var v in bolns)
                cb_fio.Items.Add(v.name);

        }
        private void Main_Load(object sender, EventArgs e)
        {
            h_btn_printBlank.Visible = false;
            h_b_search.Visible = false;
            h_dgv_calls.Visible = false;
            h_tb_search.Visible = false;
            Update();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Update();
            exists = true;
            h_btn_printBlank.Visible = true;
            h_b_search.Visible = true;
            h_dgv_calls.Visible = true;
            h_tb_search.Visible = true;

            n_btn_adm_register.Visible = false;
            n_btn_logout.Visible = false;
            n_btn_save.Visible = false;

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            exists = false;
            h_btn_printBlank.Visible = false;
            h_b_search.Visible = false;
            h_dgv_calls.Visible = false;
            h_tb_search.Visible = false;

            n_btn_adm_register.Visible = true;
            n_btn_logout.Visible = true;
            n_btn_save.Visible = true;

        }
        object[,] GetRow(string table, string param, string criteria, int length)
        {
            int size = 0;
            c.Open();
            cmd.CommandText = "select * from " + table + " where " + param + " = " + criteria;
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                size++;
            }
            r.Close();
            c.Close();

            object[,] res = new object[length, size];

            int j = 0;
            c.Open();
            cmd.CommandText = "select * from " + table + " where " + param + " = " + criteria;
            r = cmd.ExecuteReader();
            while(r.Read())
            {
                for (int i = 0; i < length; i++)
                    res[i, j] = r[i];
                j++;
            }
            r.Close();
            c.Close();
            return res;
        }
        object[,] GetRows(string table, int length)
        {
            int size = 0;
            c.Open();
            cmd.CommandText = "select * from " + table;
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                size++;
            }
            r.Close();
            c.Close();

            object[,] res = new object[length, size];

            int j = 0;
            c.Open();
            cmd.CommandText = "select * from " + table;
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < length; i++)
                    res[i, j] = r[i];
                j++;
            }
            r.Close();
            c.Close();
            return res;
        }
        object GetCell(string table, string param, string criteria, string cell)
        {
            object res;

            c.Open();
            cmd.CommandText = "select " + cell + " from " + table + " where " + param + " = " + criteria;
            res = cmd.ExecuteScalar();            
            c.Close();
            return res;
        }

        private void h_b_search_Click(object sender, EventArgs e)
        {
            h_dgv_calls.ClearSelection();
            if (h_tb_search.Text != "")
            {
                for (int i = 0; i < h_dgv_calls.RowCount; i++)
                {
                    if (h_dgv_calls.Rows[i].Cells[1].Value.ToString().Contains(h_tb_search.Text))
                        h_dgv_calls.Rows[i].Selected = true;
                }
            }
        }

        private void h_dgv_calls_SelectionChanged(object sender, EventArgs e)
        {
           

        }

        private void h_dgv_calls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object a = h_dgv_calls.SelectedCells[0].OwningRow.Cells[0].Value;
            Call call = calls.Find(x => x.id.ToString() == a.ToString());
            MessageBox.Show(call.data.ToString());
            //date_dateCall.Text = call.data.ToString();
            tb_address.Text = "Красноярск, ул. Тельмана 22, кв. 43";
            tb_prichina.Text = call.prichina.ToString();
            cb_vrach.Text = docs.Find(x => x.id.ToString() == call.idd.ToString()).name.ToString();
            cb_medPersonal.Text = mPerss.Find(x => x.id.ToString() == call.idm.ToString()).name.ToString();
            cb_nBorta.Text = mashs.Find(x => x.id.ToString() == call.idmash.ToString()).num.ToString();
            tb_pervPomosh.Text = call.pomosh.ToString();
            tb_addrDostavki.Text = call.dostavka.ToString();

            cb_fio.Text = bolns.Find(x => x.id.ToString() == call.idb.ToString()).name.ToString();
            tb_addressHome.Text = bolns.Find(x => x.id.ToString() == call.idb.ToString()).address.ToString();
            //date_dateBirth.Text = bolns.Find(x => x.id.ToString() == call.idb.ToString()).date.ToString();
        }

        private void n_btn_adm_register_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            f.ShowDialog();
        }

        private void h_btn_printBlank_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void n_btn_save_Click(object sender, EventArgs e)
        {
            c.Open();
            if(exists)
            {
                //update
                cmd.CommandText = "update visov set " +
                    "Prichina = '" + tb_prichina.Text +
                    "', Pomoch = '" + tb_pervPomosh.Text +
                    "', Dostaka = '" + tb_addrDostavki.Text +
                    "', Data = '" + date_dateCall.Text + 
                    "' where IDV = " + h_dgv_calls.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                cmd.ExecuteScalar();
            }
            else
            {
                //insert
                cmd.CommandText = "insert into visov (Prichina, Pomoch, Dostaka, Data, IDD, IDM, IDmash, IDb) values(" +
                    "'" + tb_prichina.Text + "', " +
                     "'" + tb_pervPomosh.Text + "', " +
                     "'" + tb_addrDostavki.Text + "', " +
                     "'" + date_dateCall.Text + "', " +
                     "'" + (cb_vrach.SelectedIndex + 1) + "', " +
                     "'" + (cb_medPersonal.SelectedIndex + 1) + "', " +
                     "'" + (cb_nBorta.SelectedIndex + 1) + "', " +
                     "'" + (cb_fio.SelectedIndex + 1) + "')";
                cmd.ExecuteScalar();
            }
            c.Close();
        }

        private void n_btn_logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Call call = calls.Find(x => x.id.ToString() == h_dgv_calls.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            Doc d = docs.Find(x => x.id.ToString() == call.idd.ToString());
            MedPers mp = mPerss.Find(x => x.id.ToString() == call.idm.ToString());
            Mash m = mashs.Find(x => x.id.ToString() == call.idmash.ToString());
            Boln b = bolns.Find(x => x.id.ToString() == call.idb.ToString());
            e.Graphics.DrawString("Номер вызова: " + call.id + "\n" +
                "Причина: " + call.prichina + "\n" +
                "Помощь: " + call.pomosh + "\n" +
                "Адрес доставки: " + call.dostavka + "\n" +
                "Дата: " + call.data + "\n" +
                "----------------------------" + "\n" +
                "Врач: " + d.name + ". " + d.spec + ", " + d.dolj + "\n" +
                "Мед персонал: " + mp.name + "\n" +
                "Машина: " + m.num + ", " + m.gosNum + ", " + m.godVip + ", " + m.driverName + ", " + m.vodUdost + "\n" +
                "Больной: " + b.name + ". " + b.date + ", " + b.address + "\n"

                , DefaultFont, Brushes.Black, 50, 50);
        }
    }
    public class Call
    {
        public object 
            id,
            prichina,
            pomosh,
            dostavka,
            data,
            idd,
            idm,
            idmash,
            idb;
    }
    public class Doc
    {
        public object id,
            name,
            spec,
            dolj;
    }
    public class MedPers
    {
        public object id,
            name;
    }
    public class Mash
    {
        public object id,
            num,
            gosNum,
            godVip,
            driverName,
            vodUdost;
    }
    public class Boln
    {
        public object id,
            name,
            date,
            address;
    }

}
