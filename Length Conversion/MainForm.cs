/*
 * Created by SharpDevelop.
 * User: GiaRosArt
 * Date: 08/09/2023
 * Time: 12:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Length_Conversion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cmbValue.SelectedItem = "Centimetre";
			cmbResults.SelectedItem = "Foot";
			txtResults.Text = (float.Parse(txtValue.Text) / 30.48).ToString();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalculateClick(object sender, EventArgs e)
		{
			float v;
			
			if(float.TryParse(txtValue.Text, out v))
			{
				if (cmbValue.Text == "Millimetre")
				{
					if (cmbResults.Text == "Millimetre")
					{
						txtResults.Text = txtValue.Text;
					}
					if (cmbResults.Text == "Centimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 10).ToString();
					}
					if (cmbResults.Text == "Metre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 1000).ToString();
					}
					if (cmbResults.Text == "Inch")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 25.4).ToString();
					}
					if (cmbResults.Text == "Foot")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 304.8).ToString();
					}
					if (cmbResults.Text == "Yard")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 914.4).ToString();
					}
				}
				if (cmbValue.Text == "Centimetre")
				{
					if (cmbResults.Text == "Millimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 10).ToString();
					}
					if (cmbResults.Text == "Centimetre")
					{
						txtResults.Text = txtValue.Text;
					}
					if (cmbResults.Text == "Metre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 100).ToString();
					}
					if (cmbResults.Text == "Inch")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 2.54).ToString();
					}
					if (cmbResults.Text == "Foot")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 30.48).ToString();
					}
					if (cmbResults.Text == "Yard")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 91.44).ToString();
					}
				}
				if (cmbValue.Text == "Metre")
				{
					if (cmbResults.Text == "Millimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 1000).ToString();
					}
					if (cmbResults.Text == "Centimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 100).ToString();
					}
					if (cmbResults.Text == "Metre")
					{
						txtResults.Text = txtValue.Text;
					}
					if (cmbResults.Text == "Inch")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 39.3701).ToString();
					}
					if (cmbResults.Text == "Foot")
					{
						txtResults.Text = (float.Parse(txtValue.Text) *  3.28084).ToString();
					}
					if (cmbResults.Text == "Yard")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 1.09361).ToString();
					}
				}
				if (cmbValue.Text == "Inch")
				{
					if (cmbResults.Text == "Millimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 25.4).ToString();
					}
					if (cmbResults.Text == "Centimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 2.54).ToString();
					}
					if (cmbResults.Text == "Metre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 39.3701).ToString();	
					}
					if (cmbResults.Text == "Inch")
					{
						txtResults.Text = txtValue.Text;
					}
					if (cmbResults.Text == "Foot")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 12).ToString();
					}
					if (cmbResults.Text == "Yard")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 36).ToString();
					}
				}
				if (cmbValue.Text == "Foot")
				{
					if (cmbResults.Text == "Millimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 304.8).ToString();
					}
					if (cmbResults.Text == "Centimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 30.48).ToString();
					}
					if (cmbResults.Text == "Metre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 3.281).ToString();	
					}
					if (cmbResults.Text == "Inch")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 12).ToString();
					}
					if (cmbResults.Text == "Foot")
					{
						txtResults.Text = txtValue.Text;
					}
					if (cmbResults.Text == "Yard")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 3).ToString();
					}
				}
				if (cmbValue.Text == "Yard")
				{
					if (cmbResults.Text == "Millimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 914.4).ToString();
					}
					if (cmbResults.Text == "Centimetre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 91.44).ToString();
					}
					if (cmbResults.Text == "Metre")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 1.094).ToString();	
					}
					if (cmbResults.Text == "Inch")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 36).ToString();
					}
					if (cmbResults.Text == "Foot")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 3).ToString();
					}
					if (cmbResults.Text == "Yard")
					{
						txtResults.Text = txtValue.Text;
					}
				}
			}
		}
	}
}