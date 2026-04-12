using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppReportesElectronicos.Reporteria
{
    public partial class FrmReporteCliente: Form
    {
        public FrmReporteCliente()
        {
            InitializeComponent();
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            IBLLCliente bllCliente = new IBLLCliente();
            string filtro = "";

            try
            {


                //var lista = bllCliente.GetAllCliente();








                //// Logo
                //Bitmap logoBitmap = new Bitmap(Properties.Resources.ChatGPT_Image_14_mar_2026__02_47_00_p_m_, 200, 200);
                //byte[] logoBytes;
                //MemoryStream memory = new MemoryStream();
                //logoBitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                //logoBytes = memory.ToArray();



                //// Obligatorio la licencia Community
                //QuestPDF.Settings.License = LicenseType.Community;

                //var pdfFileBytes = Document.Create(document =>
                //{
                //    document.Page(page =>
                //    {

                //        page.Size(PageSizes.Letter);
                //        page.Margin(2, QuestPDF.Infrastructure.Unit.Centimetre);
                //        page.PageColor(Colors.White);
                //        page.Margin(30);

                //        // Encabezado de página
                //        page.Header().Row(row =>
                //        {
                //            row.RelativeItem().Column(col =>
                //            {
                //                col.Item().AlignLeft().Text("Electronics S.A.").Bold().FontSize(50).Bold().FontColor("#2058b3");
                //                row.ConstantItem(100).AlignRight().Height(100).Image(logoBytes);
                //                col.Item().AlignLeft().Text($"Fecha: {DateTime.Now} ").FontSize(9);
                //                col.Item().LineHorizontal(1f);

                //            });

                //        });

                //        // Página
                //        page.Content().PaddingVertical(10).Column(col1 =>
                //        {
                //            // Titulo del reporte
                //            col1.Item().AlignCenter().Text("Reporte de Clientes").FontSize(14).Bold();
                //            col1.Item().Text("");
                //            col1.Item().LineHorizontal(0.5f);

                //            col1.Item().Table(tabla =>
                //            {
                //                tabla.ColumnsDefinition(columns =>
                //                {
                //                    // Define cuantas columnas 
                //                    columns.RelativeColumn(2);
                //                    columns.RelativeColumn(2);
                //                    columns.RelativeColumn(2);
                //                    columns.RelativeColumn(2);
                //                });

                //                // Define encabezado
                //                tabla.Header(header =>
                //                {
                //                    header.Cell().Background("#4666FF")
                //                    .Padding(2).AlignCenter().Text("Identificación").FontColor("#fff");

                //                    header.Cell().Background("#4666FF")
                //                    .Padding(2).AlignCenter().Text("Nombre").FontColor("#fff");

                //                    header.Cell().Background("#4666FF")
                //                   .Padding(2).AlignCenter().Text("Sexo").FontColor("#fff");

                //                    header.Cell().Background("#4666FF")
                //                   .Padding(2).AlignCenter().Text("F. Nacimiento").FontColor("#fff");
                //                });


                //                // recorrer la lista
                //                foreach (var item in lista)
                //                {

                //                    // Column 1 
                //                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                //                    .Padding(2).Text(item.IdCliente.ToString()).FontSize(10);

                //                    // Column 2
                //                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                //                    .Padding(2).AlignLeft().Text(item.ToString());

                //                    // Column 3
                //                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                //                    .Padding(2).AlignCenter().Text(item.Sexo == 1 ? "M" : "F");

                //                    // Column 4
                //                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                //                    .Padding(2).AlignCenter().Text(item.FechaNacimiento.ToString("dd/MM/yyyy"));

                //                }
                //            });


                //            col1.Item().AlignLeft().Text("Cantidad de Clientes " + lista.Count().ToString()).FontSize(12).Bold();
                //        });

                //        // Pie de página
                //        page.Footer()
                //        .AlignRight()
                //        .Text(txt =>
                //        {
                //            txt.Span("Página ").FontSize(10);
                //            txt.CurrentPageNumber().FontSize(10);
                //            txt.Span(" de ").FontSize(10);
                //            txt.TotalPages().FontSize(10);
                //        });
                //    });
                //}).GeneratePdf();

                //// Salvarlo en disco
                //string file = @"c:\temp\rptCliente.pdf";
                //File.WriteAllBytes(file, pdfFileBytes);

                //    Process.Start(file);


                //    // Enviarlo por correo
                //    MessageBox.Show("Debe programar la rutina de envío de correo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
