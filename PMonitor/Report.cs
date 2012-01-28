using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;


namespace PMonitor
{
    class Report
    {

        public static void generate(DataTable dt)
        {
            Application oXL;
            Workbook oWB;
            Worksheet oSheet;
            Range oRange; 


            // Start Excel and get Application object.
            oXL = new Application();

            // Set some properties
           
            oXL.DisplayAlerts = false;

            // Get a new workbook.
            oWB = oXL.Workbooks.Add(Missing.Value);

            // Get the active sheet
            oSheet = (Worksheet)oWB.ActiveSheet;
            oSheet.Name = "Customers";

            // Process the DataTable
            // BE SURE TO CHANGE THIS LINE TO USE *YOUR* DATATABLE
           

            int rowCount = 1;
            foreach (DataRow dr in dt.Rows)
            {
                rowCount += 1;
                for (int i = 1; i < dt.Columns.Count + 1; i++)
                {
                    // Add the header the first time through
                    if (rowCount == 2)
                    {
                        oSheet.Cells[1, i] = dt.Columns[i - 1].ColumnName;
                    }
                    oSheet.Cells[rowCount, i] = dr[i - 1].ToString();
                }
            }

            // Resize the columns
            oRange = oSheet.Range[oSheet.Cells[1, 1],
                          oSheet.Cells[rowCount, dt.Columns.Count]];
            oRange.EntireColumn.AutoFit();
            oXL.Visible = true;
            // Save the sheet and close
            oSheet = null;
            oRange = null;
            oWB.SaveAs("test.xls", XlFileFormat.xlWorkbookNormal,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                XlSaveAsAccessMode.xlExclusive,
                Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value);
           // oWB.Close(Missing.Value, Missing.Value, Missing.Value);
            oWB = null;
            oXL = null;
           // oXL.Quit();

            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect(); 

        }
    }
}
