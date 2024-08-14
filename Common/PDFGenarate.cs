using iTextSharp.text.pdf;
using iTextSharp.text;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Common
{
    internal class PDFGenarate
    {
        public void pdfConverter(MaterialListView listView, string fileName)
        {
            if (listView.Items.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = fileName
                };

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }

                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(listView.Columns.Count)
                            {
                                DefaultCell = { Padding = 2 },
                                WidthPercentage = 100,
                                HorizontalAlignment = Element.ALIGN_LEFT
                            };

                            // Adding headers
                            foreach (ColumnHeader col in listView.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.Text));
                                pTable.AddCell(pCell);
                            }

                            // Adding data rows
                            foreach (ListViewItem item in listView.Items)
                            {
                                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                                {
                                    pTable.AddCell(subItem.Text);
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();
                                document.Add(pTable);
                                document.Close();

                                fileStream.Close();
                            }

                            MessageBox.Show("Data exported successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No records found", "Info");
            }
        }
    }
}
