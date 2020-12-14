using Dapper;
using POS.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace POS.Classes
{
	public static class Manager
	{
		public static string ConnectionString
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
			}
		}

		public static void Show(string Message, Notification.Type type)
		{
			Notification not = new Notification();
			not.Popup(Message, type);
		}

		public static List<DateTime> GetMonthsBetweenDates(DateTime startdate, DateTime enddate)
		{
			List<DateTime> li = new List<DateTime>();
			while (startdate <= enddate)
			{
				// pull out month and year
				li.Add(new DateTime(startdate.Year, startdate.Month, startdate.Day));
				startdate = startdate.AddMonths(1);
			}
			return li;
		}

		public static void ExportDataGrid(DataGridView dataGridView1)
		{
			int rownum = 1;
			// intialize excel application
			var excelApp = new Excel.Application();
			excelApp.Visible = true;
			// creates a workbook
			Excel.Workbook excelbk = excelApp.Workbooks.Add(Type.Missing);
			//Add a Workseet named sheet1 to above workbook
			Excel.Worksheet xlWorkSheet1 = (Excel.Worksheet)excelbk.Worksheets["Sheet1"];

			//Add each column name of datagridview to the first row of Excel,
			//this will be the header text
			for (int colCount = 0; colCount < dataGridView1.Columns.Count; colCount++)
			{
				Excel.Range xlRange = (Excel.Range)xlWorkSheet1.Cells[rownum, colCount + 1];
				xlRange.Value2 = dataGridView1.Columns[colCount].HeaderText;
				xlRange.Font.Bold = true;
			}
			// for each row in the datagridview
			for (int rowCount = 0; rowCount < dataGridView1.Rows.Count; rowCount++)
			{
				//if the row is visible
				if (dataGridView1.Rows[rowCount].Visible == true)
				{
					//increment the row number for excel
					rownum = rownum + 1;
					for (int colCount = 0; colCount < dataGridView1.Columns.Count; colCount++)
					{
						//create a excel range for the rownum and the columncount
						Excel.Range xlRange = (Excel.Range)xlWorkSheet1.Cells[rownum, colCount + 1];
						try
						{
							//add the gridview cell value to the cellrange
							if (dataGridView1.Rows[rowCount].Cells[colCount].Value == null)
								dataGridView1.Rows[rowCount].Cells[colCount].Value = "";
							xlRange.Value2 =
							dataGridView1.Rows[rowCount].Cells[colCount].Value.ToString();
						}
						catch (Exception)
						{
							try
							{
								xlRange.Value2 = "";
							}
							catch (Exception)
							{

							}
						}
					}
				}
			}
		}
	}

	public class User
	{
		[Key]
		[Required]
		public int Id { get; set; } = 0;

		public string Name { get; set; } = "Usama";

		public string Role { get; set; } = "Developer";

		public string Username { get; set; } = "usama";

		public string Pass { get; set; } = "123";

	}

	public static class Login
	{
		public static int Id { get; set; } = 0;

		public static string Name { get; set; } = "Usama";

		public static string Role { get; set; } = "Developer";

		public static string Username { get; set; } = "usama";

		public static string Password { get; set; } = "123";

	}
}
