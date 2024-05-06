namespace WinFormsApp1
{
    partial class Nomina1
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
            dgvNom = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            addB = new Button();
            erB = new Button();
            label1 = new Label();
            mIng = new MaskedTextBox();
            cedula = new TextBox();
            name = new TextBox();
            lname = new TextBox();
            anIn = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            infoL = new Label();
            exitB = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNom).BeginInit();
            SuspendLayout();
            // 
            // dgvNom
            // 
            dgvNom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNom.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvNom.Dock = DockStyle.Bottom;
            dgvNom.Location = new Point(0, 350);
            dgvNom.Name = "dgvNom";
            dgvNom.RowHeadersWidth = 51;
            dgvNom.Size = new Size(1177, 398);
            dgvNom.TabIndex = 0;
            dgvNom.CellClick += dgvNom_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cédula";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Salario";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Antigüedad";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "INSS Lab.";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "IR";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Ant. Porcent";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Ingreso Neto";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // addB
            // 
            addB.Location = new Point(729, 175);
            addB.Name = "addB";
            addB.Size = new Size(94, 29);
            addB.TabIndex = 1;
            addB.Text = "Agregar";
            addB.UseVisualStyleBackColor = true;
            addB.Click += addB_Click;
            // 
            // erB
            // 
            erB.Location = new Point(356, 291);
            erB.Name = "erB";
            erB.Size = new Size(94, 29);
            erB.TabIndex = 2;
            erB.Text = "Eliminar";
            erB.UseVisualStyleBackColor = true;
            erB.Click += erB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 57);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Cédula";
            // 
            // mIng
            // 
            mIng.Location = new Point(712, 65);
            mIng.Mask = "999999";
            mIng.Name = "mIng";
            mIng.Size = new Size(145, 27);
            mIng.TabIndex = 4;
            mIng.ValidatingType = typeof(int);
            mIng.KeyPress += mIng_KeyPress;
            // 
            // cedula
            // 
            cedula.Location = new Point(302, 57);
            cedula.Name = "cedula";
            cedula.Size = new Size(175, 27);
            cedula.TabIndex = 5;
            // 
            // name
            // 
            name.Location = new Point(302, 107);
            name.Name = "name";
            name.Size = new Size(175, 27);
            name.TabIndex = 6;
            // 
            // lname
            // 
            lname.Location = new Point(302, 156);
            lname.Name = "lname";
            lname.Size = new Size(175, 27);
            lname.TabIndex = 7;
            // 
            // anIn
            // 
            anIn.Location = new Point(712, 115);
            anIn.Mask = "9999";
            anIn.Name = "anIn";
            anIn.Size = new Size(145, 27);
            anIn.TabIndex = 8;
            anIn.ValidatingType = typeof(int);
            anIn.KeyPress += anIn_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 107);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 159);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 10;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(577, 68);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 11;
            label4.Text = "Salario Nominal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 122);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 12;
            label5.Text = "Año de Ingreso:";
            // 
            // infoL
            // 
            infoL.AutoSize = true;
            infoL.Location = new Point(477, 295);
            infoL.Name = "infoL";
            infoL.Size = new Size(0, 20);
            infoL.TabIndex = 13;
            // 
            // exitB
            // 
            exitB.Location = new Point(1071, 12);
            exitB.Name = "exitB";
            exitB.Size = new Size(94, 29);
            exitB.TabIndex = 14;
            exitB.Text = "Salir";
            exitB.UseVisualStyleBackColor = true;
            // 
            // Nomina1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 748);
            Controls.Add(exitB);
            Controls.Add(infoL);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(anIn);
            Controls.Add(lname);
            Controls.Add(name);
            Controls.Add(cedula);
            Controls.Add(mIng);
            Controls.Add(label1);
            Controls.Add(erB);
            Controls.Add(addB);
            Controls.Add(dgvNom);
            Name = "Nomina1";
            Text = "Nomina1";
            ((System.ComponentModel.ISupportInitialize)dgvNom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNom;
        private Button addB;
        private Button erB;
        private Label label1;
        private MaskedTextBox mIng;
        private TextBox cedula;
        private TextBox name;
        private TextBox lname;
        private MaskedTextBox anIn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label infoL;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button exitB;
    }
}