using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaProgramador2021
{
    public partial class MenuPrincipal : Form
    {
        RegistroEquipamentos tela1; //Frame de adm de equipamentos 
        RegistroChamadas tela2;     //Frame de adm de equipamentos 
        public MenuPrincipal()
        {
            InitializeComponent(); 
            
        }

        //ação de abrir o Frame 1
        private void button1_Click(object sender, EventArgs e)
        {
            tela1 = new RegistroEquipamentos();
            tela1.ShowDialog();
        }

        //ação de abrir o Frame 2
        private void button2_Click(object sender, EventArgs e)
        {
            tela2 = new RegistroChamadas();
            tela2.ShowDialog();
        }
    }
}
