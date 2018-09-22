namespace DataBaseDemo
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.priceProductTextBox = new System.Windows.Forms.Label();
            this.quantityProductTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.changeProductButton = new System.Windows.Forms.Button();
            this.saveToDatabaseButton = new System.Windows.Forms.Button();
            this.saveToXMLButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityProductColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceProductColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(53, 21);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(45, 24);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Imię";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(53, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 24);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Nazwisko";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(53, 106);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(136, 24);
            this.birthdayLabel.TabIndex = 0;
            this.birthdayLabel.Text = "Data urodzenia";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(197, 18);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(208, 29);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(197, 60);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(208, 29);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Location = new System.Drawing.Point(197, 103);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(208, 29);
            this.birthdayTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.38136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.61864F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productNameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.priceProductTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.quantityProductTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(57, 225);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 68);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(287, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ilość:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa produktu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNameTextBox.Location = new System.Drawing.Point(4, 35);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(277, 29);
            this.productNameTextBox.TabIndex = 3;
            // 
            // priceProductTextBox
            // 
            this.priceProductTextBox.AutoSize = true;
            this.priceProductTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceProductTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceProductTextBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priceProductTextBox.Location = new System.Drawing.Point(473, 3);
            this.priceProductTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceProductTextBox.Name = "priceProductTextBox";
            this.priceProductTextBox.Size = new System.Drawing.Size(164, 26);
            this.priceProductTextBox.TabIndex = 3;
            this.priceProductTextBox.Text = "Cena:";
            this.priceProductTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityProductTextBox
            // 
            this.quantityProductTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityProductTextBox.Location = new System.Drawing.Point(288, 35);
            this.quantityProductTextBox.Name = "quantityProductTextBox";
            this.quantityProductTextBox.Size = new System.Drawing.Size(179, 29);
            this.quantityProductTextBox.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(474, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 29);
            this.textBox3.TabIndex = 4;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(57, 169);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(140, 32);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Dodaj produkt";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(223, 169);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(141, 32);
            this.deleteProductButton.TabIndex = 3;
            this.deleteProductButton.Text = "Usuń produkt";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // changeProductButton
            // 
            this.changeProductButton.Location = new System.Drawing.Point(387, 169);
            this.changeProductButton.Name = "changeProductButton";
            this.changeProductButton.Size = new System.Drawing.Size(163, 32);
            this.changeProductButton.TabIndex = 3;
            this.changeProductButton.Text = "Zmień produkt";
            this.changeProductButton.UseVisualStyleBackColor = true;
            // 
            // saveToDatabaseButton
            // 
            this.saveToDatabaseButton.Location = new System.Drawing.Point(308, 550);
            this.saveToDatabaseButton.Name = "saveToDatabaseButton";
            this.saveToDatabaseButton.Size = new System.Drawing.Size(216, 32);
            this.saveToDatabaseButton.TabIndex = 3;
            this.saveToDatabaseButton.Text = "Zapisz do bazy danych";
            this.saveToDatabaseButton.UseVisualStyleBackColor = true;
            // 
            // saveToXMLButton
            // 
            this.saveToXMLButton.Location = new System.Drawing.Point(534, 550);
            this.saveToXMLButton.Name = "saveToXMLButton";
            this.saveToXMLButton.Size = new System.Drawing.Size(163, 32);
            this.saveToXMLButton.TabIndex = 3;
            this.saveToXMLButton.Text = "Zapisz do XML";
            this.saveToXMLButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameColumn1,
            this.quantityProductColumn2,
            this.priceProductColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(57, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(636, 207);
            this.dataGridView1.TabIndex = 4;
            // 
            // productNameColumn1
            // 
            this.productNameColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameColumn1.HeaderText = "Nazwa Produktu";
            this.productNameColumn1.MinimumWidth = 180;
            this.productNameColumn1.Name = "productNameColumn1";
            // 
            // quantityProductColumn2
            // 
            this.quantityProductColumn2.HeaderText = "Ilość";
            this.quantityProductColumn2.MinimumWidth = 150;
            this.quantityProductColumn2.Name = "quantityProductColumn2";
            this.quantityProductColumn2.Width = 150;
            // 
            // priceProductColumn3
            // 
            this.priceProductColumn3.HeaderText = "Cena";
            this.priceProductColumn3.MinimumWidth = 150;
            this.priceProductColumn3.Name = "priceProductColumn3";
            this.priceProductColumn3.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 594);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveToXMLButton);
            this.Controls.Add(this.saveToDatabaseButton);
            this.Controls.Add(this.changeProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox quantityProductTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label priceProductTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button changeProductButton;
        private System.Windows.Forms.Button saveToDatabaseButton;
        private System.Windows.Forms.Button saveToXMLButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityProductColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceProductColumn3;
    }
}

