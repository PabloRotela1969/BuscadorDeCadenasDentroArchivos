using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BuscarDentroArchivos
{
    public partial class frmBusqueda : Form
    {

        FolderBrowserDialog dialogoCarpetaInicial = new FolderBrowserDialog();
        List<FileInfo > listaArchivos = new List<FileInfo >();
        List<string> listaNombreDirs = new List<string>();

        public frmBusqueda()
        {
            InitializeComponent();
            this.txtTextoABuscar.ReadOnly = true;
        }


        private void btnSeleccioneCarpetaInicial_Click(object sender, EventArgs e)
        {
            
            if (dialogoCarpetaInicial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                    this.txtTextoABuscar.ReadOnly = false;
            }
        }

        private void txtTextoABuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case (char) Keys.Enter :
                    if (this.txtTextoABuscar.Text != "")
                    {

                        ProcesarDesdeRutaSeleccionada();
                    }
                    else
                    {
                        this.lblhora.Text = "";
                        this.lblTotal.Text = "";
                        this.dgvResultados.DataSource = null;
                    }
                break;
            }

        }

        private void ProcesarDesdeRutaSeleccionada()
        {
            DateTime horaInicial = System.DateTime.Now;

            DataTable tabla = new DataTable();
            tabla.Columns.Add("NOMBRE", typeof(String));
            CargarListaArchivos(dialogoCarpetaInicial.SelectedPath);
            foreach (string archivo in listaNombreDirs )
            {
                bool encontrado = false;
                try
                {
                    this.lblArchivos.Text = archivo;
                    this.Update();
                    string texto = System.IO.File.ReadAllText(archivo);
                    if ( texto.Contains(this.txtTextoABuscar.Text)  )
                    {
                        tabla.Rows.Add(archivo);
                        encontrado = true;
                    }
                    if (!encontrado)
                    {
                        if (archivo.Contains(this.txtTextoABuscar.Text))
                        {
                            tabla.Rows.Add(archivo);
                        }
                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Problemas con la bùsqueda " + ex.Message);
                }

                
            }
            this.dgvResultados.DataSource = tabla;
            this.lblTotal.Text = this.dgvResultados.Rows.Count.ToString();
            DateTime horaFinal = System.DateTime.Now;
            TimeSpan diferencia = horaFinal - horaInicial;
            this.lblhora.Text = diferencia.Hours.ToString() + "º " + diferencia.Minutes.ToString() + "\' " + diferencia.Seconds.ToString() + "\"";

        }

        private void CargarListaArchivos(string ruta)
        {
            foreach (string archivos in Directory.GetFiles(ruta))
            {
                listaNombreDirs.Add(archivos);
            }
            DirSearch(ruta);

        }

        private void DirSearch(string sDir)
        {
            try
            {


                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d ))
                    {
                        listaNombreDirs.Add(f);
                        
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private void dgvResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string contenido = this.dgvResultados.Rows[e.RowIndex].Cells[0].Value.ToString();
                System.Diagnostics.Process.Start(contenido);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Problema en la grilla " + ex1.Message);
            }
        }




    }
}
