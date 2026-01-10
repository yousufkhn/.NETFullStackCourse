namespace SerializationDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBinSerialize = new System.Windows.Forms.Button();
            this.btnBinUnserialize = new System.Windows.Forms.Button();
            this.btnXmlSerialize = new System.Windows.Forms.Button();
            this.btnXmlDeSerialize = new System.Windows.Forms.Button();
            this.btnSoapSerialize = new System.Windows.Forms.Button();
            this.btnSoapDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp ID";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(555, 72);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(173, 31);
            this.txtEmpID.TabIndex = 1;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(555, 123);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(172, 31);
            this.txtEmpName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emp Name";
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSalary.Location = new System.Drawing.Point(555, 171);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(172, 31);
            this.txtEmpSalary.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Emp Salary";
            // 
            // btnBinSerialize
            // 
            this.btnBinSerialize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinSerialize.Location = new System.Drawing.Point(203, 258);
            this.btnBinSerialize.Name = "btnBinSerialize";
            this.btnBinSerialize.Size = new System.Drawing.Size(198, 36);
            this.btnBinSerialize.TabIndex = 6;
            this.btnBinSerialize.Text = "Bin Serialize";
            this.btnBinSerialize.UseVisualStyleBackColor = true;
            this.btnBinSerialize.Click += new System.EventHandler(this.btnBinSerialize_Click);
            // 
            // btnBinUnserialize
            // 
            this.btnBinUnserialize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinUnserialize.Location = new System.Drawing.Point(203, 326);
            this.btnBinUnserialize.Name = "btnBinUnserialize";
            this.btnBinUnserialize.Size = new System.Drawing.Size(198, 36);
            this.btnBinUnserialize.TabIndex = 7;
            this.btnBinUnserialize.Text = "Bin Unserialize";
            this.btnBinUnserialize.UseVisualStyleBackColor = true;
            this.btnBinUnserialize.Click += new System.EventHandler(this.btnBinUnserialize_Click);
            // 
            // btnXmlSerialize
            // 
            this.btnXmlSerialize.AutoSize = true;
            this.btnXmlSerialize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmlSerialize.Location = new System.Drawing.Point(488, 258);
            this.btnXmlSerialize.Name = "btnXmlSerialize";
            this.btnXmlSerialize.Size = new System.Drawing.Size(149, 36);
            this.btnXmlSerialize.TabIndex = 8;
            this.btnXmlSerialize.Text = "XML Serialize";
            this.btnXmlSerialize.UseVisualStyleBackColor = true;
            this.btnXmlSerialize.Click += new System.EventHandler(this.btnXmlSerialize_Click);
            // 
            // btnXmlDeSerialize
            // 
            this.btnXmlDeSerialize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmlDeSerialize.Location = new System.Drawing.Point(488, 326);
            this.btnXmlDeSerialize.Name = "btnXmlDeSerialize";
            this.btnXmlDeSerialize.Size = new System.Drawing.Size(183, 36);
            this.btnXmlDeSerialize.TabIndex = 9;
            this.btnXmlDeSerialize.Text = "XML Deserialize";
            this.btnXmlDeSerialize.UseVisualStyleBackColor = true;
            this.btnXmlDeSerialize.Click += new System.EventHandler(this.btnXmlDeSerialize_Click);
            // 
            // btnSoapSerialize
            // 
            this.btnSoapSerialize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoapSerialize.Location = new System.Drawing.Point(695, 258);
            this.btnSoapSerialize.Name = "btnSoapSerialize";
            this.btnSoapSerialize.Size = new System.Drawing.Size(211, 36);
            this.btnSoapSerialize.TabIndex = 10;
            this.btnSoapSerialize.Text = "SOAP Serialize";
            this.btnSoapSerialize.UseVisualStyleBackColor = true;
            this.btnSoapSerialize.Click += new System.EventHandler(this.btnSoapSerialize_Click);
            // 
            // btnSoapDeserialize
            // 
            this.btnSoapDeserialize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoapDeserialize.Location = new System.Drawing.Point(695, 326);
            this.btnSoapDeserialize.Name = "btnSoapDeserialize";
            this.btnSoapDeserialize.Size = new System.Drawing.Size(211, 36);
            this.btnSoapDeserialize.TabIndex = 11;
            this.btnSoapDeserialize.Text = "SOAP Deserialize";
            this.btnSoapDeserialize.UseVisualStyleBackColor = true;
            this.btnSoapDeserialize.Click += new System.EventHandler(this.btnSoapDeserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 430);
            this.Controls.Add(this.btnSoapDeserialize);
            this.Controls.Add(this.btnSoapSerialize);
            this.Controls.Add(this.btnXmlDeSerialize);
            this.Controls.Add(this.btnXmlSerialize);
            this.Controls.Add(this.btnBinUnserialize);
            this.Controls.Add(this.btnBinSerialize);
            this.Controls.Add(this.txtEmpSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Stencil", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBinSerialize;
        private System.Windows.Forms.Button btnBinUnserialize;
        private System.Windows.Forms.Button btnXmlSerialize;
        private System.Windows.Forms.Button btnXmlDeSerialize;
        private System.Windows.Forms.Button btnSoapSerialize;
        private System.Windows.Forms.Button btnSoapDeserialize;
    }
}

