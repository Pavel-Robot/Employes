﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormTest.LogicProgram
{
    class ExcelHelper : IDisposable
    {
        private Excel.Application _excel;
        private Excel.Workbook _workbook;
        private string _filePath;

        public ExcelHelper()
        {
            _excel = new Excel.Application();


            _excel.StandardFontSize = 13;

            
            /*
            _excel.Columns[1].Width = 30;
            _excel.Columns[2].Width = 31;
            _excel.Columns[3].Width = 8;

            _excel.Height = 20;
            */
        }

        internal bool Open(string filePath)
        {
            try
            {
                //if (File.Exists(filePath))
                //{
                //    _workbook = _excel.Workbooks.Open(filePath);
                //}
                //else
                //{
                    _workbook = _excel.Workbooks.Add();
                    _filePath = filePath;
                //}



                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        internal void Save()
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                _workbook.SaveAs(_filePath);
                _filePath = null;
            }
            else
            {
                _workbook.Save();
            }
        }

        internal bool Set(string column, int row, object data)
        {
            try
            {
                // var val = ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].Value2;

                ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column] = data;
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        internal object Get(string column, int row)
        {
            try
            {
                return ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].Value2;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }


        internal void Size(int widht, int height) {
        
            
        }


        public void Dispose()
        {
            try
            {
                _workbook.Close();
                _excel.Quit();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }


}

