using System.Diagnostics; //Libreria para usar "Process"
using System;

namespace PSP01_TA_procesos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLanzarProceso_Click(object sender, EventArgs e)
        {
            //Lanza el proceso notepad con el path absoluto
            p = Process.Start(@"C:\Windows\System32\calc.exe");
            this.labelID.Text = "IDcreado:" + p.Id;
        }

        private void buttonMatarProceso_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxProc.SelectedItem != null)
                {
                    ClaseProc seleccion = (ClaseProc)comboBoxProc.SelectedItem;
                    MessageBox.Show($"Nombre: {seleccion.Nombre}, Valor: {seleccion.Valor}");
                    p = Process.GetProcessById(seleccion.Valor);
                    if (p.Id != null && !p.HasExited)
                    {
                        //Muestra el id por pantalla
                        this.labelID.Text = "IDmatado:" + p.Id;
                        //Mata el proceso
                        p.Kill();
                        //Inicializa el proceso a null.
                        p = null;
                       
                    }
                    rellenarCombo();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un elemento del ComboBox.");
                }
            }
            catch (Exception ex)
            {
                // Muestra el error para depuración
                MessageBox.Show("Error al intentar matar el proceso: " + ex.Message);
            }
        }

        private void buttonMostrarProcSist_Click(object sender, EventArgs e)
        {
            rellenarCombo();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //método para rellanar Combo
        private void rellenarCombo()
        {
            //recoge los procesos del sistema en un array de tipo Process
            Process[] misProcesos = Process.GetProcesses();
            //Limmpia datos del comboBox
            this.comboBoxProc.Items.Clear();
            //Por cada proceso del sistema
            foreach (Process mp in misProcesos)
            {
                //Añade el nombre
                this.comboBoxProc.Items.Add(new ClaseProc(mp.ProcessName, mp.Id));
            }
            //Muestra el primer nombre del array por defecto.
            this.comboBoxProc.SelectedIndex = 0;
        }

    }
}


//Clase que recoge ID y nombre de proceso en combo
//@Nombre: Nombre de proceso
//@Valor: ID del proceso
class ClaseProc
{
    public string Nombre;
    public int Valor;

    public ClaseProc(string name, int value)
    {
        Nombre = name;
        Valor = value;
    }
    public override string ToString()
    {
        return Nombre;
    }
}