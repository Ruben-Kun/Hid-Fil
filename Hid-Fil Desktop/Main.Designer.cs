namespace Hid_Fil_Desktop
{
    partial class Main
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
            this.img_button_ensamblar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.file_button_ensamblar = new System.Windows.Forms.Button();
            this.process_button_ensamblar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.img_textBox_ensamblar = new System.Windows.Forms.TextBox();
            this.file_textBox_ensamblar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.img_textBox_desamblar = new System.Windows.Forms.TextBox();
            this.img_button_desamblar = new System.Windows.Forms.Button();
            this.clave_textBox_desamblar = new System.Windows.Forms.TextBox();
            this.clave_button_desamblar = new System.Windows.Forms.Button();
            this.process_button_desamblar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_button_ensamblar
            // 
            this.img_button_ensamblar.BackColor = System.Drawing.Color.LightCyan;
            this.img_button_ensamblar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_button_ensamblar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_button_ensamblar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.img_button_ensamblar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.img_button_ensamblar.Location = new System.Drawing.Point(0, 0);
            this.img_button_ensamblar.Name = "img_button_ensamblar";
            this.img_button_ensamblar.Size = new System.Drawing.Size(299, 314);
            this.img_button_ensamblar.TabIndex = 0;
            this.img_button_ensamblar.Text = "Imagen";
            this.img_button_ensamblar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.img_button_ensamblar.UseVisualStyleBackColor = false;
            this.img_button_ensamblar.Click += new System.EventHandler(this.get_img_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // file_button_ensamblar
            // 
            this.file_button_ensamblar.BackColor = System.Drawing.Color.LightCyan;
            this.file_button_ensamblar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.file_button_ensamblar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.file_button_ensamblar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file_button_ensamblar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_button_ensamblar.Location = new System.Drawing.Point(0, 0);
            this.file_button_ensamblar.Name = "file_button_ensamblar";
            this.file_button_ensamblar.Size = new System.Drawing.Size(296, 314);
            this.file_button_ensamblar.TabIndex = 1;
            this.file_button_ensamblar.Text = "Archivo";
            this.file_button_ensamblar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.file_button_ensamblar.UseVisualStyleBackColor = false;
            this.file_button_ensamblar.Click += new System.EventHandler(this.get_file_Click);
            // 
            // process_button_ensamblar
            // 
            this.process_button_ensamblar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.process_button_ensamblar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_button_ensamblar.Location = new System.Drawing.Point(3, 321);
            this.process_button_ensamblar.Name = "process_button_ensamblar";
            this.process_button_ensamblar.Size = new System.Drawing.Size(607, 37);
            this.process_button_ensamblar.TabIndex = 2;
            this.process_button_ensamblar.Text = "Procesar";
            this.process_button_ensamblar.UseVisualStyleBackColor = true;
            this.process_button_ensamblar.Click += new System.EventHandler(this.Process_button_Assambly);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 387);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.process_button_ensamblar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(613, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ensamblar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.img_textBox_ensamblar);
            this.splitContainer1.Panel1.Controls.Add(this.img_button_ensamblar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.file_textBox_ensamblar);
            this.splitContainer1.Panel2.Controls.Add(this.file_button_ensamblar);
            this.splitContainer1.Size = new System.Drawing.Size(607, 318);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 3;
            // 
            // img_textBox_ensamblar
            // 
            this.img_textBox_ensamblar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.img_textBox_ensamblar.Location = new System.Drawing.Point(0, 294);
            this.img_textBox_ensamblar.Name = "img_textBox_ensamblar";
            this.img_textBox_ensamblar.ReadOnly = true;
            this.img_textBox_ensamblar.Size = new System.Drawing.Size(299, 20);
            this.img_textBox_ensamblar.TabIndex = 2;
            // 
            // file_textBox_ensamblar
            // 
            this.file_textBox_ensamblar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.file_textBox_ensamblar.Location = new System.Drawing.Point(0, 294);
            this.file_textBox_ensamblar.Name = "file_textBox_ensamblar";
            this.file_textBox_ensamblar.ReadOnly = true;
            this.file_textBox_ensamblar.Size = new System.Drawing.Size(296, 20);
            this.file_textBox_ensamblar.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Controls.Add(this.process_button_desamblar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(613, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Desamblar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.img_textBox_desamblar);
            this.splitContainer3.Panel1.Controls.Add(this.img_button_desamblar);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.clave_textBox_desamblar);
            this.splitContainer3.Panel2.Controls.Add(this.clave_button_desamblar);
            this.splitContainer3.Size = new System.Drawing.Size(607, 322);
            this.splitContainer3.SplitterDistance = 303;
            this.splitContainer3.TabIndex = 4;
            // 
            // img_textBox_desamblar
            // 
            this.img_textBox_desamblar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.img_textBox_desamblar.Location = new System.Drawing.Point(0, 298);
            this.img_textBox_desamblar.Name = "img_textBox_desamblar";
            this.img_textBox_desamblar.ReadOnly = true;
            this.img_textBox_desamblar.Size = new System.Drawing.Size(299, 20);
            this.img_textBox_desamblar.TabIndex = 2;
            // 
            // img_button_desamblar
            // 
            this.img_button_desamblar.BackColor = System.Drawing.Color.LightCyan;
            this.img_button_desamblar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_button_desamblar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_button_desamblar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.img_button_desamblar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.img_button_desamblar.Location = new System.Drawing.Point(0, 0);
            this.img_button_desamblar.Name = "img_button_desamblar";
            this.img_button_desamblar.Size = new System.Drawing.Size(299, 318);
            this.img_button_desamblar.TabIndex = 0;
            this.img_button_desamblar.Text = "Imagen";
            this.img_button_desamblar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.img_button_desamblar.UseVisualStyleBackColor = false;
            this.img_button_desamblar.Click += new System.EventHandler(this.get_img_Click);
            // 
            // clave_textBox_desamblar
            // 
            this.clave_textBox_desamblar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clave_textBox_desamblar.Location = new System.Drawing.Point(0, 298);
            this.clave_textBox_desamblar.Name = "clave_textBox_desamblar";
            this.clave_textBox_desamblar.ReadOnly = true;
            this.clave_textBox_desamblar.Size = new System.Drawing.Size(296, 20);
            this.clave_textBox_desamblar.TabIndex = 3;
            // 
            // clave_button_desamblar
            // 
            this.clave_button_desamblar.BackColor = System.Drawing.Color.LightCyan;
            this.clave_button_desamblar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clave_button_desamblar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clave_button_desamblar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clave_button_desamblar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_button_desamblar.Location = new System.Drawing.Point(0, 0);
            this.clave_button_desamblar.Name = "clave_button_desamblar";
            this.clave_button_desamblar.Size = new System.Drawing.Size(296, 318);
            this.clave_button_desamblar.TabIndex = 1;
            this.clave_button_desamblar.Text = "Clave";
            this.clave_button_desamblar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.clave_button_desamblar.UseVisualStyleBackColor = false;
            this.clave_button_desamblar.Click += new System.EventHandler(this.get_key_Click);
            // 
            // process_button_desamblar
            // 
            this.process_button_desamblar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.process_button_desamblar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_button_desamblar.Location = new System.Drawing.Point(3, 325);
            this.process_button_desamblar.Name = "process_button_desamblar";
            this.process_button_desamblar.Size = new System.Drawing.Size(607, 33);
            this.process_button_desamblar.TabIndex = 3;
            this.process_button_desamblar.Text = "Procesar";
            this.process_button_desamblar.UseVisualStyleBackColor = true;
            this.process_button_desamblar.Click += new System.EventHandler(this.process_button_desamblar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 387);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button img_button_ensamblar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button file_button_ensamblar;
        private System.Windows.Forms.Button process_button_ensamblar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox img_textBox_ensamblar;
        private System.Windows.Forms.TextBox file_textBox_ensamblar;
        private System.Windows.Forms.Button process_button_desamblar;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox img_textBox_desamblar;
        private System.Windows.Forms.Button img_button_desamblar;
        private System.Windows.Forms.TextBox clave_textBox_desamblar;
        private System.Windows.Forms.Button clave_button_desamblar;
    }
}

