using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liste_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ogrenci ogrenci;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciliste = new List<Ogrenci>();

            ogrenciliste.Add(new Ogrenci(26, "Elif Torun", "10A", "4676343786"));
            ogrenciliste.Add(new Ogrenci(44, "Kevser Ramazanoğlu ", "10A", "4347386535"));
            ogrenciliste.Add(new Ogrenci(132, "Hiranur Kulakçı", "10A", "655436838058"));   
            ogrenciliste.Add(new Ogrenci(1120, "Rabia Akkuş", "10A", "6687567597"));
            ogrenciliste.Add(new Ogrenci(321, "Göknur Duran", "10A", "5248979039"));
            ogrenciliste.Add(new Ogrenci(245, "Sedef Şirin", "10A", "4647493879"));

            dataGridView1.DataSource= ogrenciliste.ToList();



        }
    }
}
