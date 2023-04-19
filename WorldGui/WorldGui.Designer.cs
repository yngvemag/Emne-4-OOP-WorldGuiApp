namespace WorldGui
{
    partial class WorldGui
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
            dataGridWorld = new DataGridView();
            radioBtnCountry = new RadioButton();
            radioBtnCities = new RadioButton();
            radioBtnCountryLanguage = new RadioButton();
            txtFilter = new TextBox();
            treeViewWorld = new TreeView();
            listErrors = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridWorld).BeginInit();
            SuspendLayout();
            // 
            // dataGridWorld
            // 
            dataGridWorld.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridWorld.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridWorld.Location = new Point(12, 45);
            dataGridWorld.Name = "dataGridWorld";
            dataGridWorld.RowHeadersWidth = 51;
            dataGridWorld.RowTemplate.Height = 29;
            dataGridWorld.Size = new Size(791, 516);
            dataGridWorld.TabIndex = 0;
            // 
            // radioBtnCountry
            // 
            radioBtnCountry.AutoSize = true;
            radioBtnCountry.Location = new Point(16, 9);
            radioBtnCountry.Name = "radioBtnCountry";
            radioBtnCountry.Size = new Size(92, 24);
            radioBtnCountry.TabIndex = 1;
            radioBtnCountry.TabStop = true;
            radioBtnCountry.Text = "Countries";
            radioBtnCountry.UseVisualStyleBackColor = true;
            // 
            // radioBtnCities
            // 
            radioBtnCities.AutoSize = true;
            radioBtnCities.Location = new Point(136, 9);
            radioBtnCities.Name = "radioBtnCities";
            radioBtnCities.Size = new Size(66, 24);
            radioBtnCities.TabIndex = 2;
            radioBtnCities.TabStop = true;
            radioBtnCities.Text = "Cities";
            radioBtnCities.UseVisualStyleBackColor = true;
            // 
            // radioBtnCountryLanguage
            // 
            radioBtnCountryLanguage.AutoSize = true;
            radioBtnCountryLanguage.Location = new Point(231, 9);
            radioBtnCountryLanguage.Name = "radioBtnCountryLanguage";
            radioBtnCountryLanguage.Size = new Size(146, 24);
            radioBtnCountryLanguage.TabIndex = 3;
            radioBtnCountryLanguage.TabStop = true;
            radioBtnCountryLanguage.Text = "CountryLanguage";
            radioBtnCountryLanguage.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(727, 8);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(533, 27);
            txtFilter.TabIndex = 4;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // treeViewWorld
            // 
            treeViewWorld.Location = new Point(824, 45);
            treeViewWorld.Name = "treeViewWorld";
            treeViewWorld.Size = new Size(423, 516);
            treeViewWorld.TabIndex = 5;
            // 
            // listErrors
            // 
            listErrors.BackColor = Color.FromArgb(255, 128, 0);
            listErrors.FormattingEnabled = true;
            listErrors.ItemHeight = 20;
            listErrors.Location = new Point(12, 567);
            listErrors.Name = "listErrors";
            listErrors.Size = new Size(1235, 144);
            listErrors.TabIndex = 6;
            // 
            // WorldGui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 720);
            Controls.Add(listErrors);
            Controls.Add(treeViewWorld);
            Controls.Add(txtFilter);
            Controls.Add(radioBtnCountryLanguage);
            Controls.Add(radioBtnCities);
            Controls.Add(radioBtnCountry);
            Controls.Add(dataGridWorld);
            Name = "WorldGui";
            Text = "WorldGui";
            ((System.ComponentModel.ISupportInitialize)dataGridWorld).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridWorld;
        private RadioButton radioBtnCountry;
        private RadioButton radioBtnCities;
        private RadioButton radioBtnCountryLanguage;
        private TextBox txtFilter;
        private TreeView treeViewWorld;
        private ListBox listErrors;
    }
}