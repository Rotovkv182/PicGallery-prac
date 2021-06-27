
namespace PicGallery
{
    partial class afishaform
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pg_afishaDataSet = new PicGallery.pg_afishaDataSet();
            this.afishaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afishaTableAdapter = new PicGallery.pg_afishaDataSetTableAdapters.afishaTableAdapter();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pg_afishaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afishaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // pg_afishaDataSet
            // 
            this.pg_afishaDataSet.DataSetName = "pg_afishaDataSet";
            this.pg_afishaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // afishaBindingSource
            // 
            this.afishaBindingSource.DataMember = "afisha";
            this.afishaBindingSource.DataSource = this.pg_afishaDataSet;
            // 
            // afishaTableAdapter
            // 
            this.afishaTableAdapter.ClearBeforeFill = true;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_id.Location = new System.Drawing.Point(12, 134);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(42, 34);
            this.tb_id.TabIndex = 1;
            // 
            // tb_date
            // 
            this.tb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_date.Location = new System.Drawing.Point(71, 134);
            this.tb_date.Multiline = true;
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(116, 34);
            this.tb_date.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.Location = new System.Drawing.Point(204, 134);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(154, 34);
            this.tb_name.TabIndex = 3;
            // 
            // tb_time
            // 
            this.tb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_time.Location = new System.Drawing.Point(380, 134);
            this.tb_time.Multiline = true;
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(116, 34);
            this.tb_time.TabIndex = 4;
            // 
            // tb_genre
            // 
            this.tb_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_genre.Location = new System.Drawing.Point(517, 134);
            this.tb_genre.Multiline = true;
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(116, 34);
            this.tb_genre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(383, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Время";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(520, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Жанр";
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_insert.Location = new System.Drawing.Point(678, 136);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(144, 32);
            this.btn_insert.TabIndex = 11;
            this.btn_insert.Text = "Добавить";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(678, 98);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(144, 32);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btn_upd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_upd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_upd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_upd.Location = new System.Drawing.Point(678, 60);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(144, 32);
            this.btn_upd.TabIndex = 13;
            this.btn_upd.Text = "Изменить";
            this.btn_upd.UseVisualStyleBackColor = false;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(114, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "(2000-12-01)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(400, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Афиша";
            // 
            // afishaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(834, 466);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_genre);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "afishaform";
            this.Text = "Картинная Галерея";
            this.Load += new System.EventHandler(this.afishaform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pg_afishaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afishaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private pg_afishaDataSet pg_afishaDataSet;
        private System.Windows.Forms.BindingSource afishaBindingSource;
        private pg_afishaDataSetTableAdapters.afishaTableAdapter afishaTableAdapter;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.TextBox tb_genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}