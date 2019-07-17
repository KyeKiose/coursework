using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace BalanceApp
{
    public class ReadDataFromExcel
    {
        public string path = "";
        public _Application excel = new _Excel.Application();
        public Workbook workbook;
        Worksheet worksheet;
        public ReadDataFromExcel(string pth, int sheet)
        {
            this.path = pth;
            workbook = excel.Workbooks.Open(path, 0, true); //открывать в режиме чтения
            worksheet = workbook.Worksheets[sheet];
 
        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (worksheet.Cells[i, j].Value2 != null)
                return worksheet.Cells[i, j].Value2;
            else
                return "";
        }
         
    }
}
