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
        public void ExportarDataGridViewParaPDF(DataGridView dataGridView, string caminhoPDF)
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
                    if (coluna.Visible)
                    {
                        colunasVisiveis++;
                    }
                }

                // Cria a tabela no PDF com base no número de colunas visíveis
                PdfPTable tabela = new PdfPTable(colunasVisiveis);
                tabela.WidthPercentage = 100; // Largura total da página
                tabela.SetWidths(CalcularLarguraColunas(dataGridView)); // Larguras proporcionais das colunas

                // Estilo para os cabeçalhos
                Font fonteCabecalho = new Font(Font.FontFamily.HELVETICA, 5, Font.BOLD, BaseColor.WHITE);

                // Adiciona os cabeçalhos das colunas visíveis
                foreach (DataGridViewColumn coluna in dataGridView.Columns)
                {
                    if (coluna.Visible)
                    {
                        PdfPCell celulaCabecalho = new PdfPCell(new Phrase(coluna.HeaderText, fonteCabecalho));
                        celulaCabecalho.BackgroundColor = BaseColor.DARK_GRAY; // Cor de fundo
                        celulaCabecalho.HorizontalAlignment = Element.ALIGN_CENTER; // Alinhamento centralizado
                        celulaCabecalho.PaddingTop = 10; // Altura da célula
                        celulaCabecalho.PaddingBottom = 10;
                        celulaCabecalho.PaddingLeft = 15; // Aumenta o padding horizontal
                        celulaCabecalho.PaddingRight = 15;
                        tabela.AddCell(celulaCabecalho);
                    }
                }

                // Adiciona as células com os dados das linhas, somente para as colunas visíveis
                Font fonteDados = new Font(Font.FontFamily.HELVETICA, 5);
                foreach (DataGridViewRow linha in dataGridView.Rows)
                {
                    if (!linha.IsNewRow) // Ignora a última linha em branco
                    {
                        foreach (DataGridViewCell celula in linha.Cells)
                        {
                            if (celula.OwningColumn.Visible) // Verifica se a coluna está visível
                            {
                                string texto = celula.Value?.ToString() ?? ""; // Trata valores nulos

                                // Verifica se o valor da célula é uma data
                                if (celula.Value is DateTime data)
                                {
                                    // Formata a data para mostrar apenas o dia, mês e ano
                                    texto = data.ToString("dd/MM/yyyy");
                                }
                                // Verifica se o valor da célula é um número (valor monetário)
                                else if (celula.Value is decimal valor)
                                {
                                    // Formata o valor como moeda (2 casas decimais)
                                    texto = valor.ToString("C2"); // Formato de moeda, exemplo: R$ 1.234,56
                                }

                                PdfPCell celulaDados = new PdfPCell(new Phrase(texto, fonteDados));
                                celulaDados.HorizontalAlignment = Element.ALIGN_CENTER; // Alinha à esquerda
                                celulaDados.PaddingTop = 5; // Padding superior
                                celulaDados.PaddingBottom = 5; // Padding inferior
                                celulaDados.PaddingLeft = 5; // Padding lateral
                                celulaDados.PaddingRight = 5;
                                tabela.AddCell(celulaDados);
                            }
                        }
                    }
                }

                // Adiciona a tabela ao documento PDF
                documento.Add(tabela);
                documento.Close();

                MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para calcular larguras das colunas visíveis
        private float[] CalcularLarguraColunas(DataGridView dataGridView)
        {
            int colunasVisiveis = 0;
            foreach (DataGridViewColumn coluna in dataGridView.Columns)
            {
                if (coluna.Visible)
                {
                    colunasVisiveis++;
                }
            }

            float[] larguras = new float[colunasVisiveis];
            int index = 0;

            foreach (DataGridViewColumn coluna in dataGridView.Columns)
            {
                if (coluna.Visible)
                {
                    larguras[index] = coluna.Width / 100f; // Ajusta proporcionalmente
                    index++;
                }
            }
            return larguras;
        }

       

    }
}
