using OpenCvSharp.ImgHash;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace BusinessLogicLayer.Services
{
    public class PdfService
    {
        public void PrintToPdf(int columnCount, int rowCount, List<string> listToPdf, List<string> headerText, bool rotate = false)
        {
            if (rowCount > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Results.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        } catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Nije moguće napraviti ispis!");
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable ptable = new PdfPTable(columnCount);
                            ptable.DefaultCell.Padding = 2;
                            ptable.WidthPercentage = 100;
                            ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (string header in headerText)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(header));
                                ptable.AddCell(pCell);
                            }
                            foreach (string items in listToPdf)
                            {
                                ptable.AddCell(items);
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document;
                                if (rotate)
                                {
                                    document = new Document(PageSize.A4.Rotate(), 8f, 16f, 16f, 8f);
                                } else
                                {
                                    document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                }
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(ptable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Uspiješan ispis!");
                        } catch (Exception)
                        {
                            MessageBox.Show("Nije moguće napraviti ispis!");
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Nema podataka za ispis!");
            }
        }
    }
}
