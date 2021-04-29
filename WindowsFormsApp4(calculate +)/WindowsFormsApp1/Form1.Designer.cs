namespace WindowsFormsApp1
{
    partial class Calculator_Main
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
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblenteryourname = new System.Windows.Forms.Label();
            this.txtenteryourname = new System.Windows.Forms.TextBox();
            this.txteenteryoursalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(64, 105);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 31);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(147, 105);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(74, 31);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "cle&ar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(229, 105);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 31);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblenteryourname
            // 
            this.lblenteryourname.AutoSize = true;
            this.lblenteryourname.Location = new System.Drawing.Point(25, 26);
            this.lblenteryourname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblenteryourname.Name = "lblenteryourname";
            this.lblenteryourname.Size = new System.Drawing.Size(98, 17);
            this.lblenteryourname.TabIndex = 6;
            this.lblenteryourname.Text = "Enteryourname";
            // 
            // txtenteryourname
            // 
            this.txtenteryourname.Location = new System.Drawing.Point(172, 18);
            this.txtenteryourname.Margin = new System.Windows.Forms.Padding(4);
            this.txtenteryourname.Name = "txtenteryourname";
            this.txtenteryourname.Size = new System.Drawing.Size(132, 25);
            this.txtenteryourname.TabIndex = 0;
            // 
            // txteenteryoursalary
            // 
            this.txteenteryoursalary.Location = new System.Drawing.Point(172, 60);
            this.txteenteryoursalary.Margin = new System.Windows.Forms.Padding(4);
            this.txteenteryoursalary.Name = "txteenteryoursalary";
            this.txteenteryoursalary.Size = new System.Drawing.Size(132, 25);
            this.txteenteryoursalary.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enteryoursalary";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(25, 156);
            this.lblresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 17);
            this.lblresult.TabIndex = 7;
            this.lblresult.Click += new System.EventHandler(this.label2_Click);
            // 
            // Calculator_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 182);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txteenteryoursalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtenteryourname);
            this.Controls.Add(this.lblenteryourname);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculator_Main";
            this.Text = "salary Calculateor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblenteryourname;
        private System.Windows.Forms.TextBox txtenteryourname;
        private System.Windows.Forms.TextBox txteenteryoursalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
    }
}

