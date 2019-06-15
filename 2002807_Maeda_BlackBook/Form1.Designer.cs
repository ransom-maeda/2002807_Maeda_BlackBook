namespace _2002807_Maeda_BlackBook
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelPager = new System.Windows.Forms.Label();
            this.labelCellPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelVoicemail = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.lookUp = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.pagerInput = new System.Windows.Forms.TextBox();
            this.cellInput = new System.Windows.Forms.TextBox();
            this.voicemailInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(6, 51);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelPager
            // 
            this.labelPager.AutoSize = true;
            this.labelPager.Location = new System.Drawing.Point(6, 77);
            this.labelPager.Name = "labelPager";
            this.labelPager.Size = new System.Drawing.Size(75, 13);
            this.labelPager.TabIndex = 4;
            this.labelPager.Text = "Pager Number";
            // 
            // labelCellPhone
            // 
            this.labelCellPhone.AutoSize = true;
            this.labelCellPhone.Location = new System.Drawing.Point(6, 103);
            this.labelCellPhone.Name = "labelCellPhone";
            this.labelCellPhone.Size = new System.Drawing.Size(98, 13);
            this.labelCellPhone.TabIndex = 6;
            this.labelCellPhone.Text = "Cell Phone Number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 155);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 13);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email Address";
            // 
            // labelVoicemail
            // 
            this.labelVoicemail.AutoSize = true;
            this.labelVoicemail.Location = new System.Drawing.Point(6, 129);
            this.labelVoicemail.Name = "labelVoicemail";
            this.labelVoicemail.Size = new System.Drawing.Size(95, 13);
            this.labelVoicemail.TabIndex = 8;
            this.labelVoicemail.Text = "Voice mail Number";
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.emailInput);
            this.infoBox.Controls.Add(this.labelName);
            this.infoBox.Controls.Add(this.voicemailInput);
            this.infoBox.Controls.Add(this.labelEmail);
            this.infoBox.Controls.Add(this.cellInput);
            this.infoBox.Controls.Add(this.labelPhone);
            this.infoBox.Controls.Add(this.pagerInput);
            this.infoBox.Controls.Add(this.labelVoicemail);
            this.infoBox.Controls.Add(this.phoneInput);
            this.infoBox.Controls.Add(this.labelPager);
            this.infoBox.Controls.Add(this.nameInput);
            this.infoBox.Controls.Add(this.labelCellPhone);
            this.infoBox.Location = new System.Drawing.Point(12, 12);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(249, 190);
            this.infoBox.TabIndex = 12;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Information";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 209);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 42);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save Person";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // lookUp
            // 
            this.lookUp.Location = new System.Drawing.Point(146, 209);
            this.lookUp.Name = "lookUp";
            this.lookUp.Size = new System.Drawing.Size(115, 42);
            this.lookUp.TabIndex = 14;
            this.lookUp.Text = "Look Up";
            this.lookUp.UseVisualStyleBackColor = true;
            this.lookUp.Click += new System.EventHandler(this.lookUp_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(134, 22);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 15;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(135, 48);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(100, 20);
            this.phoneInput.TabIndex = 16;
            // 
            // pagerInput
            // 
            this.pagerInput.Location = new System.Drawing.Point(135, 74);
            this.pagerInput.Name = "pagerInput";
            this.pagerInput.Size = new System.Drawing.Size(100, 20);
            this.pagerInput.TabIndex = 17;
            // 
            // cellInput
            // 
            this.cellInput.Location = new System.Drawing.Point(135, 100);
            this.cellInput.Name = "cellInput";
            this.cellInput.Size = new System.Drawing.Size(100, 20);
            this.cellInput.TabIndex = 18;
            // 
            // voicemailInput
            // 
            this.voicemailInput.Location = new System.Drawing.Point(135, 126);
            this.voicemailInput.Name = "voicemailInput";
            this.voicemailInput.Size = new System.Drawing.Size(100, 20);
            this.voicemailInput.TabIndex = 19;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(135, 152);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(100, 20);
            this.emailInput.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 269);
            this.Controls.Add(this.lookUp);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.infoBox);
            this.Name = "Form1";
            this.Text = "Black Book";
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelPager;
        private System.Windows.Forms.Label labelCellPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelVoicemail;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button lookUp;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox voicemailInput;
        private System.Windows.Forms.TextBox cellInput;
        private System.Windows.Forms.TextBox pagerInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox nameInput;
    }
}

