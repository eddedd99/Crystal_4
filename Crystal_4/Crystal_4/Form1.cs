using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Este reporte se construyó con el tutorial: https://youtu.be/MPKqjffs1d8
            //Video: Reportes en C# .Net con VS 2019 (3-3) Diseñando nuestro reporte
            //Autor: Juan Carlos Arcila Díaz (autor del video)

            //Paso 1. Botón derecho en Crystal_4 > Add > New Item > Data > Dataset
            //Paso 2. Seleccionar el Dataset > Add > Table Adapter
            //Paso 3. Configurar Table Adapter (Con el query a utilizar)
            //Paso 4. Botón derecho en Crystal_4 > Add > New Item > Reporting > Report (sin wizard)
            //Paso 5. Seleccionar Form1 y agregar componente ReportViewer
            //Application.ExitThread.
            
            // TODO: This line of code loads data into the 'DataSet1.REPORTE_USUARIOS' table. You can move, or remove it, as needed.
            this.REPORTE_USUARIOSTableAdapter.Fill(this.DataSet1.REPORTE_USUARIOS);
            this.reportViewer1.RefreshReport();
            //new Form2().Show();            
       }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
