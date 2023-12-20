using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace domaci
{
    public partial class Form1 : Form
    {
        int br;
        int selected;
        DataTable tabela;

        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            veza.Open();
            tabela = new DataTable();
            adapter.Fill(tabela);
            veza.Close();
        }

        private void CB_Load()
        {
            cb_id.Items.Clear();
            cb_ime.Items.Clear();
            cb_prezime.Items.Clear();
            cb_adresa.Items.Clear();
            cb_jmbg.Items.Clear();
            cb_email.Items.Clear();
            cb_pass.Items.Clear();
            cb_uloga.Items.Clear();

            br = tabela.Rows.Count;

            for (int i = 0; i < br; i++)
            {
                cb_id.Items.Add(tabela.Rows[i]["id"].ToString());
                cb_ime.Items.Add(tabela.Rows[i]["ime"].ToString());
                cb_prezime.Items.Add(tabela.Rows[i]["prezime"].ToString());
                cb_adresa.Items.Add(tabela.Rows[i]["adresa"].ToString());
                cb_jmbg.Items.Add(tabela.Rows[i]["jmbg"].ToString());
                cb_email.Items.Add(tabela.Rows[i]["email"].ToString());
                cb_pass.Items.Add(tabela.Rows[i]["pass"].ToString());
                cb_uloga.Items.Add(tabela.Rows[i]["uloga"].ToString());
            }

            ID_Changed();
        }

        private void ID_Changed()
        {
            cb_id.SelectedIndex = selected;
            cb_ime.SelectedIndex = selected;
            cb_prezime.SelectedIndex = selected;
            cb_adresa.SelectedIndex = selected;
            cb_jmbg.SelectedIndex = selected;
            cb_email.SelectedIndex = selected;
            cb_pass.SelectedIndex = selected;
            cb_uloga.SelectedIndex = selected;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_prvi_Click(object sender, EventArgs e)
        {
            cb_id.SelectedIndex = 0;
            cb_ime.SelectedIndex = 0;
            cb_prezime.SelectedIndex = 0;
            cb_adresa.SelectedIndex = 0;
            cb_jmbg.SelectedIndex = 0;
            cb_email.SelectedIndex = 0;
            cb_pass.SelectedIndex = 0;
            cb_uloga.SelectedIndex = 0;
        }

        private void btn_prethodni_Click(object sender, EventArgs e)
        {
            if(cb_id.SelectedIndex > 0)
            {
                cb_id.SelectedIndex--;
                cb_ime.SelectedIndex--;
                cb_prezime.SelectedIndex--;
                cb_adresa.SelectedIndex--;
                cb_jmbg.SelectedIndex--;
                cb_email.SelectedIndex--;
                cb_pass.SelectedIndex--;
                cb_uloga.SelectedIndex--;
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            StringBuilder SB = new StringBuilder("INSERT INTO osoba (ime, prezime, adresa, jmbg, email, pass, uloga) VALUES ('");
            SB.Append(cb_ime.Text + "', '");
            SB.Append(cb_prezime.Text + "', '");
            SB.Append(cb_adresa.Text + "', '");
            SB.Append(cb_jmbg.Text + "', '");
            SB.Append(cb_email.Text + "', '");
            SB.Append(cb_pass.Text + "', '");
            SB.Append(cb_uloga.Text + "')");

            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(SB.ToString(), veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();

            selected = br;

            Load_Data();
            CB_Load();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string SB = "DELETE FROM osoba WHERE id = " + cb_id.Text;

            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(SB, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();

            selected = cb_id.SelectedIndex - 1;

            Load_Data();
            CB_Load();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder SB = new StringBuilder("UPDATE osoba SET ime = '");
            SB.Append(cb_ime.Text + "', prezime = '");
            SB.Append(cb_prezime.Text + "', adresa = '");
            SB.Append(cb_adresa.Text + "', jmbg = '");
            SB.Append(cb_jmbg.Text + "', email = '");
            SB.Append(cb_email.Text + "', pass = '");
            SB.Append(cb_pass.Text + "', uloga = '");
            SB.Append(cb_uloga.Text + "' WHERE id = " + cb_id.Text);

            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(SB.ToString(), veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();

            selected = cb_id.SelectedIndex;

            Load_Data();
            CB_Load();
        }

        private void btn_sledeci_Click(object sender, EventArgs e)
        {
            if (cb_id.SelectedIndex < br - 1)
            {
                cb_id.SelectedIndex++;
                cb_ime.SelectedIndex++;
                cb_prezime.SelectedIndex++;
                cb_adresa.SelectedIndex++;
                cb_jmbg.SelectedIndex++;
                cb_email.SelectedIndex++;
                cb_pass.SelectedIndex++;
                cb_uloga.SelectedIndex++;
            }
        }

        private void btn_poslednji_Click(object sender, EventArgs e)
        {
            cb_id.SelectedIndex = br - 1;
            cb_ime.SelectedIndex =br - 1;
            cb_prezime.SelectedIndex = br - 1;
            cb_adresa.SelectedIndex = br - 1;
            cb_jmbg.SelectedIndex = br - 1;
            cb_email.SelectedIndex = br - 1;
            cb_pass.SelectedIndex = br - 1;
            cb_uloga.SelectedIndex = br - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selected = 0;

            Load_Data();
            CB_Load();
        }

        private void cb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = cb_id.SelectedIndex;

            ID_Changed();
        }

        private void cb_ime_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = cb_ime.SelectedIndex;

            ID_Changed();
        }

        private void cb_prezime_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = cb_prezime.SelectedIndex;

            ID_Changed();
        }

        private void cb_adresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = cb_adresa.SelectedIndex;

            ID_Changed();
        }

        private void cb_jmbg_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = cb_jmbg.SelectedIndex;

            ID_Changed();
        }

        private void cb_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = cb_email.SelectedIndex;

            ID_Changed();
        }

        private void cb_pass_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = cb_pass.SelectedIndex;

            ID_Changed();
        }

        private void cb_uloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = cb_uloga.SelectedIndex;

            ID_Changed();
        }
    }

    class Konekcija
    {
        static public SqlConnection Connect()
        {
            string CS = "Data Source = .; Initial Catalog = ednevnik; Integrated Security = True;";
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
    }
}
