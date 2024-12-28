using iText.Layout;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;

namespace ContasAPagar
{
    class Prints
    {
        public void ExportarDataGridViewParaPDF(DataGridView dataGridView, string caminhoPDF, string ValorTotal)
        {
            try
            {
                // Cria o documento PDF
                Document documento = new Document(PageSize.A4.Rotate(), 20, 20, 20, 20); // Página horizontal
                PdfWriter.GetInstance(documento, new FileStream(caminhoPDF, FileMode.Create));
                documento.Open();

                // Adiciona o título
                Paragraph titulo = new Paragraph("Relatório de Contas a Pagar", new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD));
                titulo.Alignment = Element.ALIGN_CENTER;
                documento.Add(titulo);

                // Adiciona a data
                documento.Add(new Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n\n"));

                // Conta o número de colunas visíveis no DataGridView
                int colunasVisiveis = 0;
                foreach (DataGridViewColumn coluna in dataGridView.Columns)
                {
                    if (coluna.Visible) colunasVisiveis++;
                }

                // Cria a tabela no PDF com base no número de colunas visíveis
                PdfPTable tabela = new PdfPTable(colunasVisiveis);
                tabela.WidthPercentage = 100; // Largura total da página
                tabela.SetWidths(CalcularLarguraColunas(dataGridView)); // Larguras proporcionais das colunas

                // Estilo para os cabeçalhos
                Font fonteCabecalho = new Font(Font.FontFamily.HELVETICA, 6, Font.BOLD, BaseColor.WHITE);

                // Adiciona os cabeçalhos das colunas visíveis
                foreach (DataGridViewColumn coluna in dataGridView.Columns)
                {
                    if (coluna.Visible)
                    {
                        PdfPCell celulaCabecalho = new PdfPCell(new Phrase(coluna.HeaderText, fonteCabecalho))
                        {
                            BackgroundColor = BaseColor.DARK_GRAY,
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            PaddingTop = 5,
                            PaddingBottom = 5
                        };
                        tabela.AddCell(celulaCabecalho);
                    }
                }

                // Adiciona os dados das linhas visíveis
                Font fonteDados = new Font(Font.FontFamily.HELVETICA, 6);
                foreach (DataGridViewRow linha in dataGridView.Rows)
                {
                    if (!linha.IsNewRow)
                    {
                        foreach (DataGridViewCell celula in linha.Cells)
                        {
                            if (celula.OwningColumn.Visible)
                            {
                                string texto = celula.Value?.ToString() ?? "";

                                // Formatação para tipos específicos
                                if (celula.Value is DateTime data)
                                    texto = data.ToString("dd/MM/yyyy");
                                else if (decimal.TryParse(celula.Value?.ToString(), out decimal valor))
                                    texto = valor.ToString("C2");

                                PdfPCell celulaDados = new PdfPCell(new Phrase(texto, fonteDados))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    Padding = 5
                                };
                                tabela.AddCell(celulaDados);
                            }
                        }
                    }
                }

                // Adiciona a tabela ao documento
                documento.Add(tabela);

                // Adiciona o rodapé com o valor total
                Paragraph rodape = new Paragraph($"Total: {ValorTotal}", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))
                {
                    Alignment = Element.ALIGN_RIGHT,
                    SpacingBefore = 10 // Espaçamento antes do rodapé
                };
                documento.Add(rodape);

                // Fecha o documento
                documento.Close();

                // Exibe mensagem de sucesso
                MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para calcular larguras proporcionais das colunas
        private float[] CalcularLarguraColunas(DataGridView dataGridView)
        {
            int colunasVisiveis = 0;
            foreach (DataGridViewColumn coluna in dataGridView.Columns)
            {
                if (coluna.Visible) colunasVisiveis++;
            }

            float[] larguras = new float[colunasVisiveis];
            int index = 0;

            foreach (DataGridViewColumn coluna in dataGridView.Columns)
            {
                if (coluna.Visible)
                {
                    larguras[index] = (float)coluna.Width / dataGridView.Width;
                    index++;
                }
            }
            return larguras;
        }

    }
}