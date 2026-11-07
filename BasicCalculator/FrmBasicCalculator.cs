using System;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
	public partial class FrmBasicCalculator : Form
	{
		public FrmBasicCalculator()
		{
			InitializeComponent();
			cmbOperator.SelectedIndex = 0;
		}

		private void btnCompute_Click(object sender, EventArgs e)
		{
			try
			{
				float num1 = float.Parse(txtNum1.Text);
				float num2 = float.Parse(txtNum2.Text);
				float total = 0;

				string? selectedOperator = cmbOperator.SelectedItem?.ToString();

				if (selectedOperator == null)
				{
					MessageBox.Show("Please select a valid operator.");
					return;
				}

				switch (selectedOperator)
				{
					case "+":
						total = BasicComputation.Addition(num1, num2);
						break;
					case "-":
						total = BasicComputation.Subtraction(num1, num2);
						break;
					case "*":
						total = BasicComputation.Multiplication(num1, num2);
						break;
					case "/":
						total = BasicComputation.Division(num1, num2);
						break;
					default:
						MessageBox.Show("Please select a valid operator.");
						return;
				}

				lblTotal.Text = total.ToString();
			}
			catch (FormatException)
			{
				MessageBox.Show("Please enter valid numerical values.");
			}
			catch (DivideByZeroException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}
	}
}
