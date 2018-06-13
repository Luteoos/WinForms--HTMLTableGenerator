using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTableGenerator
{
    class Model
    {
        private string[,] _htmlCode;
        private string _document;
        private string _lastPath;
#region Static Strings
        private static string _defaultCell = "<td></td>\r\n";
        private static string _startRow = "<tr>\r\n";
        private static string _endRow = "</tr>\r\n";
        private static string _startHtml = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n" +
                                           "<meta charset=\"utf-8\">\r\n" +
                                           " <title>TableGeneratorByMLutecki</title>\r\n  " +
                                           "<style type=\"text/css\">\r\n.tg  {border-collapse:collapse;border-spacing:0;}\r\n" +
                                           ".tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px" +
                                           " 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;" +
                                           "border-color:black;}"+
                                           " </style></head>\r\n <body><table class=\"tg\">";
        private static string _endHtml = "</table></body></html>";
#endregion

        public void GenerateHTML(int column,int row, List<DataMergeVariables> optionsList)
        {
            ArrayConfig(column,row);
            if (optionsList.Count <= 0)
            {
                DefaultTable(column,row);
            }
            else
            {
                AdvancedTable(column,row,optionsList);
            }
        }

        private void ArrayConfig(int column, int row)
        {
            _htmlCode = new string[column, row];
            for (int i = 0; i < row; i++)
            {
                for (int j=0;j<column;j++)
                {
                    _htmlCode[j,i] = "";
                }
            }
        }

        private void DefaultTable(int c, int r)
        {
            _document = _startHtml;
            for (int i = 0; i < r; i++)
            {
                _document += _startRow;
                for (int j = 0; j < c; j++)
                {
                    _document += _defaultCell;
                }
                _document += _endRow;
            }
            _document += _endHtml;
        }

        private void AdvancedTable(int c, int r, List<DataMergeVariables> optionList)
        {
            OptionInput(optionList);
            _document = _startHtml;
            for (int i = 0; i < r; i++)
            {
                _document += _startRow;
                for (int j = 0; j < c; j++)
                {
                    if (_htmlCode[j, i] == "")
                    {
                        _document += _defaultCell;
                    }
                    else
                    {
                        _document += _htmlCode[j, i];
                    }
                }
                _document += _endRow;
            }

            _document += _endHtml;
        }

        private void OptionInput(List<DataMergeVariables> optionList)
        {
            foreach (DataMergeVariables option in optionList)
            {
                if (bCheckAvailablilityCells(option.Column, option.Row, option.ColumnSpan, option.RowSpan))
                {
                    for (int i = option.Row; i < option.Row + option.RowSpan; i++)
                    {
                        for (int j = option.Column; j < option.Column + option.ColumnSpan; j++)
                        {
                                _htmlCode[j, i] = " ";
                        }
                    }
                    _htmlCode[option.Column, option.Row] = "<td colspan=\"" + option.ColumnSpan.ToString() +
                                                           "\" rowspan=\"" + option.RowSpan.ToString() + "\"></td>";
                }
            }
        }

        private bool bCheckAvailablilityCells(int c, int r, int cspan, int rspan)
        {
            for (int i = r; i < r + rspan; i++)
            {
                for (int j = c; j < c + cspan; j++)
                {
                    if (_htmlCode[j, i] != "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void SaveToFile()
        {
            try
            {
                _lastPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                    + @"\" + "TableHTML_" + DateTime.Now.ToString("yy-MM-dd--hh-mm_ss"));
                _lastPath = Path.ChangeExtension(_lastPath, ".html");

                using (StreamWriter sr = File.CreateText(_lastPath))
                {
                    sr.Write(_document);
                }

                OpenFile(_lastPath);
            }
            catch (Exception e)
            {
            }
        }

        private void OpenFile(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception e)
            {

            }
        }
    }
}
