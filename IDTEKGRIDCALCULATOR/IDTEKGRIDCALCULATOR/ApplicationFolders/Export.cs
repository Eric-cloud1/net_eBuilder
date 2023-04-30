using System;
using System.Data;
using System.Xml;
using System.Web;
using System.Text;
using System.IO;
using System.Xml.Xsl;
using System.Security.Policy;
using System.Threading;




namespace IDIGITALTEKGRID
{

    public class Export
    {

        public Export()
        {
            this.appType = "Web";
            this.response = HttpContext.Current.Response;
        }

        public Export(string ApplicationType)
        {
            this.appType = ApplicationType;
            if ((this.appType != "Web") && (this.appType != "Win"))
            {
                throw new Exception("Provide valid application format (Web/Win)");
            }
            if (this.appType == "Web")
            {
                this.response = HttpContext.Current.Response;
            }
        }

        private void CreateStylesheet(XmlTextWriter writer, string[] sHeaders, string[] sFileds, Export.ExportFormat FormatType)
        {
            try
            {
                string text1 = "http://www.w3.org/1999/XSL/Transform";
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("xsl", "stylesheet", text1);
                writer.WriteAttributeString("version", "1.0");
                writer.WriteStartElement("xsl:output");
                writer.WriteAttributeString("method", "text");
                writer.WriteAttributeString("version", "4.0");
                writer.WriteEndElement();
                writer.WriteStartElement("xsl:template");
                writer.WriteAttributeString("match", "/");
                for (int num1 = 0; num1 < sHeaders.Length; num1++)
                {
                    writer.WriteString("\"");
                    writer.WriteStartElement("xsl:value-of");
                    writer.WriteAttributeString("select", "'" + sHeaders[num1] + "'");
                    writer.WriteEndElement();
                    writer.WriteString("\"");
                    if (num1 != (sFileds.Length - 1))
                    {
                        writer.WriteString((FormatType == Export.ExportFormat.CSV) ? "," : "\t");
                    }
                }
                writer.WriteStartElement("xsl:for-each");
                writer.WriteAttributeString("select", "Export/Values");
                writer.WriteString("\r\n");
                for (int num2 = 0; num2 < sFileds.Length; num2++)
                {
                    writer.WriteString("\"");
                    writer.WriteStartElement("xsl:value-of");
                    writer.WriteAttributeString("select", sFileds[num2]);
                    writer.WriteEndElement();
                    writer.WriteString("\"");
                    if (num2 != (sFileds.Length - 1))
                    {
                        writer.WriteString((FormatType == Export.ExportFormat.CSV) ? "," : "\t");
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            catch (Exception exception1)
            {
                throw exception1;
            }
        }
        private void Export_with_XSLT_Web(DataSet dsExport, string[] sHeaders, string[] sFileds, Export.ExportFormat FormatType, string FileName)
        {
            try
            {
                this.response.Clear();
                this.response.Buffer = true;
                if (FormatType == Export.ExportFormat.CSV)
                {
                    this.response.ContentType = "text/csv";
                    this.response.AppendHeader("content-disposition", "attachment; filename=" + FileName);
                }
                else
                {
                    this.response.ContentType = "application/vnd.ms-excel";
                    this.response.AppendHeader("content-disposition", "attachment; filename=" + FileName);
                }
                MemoryStream stream1 = new MemoryStream();
                XmlTextWriter writer1 = new XmlTextWriter(stream1, Encoding.UTF8);
                this.CreateStylesheet(writer1, sHeaders, sFileds, FormatType);
                writer1.Flush();
                stream1.Seek((long)0, SeekOrigin.Begin);
                XmlDataDocument document1 = new XmlDataDocument(dsExport);
                XslTransform transform1 = new XslTransform();
                transform1.Load(new XmlTextReader(stream1), (XmlResolver)null, (Evidence)null);
                StringWriter writer2 = new StringWriter();
                transform1.Transform(document1, (XsltArgumentList)null, writer2, (XmlResolver)null);
                this.response.Write(writer2.ToString());
                writer2.Close();
                writer1.Close();
                stream1.Close();
                this.response.End();
            }
            catch (ThreadAbortException exception1)
            {
                string text1 = exception1.Message;
                return;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
        }
        private void Export_with_XSLT_Windows(DataSet dsExport, string[] sHeaders, string[] sFileds, Export.ExportFormat FormatType, string FileName)
        {
            try
            {
                MemoryStream stream1 = new MemoryStream();
                XmlTextWriter writer1 = new XmlTextWriter(stream1, Encoding.UTF8);
                this.CreateStylesheet(writer1, sHeaders, sFileds, FormatType);
                writer1.Flush();
                stream1.Seek((long)0, SeekOrigin.Begin);
                XmlDataDocument document1 = new XmlDataDocument(dsExport);
                XslTransform transform1 = new XslTransform();
                transform1.Load(new XmlTextReader(stream1), (XmlResolver)null, (Evidence)null);
                StringWriter writer2 = new StringWriter();
                transform1.Transform(document1, (XsltArgumentList)null, writer2, (XmlResolver)null);
                StreamWriter writer3 = new StreamWriter(FileName);
                writer3.WriteLine(writer2.ToString());
                writer3.Close();
                writer2.Close();
                writer1.Close();
                stream1.Close();
            }
            catch (Exception exception1)
            {
                throw exception1;
            }
        }


        public void ExportDetails(DataTable DetailsTable, Export.ExportFormat FormatType, string FileName)
        {
            try
            {
                if (DetailsTable.Rows.Count == 0)
                {
                    throw new Exception("There are no details to export.");
                }
                DataSet set1 = new DataSet("Export");
                DataTable table1 = DetailsTable.Copy();
                table1.TableName = "Values";
                set1.Tables.Add(table1);
                string[] textArray1 = new string[table1.Columns.Count];
                string[] textArray2 = new string[table1.Columns.Count];
                for (int num1 = 0; num1 < table1.Columns.Count; num1++)
                {
                    textArray1[num1] = table1.Columns[num1].ColumnName;
                    textArray2[num1] = table1.Columns[num1].ColumnName;
                }
                if (this.appType == "Web")
                {
                    this.Export_with_XSLT_Web(set1, textArray1, textArray2, FormatType, FileName);
                }
                else if (this.appType == "Win")
                {
                    this.Export_with_XSLT_Windows(set1, textArray1, textArray2, FormatType, FileName);
                }
            }
            catch (Exception exception1)
            {
                throw exception1;
            }
        }
        public void ExportDetails(DataTable DetailsTable, int[] ColumnList, Export.ExportFormat FormatType, string FileName)
        {
            try
            {
                if (DetailsTable.Rows.Count == 0)
                {
                    throw new Exception("There are no details to export");
                }
                DataSet set1 = new DataSet("Export");
                DataTable table1 = DetailsTable.Copy();
                table1.TableName = "Values";
                set1.Tables.Add(table1);
                if (ColumnList.Length > table1.Columns.Count)
                {
                    throw new Exception("ExportColumn List should not exceed Total Columns");
                }
                string[] textArray1 = new string[ColumnList.Length];
                string[] textArray2 = new string[ColumnList.Length];
                for (int num1 = 0; num1 < ColumnList.Length; num1++)
                {
                    if ((ColumnList[num1] < 0) || (ColumnList[num1] >= table1.Columns.Count))
                    {
                        throw new Exception("ExportColumn Number should not exceed Total Columns Range");
                    }
                    textArray1[num1] = table1.Columns[ColumnList[num1]].ColumnName;
                    textArray2[num1] = table1.Columns[ColumnList[num1]].ColumnName;
                }
                if (this.appType == "Web")
                {
                    this.Export_with_XSLT_Web(set1, textArray1, textArray2, FormatType, FileName);
                }
                else if (this.appType == "Win")
                {
                    this.Export_with_XSLT_Windows(set1, textArray1, textArray2, FormatType, FileName);
                }
            }
            catch (Exception exception1)
            {
                throw exception1;
            }
        }
        public void ExportDetails(DataTable DetailsTable, int[] ColumnList, string[] Headers, Export.ExportFormat FormatType, string FileName)
        {
            try
            {
                if (DetailsTable.Rows.Count == 0)
                {
                    throw new Exception("There are no details to export");
                }
                DataSet set1 = new DataSet("Export");
                DataTable table1 = DetailsTable.Copy();
                table1.TableName = "Values";
                set1.Tables.Add(table1);
                if (ColumnList.Length != Headers.Length)
                {
                    throw new Exception("ExportColumn List and Headers List should be of same length");
                }
                if ((ColumnList.Length > table1.Columns.Count) || (Headers.Length > table1.Columns.Count))
                {
                    throw new Exception("ExportColumn List should not exceed Total Columns");
                }
                string[] textArray1 = new string[ColumnList.Length];
                for (int num1 = 0; num1 < ColumnList.Length; num1++)
                {
                    if ((ColumnList[num1] < 0) || (ColumnList[num1] >= table1.Columns.Count))
                    {
                        throw new Exception("ExportColumn Number should not exceed Total Columns Range");
                    }
                    textArray1[num1] = table1.Columns[ColumnList[num1]].ColumnName;
                }
                if (this.appType == "Web")
                {
                    this.Export_with_XSLT_Web(set1, Headers, textArray1, FormatType, FileName);
                }
                else if (this.appType == "Win")
                {
                    this.Export_with_XSLT_Windows(set1, Headers, textArray1, FormatType, FileName);
                }
            }
            catch (Exception exception1)
            {
                throw exception1;
            }
        }

        private string appType;
        private HttpResponse response;

        public enum ExportFormat
        {
            CSV = 1,
            Excel = 2
        }
    }
}



