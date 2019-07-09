using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabalhoRuidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image;
        int[,] matrizRotulos;
        int corObjeto, corSecundaria = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblThreshold.Text = trackBarThreshold.Value.ToString();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgOriginal = new OpenFileDialog();
            imgOriginal.Filter = "JPEG|*.JPG|PNG|*.PNG|GIF|*.GIF|BMP|*.BMP|All files (*.*)|*.*";
            if (imgOriginal.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(imgOriginal.FileName);
                image = Escalacinza(image);
                pictureBoxOriginal.Image = image;
                lblLargura.Text = "Largura: " + image.Width.ToString();
                lblAltura.Text = "Altura: " + image.Height.ToString();


                //Habilitando botão "Preto e Branco"
                btnPeB.Enabled = true;
                //Desabilitando os botões "Mediana" e "Rotulação"
                //Limpando o PictureBox
                btnMediana.Enabled = false;
                btnRotulacao.Enabled = false;
                pictureBoxResultado.Image = null;
                labelresultado.Text = "Quantidade:";
            }
        }

        private Bitmap Escalacinza(Bitmap img)
        {
            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = img.Width;
            int Altura = img.Height;
            int cinza;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = img.GetPixel(x, y).R;
                    todospixelsG = img.GetPixel(x, y).G;
                    todospixelsB = img.GetPixel(x, y).B;
                    cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            return NovaImagem;
        }

        private Bitmap Pretoebranco(Bitmap img)
        {
            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = img.Width;
            int Altura = img.Height;
            int cinza;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = img.GetPixel(x, y).R;
                    todospixelsG = img.GetPixel(x, y).G;
                    todospixelsB = img.GetPixel(x, y).B;
                    cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                    if (cinza > 150)
                    {
                        NovaImagem.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                    }
                    else
                    {
                        NovaImagem.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                    }
                }
            }
            return NovaImagem;
        }

        private void btnPeB_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBoxOriginal.Image);
            img = Pretoebranco(img);
            pictureBoxResultado.Image = img;

            //Habilitando os botões "Mediana" e "Rotulação" 
            btnMediana.Enabled = true;
            btnRotulacao.Enabled = true;
        }

        private void btnMediana_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBoxResultado.Image);
            int Largura = img.Width;
            int Altura = img.Height;
            Bitmap novaimagem = new Bitmap(Largura, Altura);
            for (int i = 1; i < Largura - 1; i++)
            {
                for (int j = 1; j < Altura - 1; j++)
                {
                    int[] vetor = new int[9];
                    vetor[0] = img.GetPixel(i - 1,j - 1).R;
                    vetor[1] = img.GetPixel(i - 1,j).R;
                    vetor[2] = img.GetPixel(i - 1,j + 1).R;
                    vetor[3] = img.GetPixel(i,j - 1).R;
                    vetor[4] = img.GetPixel(i,j).R;
                    vetor[5] = img.GetPixel(i,j + 1).R;
                    vetor[6] = img.GetPixel(i + 1,j - 1).R;
                    vetor[7] = img.GetPixel(i + 1,j).R;
                    vetor[8] = img.GetPixel(i + 1,j + 1).R;

                    Array.Sort(vetor);
                    int mediana = vetor[4];
                    novaimagem.SetPixel(i, j, Color.FromArgb(255, mediana, mediana, mediana));
                }
            }
            pictureBoxResultado.Image = novaimagem;
        }

        private void rotular(Bitmap img)
        {
            int rotulo = 0;
            matrizRotulos = new int[img.Width, img.Height];

            for (int i = 1; i < img.Width; i++)
            {
                for (int j = 1; j < img.Height; j++)
                {
                    if (img.GetPixel(i,j).R == corObjeto)
                    {
                        if (((img.GetPixel(i-1,j).R) == corSecundaria) && ((img.GetPixel(i,j-1).R) == corSecundaria))
                        {
                            rotulo = rotulo + 1;
                            matrizRotulos[i, j] = rotulo;
                        }
                        else if ((img.GetPixel(i - 1, j).R == corObjeto) && (img.GetPixel(i, j - 1).R == corObjeto))
                        {
                            if ((matrizRotulos[i - 1, j]) == (matrizRotulos[i, j - 1]))
                            {
                                matrizRotulos[i, j] = matrizRotulos[i - 1, j];
                            }
                            else
                            {
                                if ((matrizRotulos[i - 1, j]) > (matrizRotulos[i, j - 1]))
                                {
                                    substituirRotulo(matrizRotulos[i - 1, j], matrizRotulos[i, j - 1]);
                                    matrizRotulos[i, j] = matrizRotulos[i, j - 1];
                                }
                                else
                                {
                                    substituirRotulo(matrizRotulos[i, j - 1], matrizRotulos[i - 1, j]);
                                    matrizRotulos[i, j] = matrizRotulos[i - 1, j];
                                }
                                //rotulo = rotulo - 1;
                            }
                            //Se os rótulos forem diferentes
                            //Se os rótulos forem iguais
                            //matrizRotulos[i, j] = matrizRotulos[i-1,j];
                        }
                        else
                        {
                            if (img.GetPixel((i - 1),j).R == corObjeto)
                            {
                                matrizRotulos[i, j] = matrizRotulos[i - 1, j];
                            }
                            else
                            {
                                matrizRotulos[i, j] = matrizRotulos[i, j - 1];
                            }
                            
                        }
                    }
                }
            }
        }

        private void substituirRotulo(int antigo, int novo)
        {
            for (int i = 0; i < matrizRotulos.GetLength(0); i++)
            {
                for (int j = 0; j < matrizRotulos.GetLength(1); j++)
                {
                    if (matrizRotulos[i, j] == antigo)
                    {
                        matrizRotulos[i, j] = novo;
                    }
                }
            }
        }

        private int contarRotulo(int r)
        {
            int q = 0;
            for (int i = 0; i < matrizRotulos.GetLength(0); i++)
            {
                for (int j = 0; j < matrizRotulos.GetLength(1); j++)
                {
                    if (matrizRotulos[i, j] == r)
                        q = q + 1;
                }
            }
            return q;
        }

        private int numeroElementos()
        {
            int n = 0;
            List<int> Elementos = new List<int>();

            //Detecta todos os rótulos existentes
            for (int i = 0; i < matrizRotulos.GetLength(0); i++)
            {
                for (int j = 0; j < matrizRotulos.GetLength(1); j++)
                {
                    if ((matrizRotulos[i, j] > 0) && (!Elementos.Contains(matrizRotulos[i, j])))
                    {
                        Elementos.Add(matrizRotulos[i, j]);
                    }
                }
            }


            List<Etiqueta> Rotulos = new List<Etiqueta>();
            Elementos.Sort();
            Etiqueta e;
            //Conta quantas vezes cada rótulo repete
            foreach(int el in Elementos)
            {
                e = new Etiqueta();
                e.NumEtiqueta = el;
                e.Quantidade = contarRotulo(el);
                Rotulos.Add(e);
            }


            //Conta o número de elementos válidos
            foreach(Etiqueta r in Rotulos)
            {
                if (r.Quantidade > trackBarThreshold.Value)
                    n = n + 1;
                
            }
            return n;
        }

        private void trackBarThreshold_Scroll(object sender, EventArgs e)
        {
            lblThreshold.Text = trackBarThreshold.Value.ToString();
        }

        private void btnRotulacao_Click(object sender, EventArgs e)
        {
            if (radioWhite.Checked)
            {
                corObjeto = 255;
                corSecundaria = 0;
            }
            else
            {
                corObjeto = 0;
                corSecundaria = 255;
            }
                
            Bitmap img = new Bitmap(pictureBoxResultado.Image);
            rotular(img);
            int qtdElementos = numeroElementos();
            labelresultado.Text = "Quantidade: " + qtdElementos.ToString();
        }
    }
}
