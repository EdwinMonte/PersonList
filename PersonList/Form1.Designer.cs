namespace PersonList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            numAge = new NumericUpDown();
            btnAddPerson = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            listBoxPeople = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(42, 59);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 60);
            txtName.TabIndex = 0;
            // 
            // numAge
            // 
            numAge.Location = new Point(42, 151);
            numAge.Name = "numAge";
            numAge.Size = new Size(150, 27);
            numAge.TabIndex = 1;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(42, 197);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(94, 29);
            btnAddPerson.TabIndex = 2;
            btnAddPerson.Text = "Add Person";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(42, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(42, 323);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // listBoxPeople
            // 
            listBoxPeople.FormattingEnabled = true;
            listBoxPeople.Location = new Point(198, 62);
            listBoxPeople.Name = "listBoxPeople";
            listBoxPeople.Size = new Size(488, 284);
            listBoxPeople.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPeople);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnAddPerson);
            Controls.Add(numAge);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private NumericUpDown numAge;
        private Button btnAddPerson;
        private Button btnSave;
        private Button btnLoad;
        private ListBox listBoxPeople;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
