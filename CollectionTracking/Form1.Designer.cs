
namespace CollectionTracking
{
    partial class frmFilm
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
            this.dgwFilms = new System.Windows.Forms.DataGridView();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.tbxFilmName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.tbxPublishDate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxPublishDateUpdate = new System.Windows.Forms.TextBox();
            this.lblPublishDateUpdate = new System.Windows.Forms.Label();
            this.tbxTypeUpdate = new System.Windows.Forms.TextBox();
            this.lblTypeUpdate = new System.Windows.Forms.Label();
            this.tbxFilmNameUpdate = new System.Windows.Forms.TextBox();
            this.lblFilmNameUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilms)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwFilms
            // 
            this.dgwFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilms.Location = new System.Drawing.Point(12, 12);
            this.dgwFilms.Name = "dgwFilms";
            this.dgwFilms.Size = new System.Drawing.Size(776, 150);
            this.dgwFilms.TabIndex = 0;
            this.dgwFilms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFilms_CellClick);
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.Location = new System.Drawing.Point(23, 35);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(43, 13);
            this.lblFilmName.TabIndex = 1;
            this.lblFilmName.Text = "Film Adı";
            // 
            // tbxFilmName
            // 
            this.tbxFilmName.Location = new System.Drawing.Point(137, 35);
            this.tbxFilmName.Name = "tbxFilmName";
            this.tbxFilmName.Size = new System.Drawing.Size(138, 20);
            this.tbxFilmName.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 78);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(24, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Tipi";
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(137, 71);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(138, 20);
            this.tbxType.TabIndex = 4;
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Location = new System.Drawing.Point(23, 120);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(58, 13);
            this.lblPublishDate.TabIndex = 5;
            this.lblPublishDate.Text = "Çıkış Tarihi";
            // 
            // tbxPublishDate
            // 
            this.tbxPublishDate.Location = new System.Drawing.Point(137, 113);
            this.tbxPublishDate.Name = "tbxPublishDate";
            this.tbxPublishDate.Size = new System.Drawing.Size(138, 20);
            this.tbxPublishDate.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(495, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxType);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblFilmName);
            this.groupBox1.Controls.Add(this.tbxPublishDate);
            this.groupBox1.Controls.Add(this.tbxFilmName);
            this.groupBox1.Controls.Add(this.lblPublishDate);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Location = new System.Drawing.Point(40, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Film Ekle";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.tbxPublishDateUpdate);
            this.groupBox2.Controls.Add(this.lblPublishDateUpdate);
            this.groupBox2.Controls.Add(this.tbxTypeUpdate);
            this.groupBox2.Controls.Add(this.lblTypeUpdate);
            this.groupBox2.Controls.Add(this.tbxFilmNameUpdate);
            this.groupBox2.Controls.Add(this.lblFilmNameUpdate);
            this.groupBox2.Location = new System.Drawing.Point(40, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 138);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(495, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxPublishDateUpdate
            // 
            this.tbxPublishDateUpdate.Location = new System.Drawing.Point(137, 99);
            this.tbxPublishDateUpdate.Name = "tbxPublishDateUpdate";
            this.tbxPublishDateUpdate.Size = new System.Drawing.Size(138, 20);
            this.tbxPublishDateUpdate.TabIndex = 5;
            // 
            // lblPublishDateUpdate
            // 
            this.lblPublishDateUpdate.AutoSize = true;
            this.lblPublishDateUpdate.Location = new System.Drawing.Point(23, 102);
            this.lblPublishDateUpdate.Name = "lblPublishDateUpdate";
            this.lblPublishDateUpdate.Size = new System.Drawing.Size(58, 13);
            this.lblPublishDateUpdate.TabIndex = 4;
            this.lblPublishDateUpdate.Text = "Çıkış Tarihi";
            // 
            // tbxTypeUpdate
            // 
            this.tbxTypeUpdate.Location = new System.Drawing.Point(137, 66);
            this.tbxTypeUpdate.Name = "tbxTypeUpdate";
            this.tbxTypeUpdate.Size = new System.Drawing.Size(138, 20);
            this.tbxTypeUpdate.TabIndex = 3;
            // 
            // lblTypeUpdate
            // 
            this.lblTypeUpdate.AutoSize = true;
            this.lblTypeUpdate.Location = new System.Drawing.Point(23, 69);
            this.lblTypeUpdate.Name = "lblTypeUpdate";
            this.lblTypeUpdate.Size = new System.Drawing.Size(24, 13);
            this.lblTypeUpdate.TabIndex = 2;
            this.lblTypeUpdate.Text = "Tipi";
            // 
            // tbxFilmNameUpdate
            // 
            this.tbxFilmNameUpdate.Location = new System.Drawing.Point(137, 25);
            this.tbxFilmNameUpdate.Name = "tbxFilmNameUpdate";
            this.tbxFilmNameUpdate.Size = new System.Drawing.Size(138, 20);
            this.tbxFilmNameUpdate.TabIndex = 1;
            // 
            // lblFilmNameUpdate
            // 
            this.lblFilmNameUpdate.AutoSize = true;
            this.lblFilmNameUpdate.Location = new System.Drawing.Point(23, 32);
            this.lblFilmNameUpdate.Name = "lblFilmNameUpdate";
            this.lblFilmNameUpdate.Size = new System.Drawing.Size(43, 13);
            this.lblFilmNameUpdate.TabIndex = 0;
            this.lblFilmNameUpdate.Text = "Film Adı";
            // 
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwFilms);
            this.Name = "frmFilm";
            this.Text = "Filmler";
            this.Load += new System.EventHandler(this.frmFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilms;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.TextBox tbxFilmName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.TextBox tbxPublishDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxPublishDateUpdate;
        private System.Windows.Forms.Label lblPublishDateUpdate;
        private System.Windows.Forms.TextBox tbxTypeUpdate;
        private System.Windows.Forms.Label lblTypeUpdate;
        private System.Windows.Forms.TextBox tbxFilmNameUpdate;
        private System.Windows.Forms.Label lblFilmNameUpdate;
    }
}

