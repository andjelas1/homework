namespace domaci
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_id = new System.Windows.Forms.ComboBox();
            this.cb_ime = new System.Windows.Forms.ComboBox();
            this.cb_prezime = new System.Windows.Forms.ComboBox();
            this.cb_adresa = new System.Windows.Forms.ComboBox();
            this.cb_jmbg = new System.Windows.Forms.ComboBox();
            this.cb_email = new System.Windows.Forms.ComboBox();
            this.cb_pass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_uloga = new System.Windows.Forms.ComboBox();
            this.btn_prvi = new System.Windows.Forms.Button();
            this.btn_prethodni = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_sledeci = new System.Windows.Forms.Button();
            this.btn_poslednji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_id
            // 
            this.cb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_id.FormattingEnabled = true;
            this.cb_id.Location = new System.Drawing.Point(252, 77);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(174, 21);
            this.cb_id.TabIndex = 0;
            this.cb_id.SelectedIndexChanged += new System.EventHandler(this.cb_id_SelectedIndexChanged);
            // 
            // cb_ime
            // 
            this.cb_ime.FormattingEnabled = true;
            this.cb_ime.Location = new System.Drawing.Point(252, 104);
            this.cb_ime.Name = "cb_ime";
            this.cb_ime.Size = new System.Drawing.Size(174, 21);
            this.cb_ime.TabIndex = 1;
            this.cb_ime.SelectedIndexChanged += new System.EventHandler(this.cb_ime_SelectedIndexChanged);
            // 
            // cb_prezime
            // 
            this.cb_prezime.FormattingEnabled = true;
            this.cb_prezime.Location = new System.Drawing.Point(252, 131);
            this.cb_prezime.Name = "cb_prezime";
            this.cb_prezime.Size = new System.Drawing.Size(174, 21);
            this.cb_prezime.TabIndex = 2;
            this.cb_prezime.SelectedIndexChanged += new System.EventHandler(this.cb_prezime_SelectedIndexChanged);
            // 
            // cb_adresa
            // 
            this.cb_adresa.FormattingEnabled = true;
            this.cb_adresa.Location = new System.Drawing.Point(252, 158);
            this.cb_adresa.Name = "cb_adresa";
            this.cb_adresa.Size = new System.Drawing.Size(174, 21);
            this.cb_adresa.TabIndex = 3;
            this.cb_adresa.SelectedIndexChanged += new System.EventHandler(this.cb_adresa_SelectedIndexChanged);
            // 
            // cb_jmbg
            // 
            this.cb_jmbg.FormattingEnabled = true;
            this.cb_jmbg.Location = new System.Drawing.Point(252, 185);
            this.cb_jmbg.Name = "cb_jmbg";
            this.cb_jmbg.Size = new System.Drawing.Size(174, 21);
            this.cb_jmbg.TabIndex = 4;
            this.cb_jmbg.SelectedIndexChanged += new System.EventHandler(this.cb_jmbg_SelectedIndexChanged);
            // 
            // cb_email
            // 
            this.cb_email.FormattingEnabled = true;
            this.cb_email.Location = new System.Drawing.Point(252, 212);
            this.cb_email.Name = "cb_email";
            this.cb_email.Size = new System.Drawing.Size(174, 21);
            this.cb_email.TabIndex = 5;
            this.cb_email.SelectedIndexChanged += new System.EventHandler(this.cb_email_SelectedIndexChanged);
            // 
            // cb_pass
            // 
            this.cb_pass.FormattingEnabled = true;
            this.cb_pass.Location = new System.Drawing.Point(252, 239);
            this.cb_pass.Name = "cb_pass";
            this.cb_pass.Size = new System.Drawing.Size(174, 21);
            this.cb_pass.TabIndex = 6;
            this.cb_pass.SelectedIndexChanged += new System.EventHandler(this.cb_pass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(201, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(201, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(201, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(201, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(201, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Jmbg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(201, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(201, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pass";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(201, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Uloga";
            // 
            // cb_uloga
            // 
            this.cb_uloga.FormattingEnabled = true;
            this.cb_uloga.Location = new System.Drawing.Point(252, 266);
            this.cb_uloga.Name = "cb_uloga";
            this.cb_uloga.Size = new System.Drawing.Size(174, 21);
            this.cb_uloga.TabIndex = 15;
            this.cb_uloga.SelectedIndexChanged += new System.EventHandler(this.cb_uloga_SelectedIndexChanged);
            // 
            // btn_prvi
            // 
            this.btn_prvi.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prvi.Location = new System.Drawing.Point(26, 328);
            this.btn_prvi.Name = "btn_prvi";
            this.btn_prvi.Size = new System.Drawing.Size(78, 22);
            this.btn_prvi.TabIndex = 16;
            this.btn_prvi.Text = "<<";
            this.btn_prvi.UseVisualStyleBackColor = true;
            this.btn_prvi.Click += new System.EventHandler(this.btn_prvi_Click);
            // 
            // btn_prethodni
            // 
            this.btn_prethodni.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_prethodni.Location = new System.Drawing.Point(110, 328);
            this.btn_prethodni.Name = "btn_prethodni";
            this.btn_prethodni.Size = new System.Drawing.Size(78, 22);
            this.btn_prethodni.TabIndex = 17;
            this.btn_prethodni.Text = "<";
            this.btn_prethodni.UseVisualStyleBackColor = true;
            this.btn_prethodni.Click += new System.EventHandler(this.btn_prethodni_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_insert.Location = new System.Drawing.Point(194, 328);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(78, 22);
            this.btn_insert.TabIndex = 18;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Location = new System.Drawing.Point(278, 328);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 22);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_update.Location = new System.Drawing.Point(362, 328);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(78, 22);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_sledeci
            // 
            this.btn_sledeci.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_sledeci.Location = new System.Drawing.Point(446, 328);
            this.btn_sledeci.Name = "btn_sledeci";
            this.btn_sledeci.Size = new System.Drawing.Size(78, 22);
            this.btn_sledeci.TabIndex = 21;
            this.btn_sledeci.Text = ">";
            this.btn_sledeci.UseVisualStyleBackColor = true;
            this.btn_sledeci.Click += new System.EventHandler(this.btn_sledeci_Click);
            // 
            // btn_poslednji
            // 
            this.btn_poslednji.Font = new System.Drawing.Font("Skranji", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_poslednji.Location = new System.Drawing.Point(530, 328);
            this.btn_poslednji.Name = "btn_poslednji";
            this.btn_poslednji.Size = new System.Drawing.Size(78, 22);
            this.btn_poslednji.TabIndex = 22;
            this.btn_poslednji.Text = ">>";
            this.btn_poslednji.UseVisualStyleBackColor = true;
            this.btn_poslednji.Click += new System.EventHandler(this.btn_poslednji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.btn_poslednji);
            this.Controls.Add(this.btn_sledeci);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_prethodni);
            this.Controls.Add(this.btn_prvi);
            this.Controls.Add(this.cb_uloga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_pass);
            this.Controls.Add(this.cb_email);
            this.Controls.Add(this.cb_jmbg);
            this.Controls.Add(this.cb_adresa);
            this.Controls.Add(this.cb_prezime);
            this.Controls.Add(this.cb_ime);
            this.Controls.Add(this.cb_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_id;
        private System.Windows.Forms.ComboBox cb_ime;
        private System.Windows.Forms.ComboBox cb_prezime;
        private System.Windows.Forms.ComboBox cb_adresa;
        private System.Windows.Forms.ComboBox cb_jmbg;
        private System.Windows.Forms.ComboBox cb_email;
        private System.Windows.Forms.ComboBox cb_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_uloga;
        private System.Windows.Forms.Button btn_prvi;
        private System.Windows.Forms.Button btn_prethodni;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_sledeci;
        private System.Windows.Forms.Button btn_poslednji;
    }
}

