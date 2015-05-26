using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;


namespace clases
{
    public class cLeeXls
    {




        /*/-----------otra solucion----soluicion 01-------------------/*/

        public static DataTable ReadAsDataTable(string fileName)
        {
            DataTable dataTable = new DataTable();
            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();

                foreach (Cell cell in rows.ElementAt(0))
                {
                    dataTable.Columns.Add(GetCellValue(spreadSheetDocument, cell));
                }

                foreach (Row row in rows)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                    {
                        dataRow[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                    }

                    dataTable.Rows.Add(dataRow);
                }

            }
            dataTable.Rows.RemoveAt(0);

            return dataTable;
        }

        private static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            string value = cell.CellValue.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }













        /*/-----------otra solucion----soluicion 02-------------------/*/














        public static DataTable ExtractExcelSheetValuesToDataTable(string xlsxFilePath, string sheetName)  
        {

        DataTable dt = new DataTable();

        using (SpreadsheetDocument myWorkbook = SpreadsheetDocument.Open(xlsxFilePath, true))        
        {           //Access the main Workbook part, which contains data

            WorkbookPart workbookPart = myWorkbook.WorkbookPart;

            WorksheetPart worksheetPart = null;

            if (!string.IsNullOrEmpty(sheetName))           
            {

                Sheet ss = workbookPart.Workbook.Descendants<Sheet>().Where(s => s.Name == sheetName).SingleOrDefault<Sheet>();

                worksheetPart = (WorksheetPart)workbookPart.GetPartById(ss.Id);
                //worksheetPart = workbookPart.WorksheetParts.FirstOrDefault();

            }            
            else            
            {

                worksheetPart = workbookPart.WorksheetParts.FirstOrDefault();

            } 

            SharedStringTablePart stringTablePart = workbookPart.SharedStringTablePart;

            if (worksheetPart != null)            
            {

                Row lastRow = worksheetPart.Worksheet.Descendants<Row>().LastOrDefault();

                Row firstRow = worksheetPart.Worksheet.Descendants<Row>().FirstOrDefault();

                if (firstRow != null)                
                {

                    foreach (Cell c in firstRow.ChildElements)                    
                    {

                        string value = GetValue(c, stringTablePart);

                        dt.Columns.Add(value);

                    }

                }

                if (lastRow != null)                
                {

                    for (int i = 2; i <= lastRow.RowIndex; i++)                   
                    {

                        DataRow dr = dt.NewRow();

                        bool empty = true;

                      Row row = worksheetPart.Worksheet.Descendants<Row>() .Where(r => i == r.RowIndex).FirstOrDefault();

                        int j = 0;

                         if (row != null)                        
                         {

                            foreach (Cell c in row.ChildElements)                            
                            {

                                //Get cell value

                                string value = GetValue(c, stringTablePart);

                                 if (!string.IsNullOrEmpty(value) && value != "")

                                 empty = false;

                                 dr[j] = value;

                                j++;

                                if (j == dt.Columns.Count)

                                 break;

                            }

                            if (empty)

                                break;

                            dt.Rows.Add(dr);

                        }

                     }

                }

            }

        }

        return dt;

    }

        public static string GetValue(Cell cell, SharedStringTablePart stringTablePart)
        {

            if (cell.ChildElements.Count == 0) return null;

            //get cell value

            string value = cell.ElementAt(0).InnerText;//CellValue.InnerText;

            //Look up real value from shared string table

            if ((cell.DataType != null) && (cell.DataType == CellValues.SharedString))

                value = stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;

            return value;

        }

    }
}
