using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Controleur;

namespace SalleRestauration
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        int hh = 10;
        int mm = 0;
        int ss = 0;
        int client = new Random().Next(1, 10);
        Controleur.CLprocessus processus;
        string nomTable;
        public Form1()
        {
            InitializeComponent();
            processus = new CLprocessus();
            nomTable = "Commande";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mise en place du timer
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();


            //initialise le restaurant
            Restaurant restaurant = new Restaurant();
            Salle salle = new Salle(restaurant.salle);

            Thread threadClient = new Thread(new ThreadStart(salle.StartClient));
            threadClient.Start();

            Thread.Sleep(1000);

            Thread threadAddClient = new Thread(new ThreadStart(salle.addClient));
            threadAddClient.Start();
            //salle.addClient();

            Thread.Sleep(1000);

            int num = restaurant.salle.maitre.attribuerTable(client);
            Console.WriteLine("Table " + num);

            Console.WriteLine("Commande en cours...");
            //salle.nouveauClient().commander();
            Console.WriteLine("Commande passée...");

            var picture = new PictureBox
            {
                Name = "client",
                Size = new  Size(16, 16),
                Location = new Point(100, 100)
            };
            this.Controls.Add(picture);

            //processus.afficher(nomTable);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void t_Tick(object sender, EventArgs e)
        {

            string time = "";

            if (ss<59)
            {
                ss++;
            }
            else
            {
                mm++;
                ss = 0;
            }

            if (mm == 59)
            {
                hh++;
                mm = 0;
            }

            if(hh > 22)
            {
                hh = 0;
            }

            if (hh<10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            label1.Text = time;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
