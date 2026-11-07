namespace BasicCalculator
{
	partial class FrmBasicCalculator
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
			lblTitle = new Label();
			txtNum1 = new TextBox();
			cmbOperator = new ComboBox();
			txtNum2 = new TextBox();
			pnlTotal = new Panel();
			lblTotal = new Label();
			lblTotalHeader = new Label();
			btnCompute = new Button();
			pnlTotal.SuspendLayout();
			SuspendLayout();
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTitle.Location = new Point(107, 23);
			lblTitle.Margin = new Padding(4, 0, 4, 0);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(163, 30);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Basic Calculator";
			// 
			// txtNum1
			// 
			txtNum1.BorderStyle = BorderStyle.FixedSingle;
			txtNum1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtNum1.Location = new Point(31, 174);
			txtNum1.Margin = new Padding(4, 3, 4, 3);
			txtNum1.Name = "txtNum1";
			txtNum1.Size = new Size(301, 39);
			txtNum1.TabIndex = 1;
			txtNum1.Text = "0";
			txtNum1.TextAlign = HorizontalAlignment.Right;
			// 
			// cmbOperator
			// 
			cmbOperator.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbOperator.FlatStyle = FlatStyle.System;
			cmbOperator.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cmbOperator.FormattingEnabled = true;
			cmbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
			cmbOperator.Location = new Point(138, 219);
			cmbOperator.Margin = new Padding(4, 3, 4, 3);
			cmbOperator.Name = "cmbOperator";
			cmbOperator.Size = new Size(81, 33);
			cmbOperator.TabIndex = 2;
			// 
			// txtNum2
			// 
			txtNum2.BorderStyle = BorderStyle.FixedSingle;
			txtNum2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtNum2.Location = new Point(31, 258);
			txtNum2.Margin = new Padding(4, 3, 4, 3);
			txtNum2.Name = "txtNum2";
			txtNum2.Size = new Size(301, 39);
			txtNum2.TabIndex = 3;
			txtNum2.Text = "0";
			txtNum2.TextAlign = HorizontalAlignment.Right;
			// 
			// pnlTotal
			// 
			pnlTotal.BackColor = Color.Black;
			pnlTotal.Controls.Add(lblTotal);
			pnlTotal.Controls.Add(lblTotalHeader);
			pnlTotal.Location = new Point(31, 56);
			pnlTotal.Margin = new Padding(4, 3, 4, 3);
			pnlTotal.Name = "pnlTotal";
			pnlTotal.Size = new Size(301, 98);
			pnlTotal.TabIndex = 4;
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Consolas", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTotal.ForeColor = Color.Lime;
			lblTotal.Location = new Point(12, 44);
			lblTotal.Margin = new Padding(4, 0, 4, 0);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(111, 36);
			lblTotal.TabIndex = 1;
			lblTotal.Text = "000000";
			// 
			// lblTotalHeader
			// 
			lblTotalHeader.AutoSize = true;
			lblTotalHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTotalHeader.ForeColor = Color.Lime;
			lblTotalHeader.Location = new Point(12, 12);
			lblTotalHeader.Margin = new Padding(4, 0, 4, 0);
			lblTotalHeader.Name = "lblTotalHeader";
			lblTotalHeader.Size = new Size(48, 20);
			lblTotalHeader.TabIndex = 0;
			lblTotalHeader.Text = "Total:";
			// 
			// btnCompute
			// 
			btnCompute.FlatStyle = FlatStyle.Flat;
			btnCompute.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCompute.Location = new Point(119, 309);
			btnCompute.Margin = new Padding(4, 3, 4, 3);
			btnCompute.Name = "btnCompute";
			btnCompute.Size = new Size(128, 40);
			btnCompute.TabIndex = 5;
			btnCompute.Text = "Compute";
			btnCompute.UseVisualStyleBackColor = true;
			btnCompute.Click += btnCompute_Click;
			// 
			// FrmBasicCalculator
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			ClientSize = new Size(364, 384);
			Controls.Add(btnCompute);
			Controls.Add(pnlTotal);
			Controls.Add(txtNum2);
			Controls.Add(cmbOperator);
			Controls.Add(txtNum1);
			Controls.Add(lblTitle);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "FrmBasicCalculator";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FrmBasicCalculator";
			pnlTotal.ResumeLayout(false);
			pnlTotal.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.ComboBox cmbOperator;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.Panel pnlTotal;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblTotalHeader;
		private System.Windows.Forms.Button btnCompute;
	}
}
