using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hid_Fil_Desktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " " + Application.ProductVersion;
        }


        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void get_img_Click(object sender, EventArgs e) //OBTIENE LA IMAGEN
        {
            var boton = sender as Button;
            openFileDialog1.FileName = null;
            openFileDialog1.Filter = "|*png";
            openFileDialog1.ShowDialog();
            
            try
            {
                switch (boton.Name)
                {
                    case "img_button_ensamblar":
                    img_assambly = new Bitmap(openFileDialog1.FileName); //OBTIENE LA IMAGEN
                    img_button_ensamblar.BackgroundImage = img_assambly; //MUESTRA LA IMAGEN EN EL BOTON
                    img_textBox_ensamblar.Text = openFileDialog1.FileName.ToString(); //MUESTRA LA RUTA DEL ARCHIVO
                    break;

                case "img_button_desamblar":
                    img_desamblar = new Bitmap(openFileDialog1.FileName); //OBTIENE LA IMAGEN
                    img_button_desamblar.BackgroundImage = img_desamblar; //MUESTRA LA IMAGEN EN EL BOTON
                    img_textBox_desamblar.Text = openFileDialog1.FileName.ToString(); //MUESTRA LA RUTA DEL ARCHIVO
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void get_file_Click(object sender, EventArgs e) //OBTIENE LOS BYTES DEL ARCHIVO POR INCRUSTAR EN LA IMAGEN
        {
            try
            {
                var boton = sender as Button;
                openFileDialog1.FileName = null;
                openFileDialog1.Filter = null;
                openFileDialog1.ShowDialog();
                
                file_assambly = File.ReadAllBytes(openFileDialog1.FileName); //OBTIENES LOS BYTES DEL ARCHIVO
                EXT = Path.GetExtension(openFileDialog1.FileName); //KEY0
                file_button_ensamblar.BackgroundImage = Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap(); //MUESTRA EL ICONO DEL ARCHIVO
                file_textBox_ensamblar.Text = openFileDialog1.FileName.ToString(); //MUESTRA LA RUTA DEL ARCHIVO
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        private void get_key_Click(object sender, EventArgs e) //OBTIENE LA CLAVE PARA OBTENER EL ARCHIVO INCRUSTADO
        {
            try
            {
                openFileDialog1.FileName = null;
                openFileDialog1.Filter = "|*hdfl";
                openFileDialog1.ShowDialog();
                Byte[] a = Array.ConvertAll(File.ReadAllText(openFileDialog1.FileName).Split(' '), Byte.Parse); //RECOGE LOS BYTES DEL ARCHIVO CLAVE
                KEY = Encoding.ASCII.GetString(a).Split(':'); //DESCODIFICA EL ASCI CON LOS BYTES PROPORCIONADOS Y LOS DIVIDE EN SUS TRES SECCIONES  "KEY0: KEY1: KEY2"
                clave_button_desamblar.BackgroundImage = Properties.Resources.ico_keys; //ICONO
                clave_textBox_desamblar.Text = openFileDialog1.FileName; //MUESTRA RUTA DEL ARCHIVO
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private Bitmap img_assambly;
        private Byte[] file_assambly;
        private string EXT;
        private void Process_button_Assambly(object sender, EventArgs e) //COLOCA EL ARCHIVO DENTRO DE LA IMAGEN
         {
             
            if (img_assambly == null && file_assambly == null) //SI ESTAN VACIOS ENTONCES SALTARA TODO EL PROCESO
            {
                MessageBox.Show(this, "Campos vacios. Por favor introduzca los archivos correspondientes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto fin1;
            }


            #region OBTIENE LA CADENA COMPLETA DE LOS BITS DEL ARCHIVO POR OCULTAR
            string filebits = null; //CADENA CON TODOS LOS BITS DEL ARRAYBYTE
            string key = EXT + ":"; //KEY0

            foreach (var item in file_assambly)
            {
                filebits += Convert.ToString(item, 2); //OBTIENE TODOS LOS BITS
                key += Convert.ToString(item, 2).Length + ","; //KEY1
            }
            #endregion


            #region DETECTA SI LA IMAGEN ES MAS PEQUEÑA QUE EL ARCHIVO Y FINALIZA TODO EL PROCESO
            if (3 * (img_assambly.Height * img_assambly.Width) < filebits.Length)
            {
                MessageBox.Show(this, "El tamaño del archivo es demasiado grande para la imagen. ELija una imagen con mayor resolucion para continuar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto fin1;
            }
            #endregion
            

            key = key.Remove(key.Length - 1); //QUITA EL "," FINAL
            key += ":" + filebits.Length.ToString(); //KEY2
            key = string.Join(" ", Encoding.ASCII.GetBytes(key)); //CONVIERTE EL TEXTO A ARRAYBYTES CODIFICADO A ASCII Y LUEGO LO CONVIERTE EN TEXTO


            #region REALIZA EL CAMBIO DE LOS BITS EN LA IMAGEN
            int idx = 0; //INDEX PARA ITERAR
            for (int y = 0; y < img_assambly.Height; y++) //COORDENADA Y
            {
                for (int x = 0; x < img_assambly.Width; x++) //COORDENADA X
                {
                    string[] colores = { "R", "G", "B" };
                    colores[0] = Convert.ToString( img_assambly.GetPixel(x, y).R, 2 );
                    colores[1] = Convert.ToString( img_assambly.GetPixel(x, y).G, 2 );
                    colores[2] = Convert.ToString( img_assambly.GetPixel(x, y).B, 2 );


                    for (int i = 0; i < 3; i++) //RECORRE A TRAVES DEL RGB
                    {

                        if (idx == filebits.Length) //CUANDO LLEGUE A LO ULTIMO DE LA CADENA DE BITS FINALIZA TODO
                        {
                            goto fin2;
                        }

                        //REEMPLAZA EL ULTIMO DIGITO DE LA CADENA DE BITS
                        colores[i] = colores[i].Remove(colores[i].Length - 1) + filebits[idx];
                        idx++;
                    
                    }

                    //CAMBIA EL COLOR DE LA IMAGEN EN X,Y PIXEL
                    img_assambly.SetPixel(x, y,
                      Color.FromArgb(
                        Convert.ToByte(colores[0], 2),
                        Convert.ToByte(colores[1], 2),
                        Convert.ToByte(colores[2], 2)
                        ));
                }
            }
            #endregion


        fin2:
            
            folderBrowserDialog1.ShowDialog();
            string nombre_archivo = "HIDFIL_" + DateTime.Now.Millisecond.ToString() + (DateTime.Now.Ticks / 2).ToString(); //NOMBRE DEL ARCHIVO
            img_assambly.Save( Path.Combine(folderBrowserDialog1.SelectedPath, nombre_archivo + ".png"), ImageFormat.Png ); //GUARDA LA IMAGEN
            File.AppendAllText(Path.Combine(folderBrowserDialog1.SelectedPath, nombre_archivo + ".hdfl"), key); //GUARDA LA CLAVE DEL ARCHIVO
            MessageBox.Show(this, "Operacion realizada con exito. Por favor, guarde el archivo '.hdfl' generado. Es para recuperar el archivo incrustado en la imagen", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        fin1:
            MessageBox.Show(this, "Operacion terminada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }


        private Bitmap img_desamblar;
        private string[] KEY;
        private void process_button_desamblar_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(img_desamblar); //OBTIENE LA IMAGEN
            List<Byte> file_byte = new List<byte>(); //LOS BYTES RECUPERADOS DEL ARCHIVO
            string[] keybits = KEY[1].Split(','); //LONGITUD DE LOS BITS

            string get_bits = null; //OBTIENE CADENA DE LOS BITS CORRESPONDIENTES
            int idx = 0;

            #region OBTIENE LA CADENA DE BITS
            for (int y = 0; y < img.Height; y++) //COORDENADAS Y DE LA IMAGEN
            {
                for (int x = 0; x < img.Width; x++) //COORDENDAS X DE LA IMAGEN
                {
                    string[] colores = { Convert.ToString(img.GetPixel(x, y).R, 2), Convert.ToString(img.GetPixel(x, y).G, 2), Convert.ToString(img.GetPixel(x, y).B, 2) };


                    for (int i = 0; i < 3; i++)
                    {
                        get_bits += colores[i][colores[i].Length - 1]; //OBTIENE LA CADENA DE BITS. DEL ULTIMO DIGITO
                        idx++;

                        if (idx.ToString() == KEY[2]) //FINALIZA LA BUSQUEDA DE LOS BITS AL LLEGAR AL ULTIMO DIGITO
                        {
                            goto fin;
                        }
                    }
                }
            }
            #endregion
            
            
            #region CONVIERTE LA CADENA DE DIGITOS EN ARRAY DE BYTES
            fin:
            idx = 0;
            foreach (var item in keybits) //RECORRE EL ARRAY QUE CONTIENE LA LONGITUD DE LA CADENA DE BITS
            {
                string bity = null; //OBTIENE LA CADENA DE BITS
                
                for (int i = 0; i < Convert.ToInt64(item); i++) //RECORRE LOS INDICES DEL STRING CON LOS BITS
                {
                    bity += get_bits[idx]; //OBTIENE EL DIGITO
                    idx++;
                }
                
                file_byte.Add(Convert.ToByte(bity, 2)); //CONVIERTE LOS BIT A BYTES Y LOS ALMACENA
            }
            #endregion


            folderBrowserDialog1.ShowDialog();
            string nombre_archivo = "HIDFIL_FILE_" + DateTime.Now.Millisecond.ToString() + (DateTime.Now.Ticks / 2).ToString(); //NOMBRE DEL ARCHIVO
            File.WriteAllBytes(Path.Combine(folderBrowserDialog1.SelectedPath, nombre_archivo + KEY[0]), file_byte.ToArray()); //OBTIENE Y GUARDA EL ARCHIVO GENERADO
            MessageBox.Show(this, "Operacion terminada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
