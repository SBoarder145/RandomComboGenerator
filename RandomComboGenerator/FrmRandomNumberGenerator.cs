namespace RandomComboGenerator
{
	public partial class frmRandomNumberGenerator : Form
	{
		private static List<string> lstGroup1 = new();
		private static List<string> lstGroup2 = new();
		private bool isFirstResult = true;
		private readonly Random random = new();
		private readonly string resetMessage = "\r\n---------- RESET ----------\r\n";

		private bool origAllowDups1 = false;
		private bool origIsRangeSelected1 = false;
		private int origMin1 = 0;
		private int origMax1 = 0;
		private string origCustom1 = string.Empty;

		private bool origAllowDups2 = false;
		private bool origIsRangeSelected2 = false;
		private int origMin2 = 0;
		private int origMax2 = 0;
		private string origCustom2 = string.Empty;

		public frmRandomNumberGenerator()
		{
			InitializeComponent();

			// Remove up/down arrows on Min/Max
			numMin1.Controls.RemoveAt(0);
			numMax1.Controls.RemoveAt(0);
			numMin2.Controls.RemoveAt(0);
			numMax2.Controls.RemoveAt(0);
		}

		private void rbRange1_CheckedChanged(object sender, EventArgs e)
		{
			numMin1.ReadOnly = !rbRange1.Checked;
			numMax1.ReadOnly = !rbRange1.Checked;
		}

		private void rbCustom1_CheckedChanged(object sender, EventArgs e)
		{
			txtCustom1.ReadOnly = !rbCustom1.Checked;
		}

		private void btnClearCustom1_Click(object sender, EventArgs e)
		{
			txtCustom1.Text = string.Empty;
		}

		private void rbRange2_CheckedChanged(object sender, EventArgs e)
		{
			numMin2.ReadOnly = !rbRange2.Checked;
			numMax2.ReadOnly = !rbRange2.Checked;
		}

		private void rbCustom2_CheckedChanged(object sender, EventArgs e)
		{
			txtCustom2.ReadOnly = !rbCustom2.Checked;
		}

		private void btnClearCustom2_Click(object sender, EventArgs e)
		{
			txtCustom2.Text = string.Empty;
		}

		private void btnCopy1To2_Click(object sender, EventArgs e)
		{
			chkAllowDups2.Checked = chkAllowDups1.Checked;

			rbRange2.Checked = rbRange1.Checked;
			numMin2.Text = numMin1.Text;
			numMax2.Text = numMax1.Text;

			rbCustom2.Checked = rbCustom1.Checked;
			txtCustom2.Text = txtCustom1.Text;
		}

		private void btnCopy2To1_Click(object sender, EventArgs e)
		{
			chkAllowDups1.Checked = chkAllowDups2.Checked;

			rbRange1.Checked = rbRange2.Checked;
			numMin1.Text = numMin2.Text;
			numMax1.Text = numMax2.Text;

			rbCustom1.Checked = rbCustom2.Checked;
			txtCustom1.Text = txtCustom2.Text;
		}

		private void btnResetInput_Click(object sender, EventArgs e)
		{
			chkAllowDupMatch.Checked = false;

			// Group 1
			chkAllowDups1.Checked = false;
			rbDoNotUse1.Checked = true;
			numMin1.Value = 0;
			numMax1.Value = 0;
			txtCustom1.Text = string.Empty;

			// Group 2
			chkAllowDups2.Checked = false;
			rbDoNotUse2.Checked = true;
			numMin2.Value = 0;
			numMax2.Value = 0;
			txtCustom2.Text = string.Empty;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtResults.Text))
			{
				isFirstResult = false;

				OutputToResultWindow(resetMessage);
				InitializeLists();
			}
		}

		private void btnClearResults_Click(object sender, EventArgs e)
		{
			isFirstResult = true;

			lstGroup1 = new List<string>();
			lstGroup2 = new List<string>();
			lblCount1.Text = "0";
			lblCount2.Text = "0";
			txtResults.Text = string.Empty;
		}

		private void btnSingleResult_Click(object sender, EventArgs e)
		{
			ValidateParameters();
			GenerateAndDisplayResult(true);
		}

		private void btnAllResults_Click(object sender, EventArgs e)
		{
			ValidateParameters();
			do
			{
				GenerateAndDisplayResult(false);
			} while (lstGroup1.Count > 0 && lstGroup2.Count > 0 && !chkAllowDups1.Checked && !chkAllowDups2.Checked);
		}

		private void ValidateParameters()
		{
			if (!isFirstResult)
			{
				if (CheckNewParameters())
				{
					isFirstResult = true;
					OutputToResultWindow("\r\n----- Input parameters have changed. Resetting lists and making selection. -----\r\n");
					InitializeLists();
				}
			}
		}

		private bool CheckNewParameters()
		{
			// Group 1
			if (origAllowDups1 != chkAllowDups1.Checked) { return true; }
			if (origIsRangeSelected1 != rbRange1.Checked) { return true; }
			if (origMin1 != (int)numMin1.Value) { return true; }
			if (origMax1 != (int)numMax1.Value) { return true; }
			if (!origCustom1.Equals(txtCustom1.Text.ToLower())) { return true; }

			// Group 2
			if (origAllowDups2 != chkAllowDups2.Checked) { return true; }
			if (origIsRangeSelected2 != rbRange2.Checked) { return true; }
			if (origMin2 != (int)numMin2.Value) { return true; }
			if (origMax2 != (int)numMax2.Value) { return true; }
			if (!origCustom2.Equals(txtCustom2.Text.ToLower())) { return true; }

			return false;
		}

		private void SetNewPreviousParameters()
		{
			// Group 1
			origAllowDups1 = chkAllowDups1.Checked;
			origIsRangeSelected1 = rbRange1.Checked;
			origMin1 = (int)numMin1.Value;
			origMax1 = (int)numMax1.Value;
			origCustom1 = txtCustom1.Text.ToLower();

			// Group 2
			origAllowDups2 = chkAllowDups2.Checked;
			origIsRangeSelected2 = rbRange2.Checked;
			origMin2 = (int)numMin2.Value;
			origMax2 = (int)numMax2.Value;
			origCustom2 = txtCustom2.Text.ToLower();
		}

		private void GenerateAndDisplayResult(bool isSingleResult)
		{
			var g1Pick = string.Empty;
			var g2Pick = string.Empty;
			var result = "{ ";

			// Initial validation
			if (rbDoNotUse1.Checked && rbDoNotUse2.Checked) { return; }

			if ((rbRange1.Checked && (int)numMin1.Value >= (int)numMax1.Value) || (rbRange2.Checked && (int)numMin2.Value >= (int)numMax2.Value))
			{
				OutputToResultWindow("----- Minimum value must be lower than maximum value -----\r\n");
				return;
			}

			// Initial list(s)
			if (isFirstResult) { InitializeLists(); };

			// Check if entries are exhausted
			var isGroup1Exhausted = !rbDoNotUse1.Checked && !chkAllowDups1.Checked && lstGroup1.Count == 0;
			var isGroup2Exhausted = !rbDoNotUse2.Checked && !chkAllowDups2.Checked && lstGroup2.Count == 0;

			if (isGroup1Exhausted || isGroup2Exhausted)
			{
				if (!PromptRefresh(isGroup1Exhausted, isGroup2Exhausted)) { return; }
			}

			// Perform RNG magic
			do
			{
				if (!rbDoNotUse1.Checked) { g1Pick = Pick(lstGroup1); }
				if (!rbDoNotUse2.Checked) { g2Pick = Pick(lstGroup2); }
			} while (!chkAllowDupMatch.Checked && !string.IsNullOrEmpty(g1Pick) && !string.IsNullOrEmpty(g2Pick) && g1Pick.ToLower().Equals(g2Pick.ToLower()));

			// Generate output message
			result += g1Pick;
			if (!string.IsNullOrEmpty(g1Pick) && !string.IsNullOrEmpty(g2Pick)) { result += " | "; }
			result += $"{g2Pick} }}";
			OutputToResultWindow(result);

			//check dup picks, drop if no dup picks
			if (!chkAllowDups1.Checked)
			{
				lstGroup1.Remove(g1Pick);
				lblCount1.Text = lstGroup1.Count.ToString();
			}

			if (!chkAllowDups2.Checked)
			{
				lstGroup2.Remove(g2Pick);
				lblCount2.Text = lstGroup2.Count.ToString();
			}

			isFirstResult = false;
		}

		private bool PromptRefresh(bool isGroup1Exhausted, bool isGroup2Exhausted)
		{
			var groups = string.Empty;
			var plural = string.Empty;

			if (isGroup1Exhausted && isGroup2Exhausted)
			{
				groups = "groups 1 and 2";
				plural = "s";
			}
			else if (isGroup1Exhausted) { groups = "group 1"; }
			else { groups = "group 2"; }

			if (MessageBox.Show($"There are no more entries in {groups}. Would you like to refresh the list{plural} and continue?",
				"Refresh List", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				if (isGroup1Exhausted) { lstGroup1 = InitializeList(true); }
				if (isGroup2Exhausted) { lstGroup2 = InitializeList(false); }

				OutputToResultWindow(resetMessage);

				return true;
			}
			else { return false; }
		}

		private string Pick(List<string> list)
		{
			return list[random.Next(list.Count)];
		}

		private void OutputToResultWindow(string message)
		{
			var resultWindowMessage = string.Empty;

			if (!isFirstResult) { resultWindowMessage += "\r\n"; }

			resultWindowMessage += message;

			txtResults.AppendText(resultWindowMessage);
		}

		private void InitializeLists()
		{
			if (!rbDoNotUse1.Checked)
			{
				lstGroup1 = InitializeList(true);
				lblCount1.Text = lstGroup1.Count.ToString();
			}

			if (!rbDoNotUse2.Checked)
			{
				lstGroup2 = InitializeList(false);
				lblCount2.Text = lstGroup2.Count.ToString();
			}

			SetNewPreviousParameters();
		}

		private List<string> InitializeList(bool isGroup1)
		{
			List<string> lstGroup = new();
			var isRangeChecked = isGroup1 ? rbRange1.Checked : rbRange2.Checked;
			var min = isGroup1 ? (int)numMin1.Value : (int)numMin2.Value;
			var max = isGroup1 ? (int)numMax1.Value : (int)numMax2.Value;
			var custom = isGroup1 ? txtCustom1.Text : txtCustom2.Text;

			// Compile entries
			if (isRangeChecked)
			{
				if (isRangeChecked && min >= max)
				{
					OutputToResultWindow("\r\n----- Minimum value must be lower than maximum value -----");
					return new List<string>();
				}

				for (int i = min; i <= max; i++)
				{
					lstGroup.Add(i.ToString());
				}
			}
			else
			{
				lstGroup = custom.Split(Environment.NewLine).ToList();
			}

			return lstGroup;
		}
	}
}