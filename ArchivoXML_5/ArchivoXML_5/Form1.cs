using ArchivoXML_5.BLL;
using ArchivoXML_5.EE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivoXML_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefrescarXML();
        }

        private void RefrescarXML()
        {
            grillaGenero.DataSource = null;
            grillaGenero.DataSource = new XmlBLL("Genero.xml").GetAll();
        }

        private void btn_serializar_Click(object sender, EventArgs e)
        {
            new XmlBLL("Genero.xml").Save(new Genero { Id = Guid.NewGuid().ToString(), Fecha_reg = DateTime.Now, Nombre = txt_nombre_usuario.Text});
            RefrescarXML();
        }
    }
}
