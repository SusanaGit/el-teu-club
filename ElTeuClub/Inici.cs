using System.Text;

namespace ElTeuClub
{
    public partial class Inici : Form
    {
        List<String> socisNom = new List<String>();
        List<String> socisCognoms = new List<String>();
        List<String> socisDireccio = new List<String>();
        List<String> socisTelefon = new List<string>();
        List<String> socisMail = new List<string>();
        List<DateTime> socisRegistre = new List<DateTime>();
        List<String> socisActivitats = new List<String>();
        List<int> idFotos = new List<int>();
        int posSoci = 0;


        // LLEGIR DADES DEL FITXER socis.txt
        private void llistaSocis()
        {
            string line;
            string[] separe = new string[] { ";" };
            string[] camps;

            System.IO.StreamReader file = new System.IO.StreamReader(@"socis.txt", Encoding.UTF8);

            while ((line = file.ReadLine()) != null)
            {
                camps = line.Split(separe, StringSplitOptions.None);
                socisNom.Add(camps[0]);
                socisCognoms.Add(camps[1]);
                socisDireccio.Add(camps[2]);
                socisTelefon.Add(camps[3]);
                socisMail.Add(camps[4]);
                socisRegistre.Add(DateTime.Parse(camps[5]));
                socisActivitats.Add(camps[6]);
                idFotos.Add(int.Parse(camps[7]));
            }
            file.Close();
        }

        // INICIALITZAR
        public Inici()
        {
            InitializeComponent();

            // inicialitzo llistat de socis
            llistaSocis();

            mostrarSoci();

        }

        // MOSTRAR UN SOCI
        private void mostrarSoci()
        {
            bloquejarEscriure(true);

            txtbox_nomSoci.Text = socisNom[posSoci];
            txtbox_cognomsSoci.Text = socisCognoms[posSoci];
            txtbox_direccio.Text = socisDireccio[posSoci];
            txtbox_telefon.Text = socisTelefon[posSoci];
            txtbox_mail.Text = socisMail[posSoci];
            dateTimePicker_registre.Value = socisRegistre[posSoci];

            // mostrar les activitats
            string[] activitats = socisActivitats[posSoci].Split(',');

            desmarcarItems();

            for (int i = 0; i < chcklist_activitats.Items.Count; i++)
            {
                string activitatActual = chcklist_activitats.Items[i].ToString();
                
                if (activitats.Contains(activitatActual))
                {
                    chcklist_activitats.SetItemChecked(i, true);
                }
                
            }

            // mostrar foto
            string ruta = "fotos/" + idFotos[posSoci] + ".png";
            picbox_foto.Image = Image.FromFile(ruta);
        }

        // desmarcar tots els ítems del checklist
        private void desmarcarItems()
        {
            for (int i = 0; i < chcklist_activitats.Items.Count; i++)
            {
                chcklist_activitats.SetItemChecked(i, false);
            }
        }



        // BUIDAR DADES FORMULARI PER PODER AFEGIR LES DADES DEL NOU SOCI
        private void buidarDadesFormulari()
        {
            txtbox_nomSoci.Clear();
            txtbox_cognomsSoci.Clear();
            txtbox_direccio.Clear();
            txtbox_telefon.Clear();
            txtbox_mail.Clear();
            dateTimePicker_registre.Value = DateTime.Today;
            desmarcarItems();
            picbox_foto.Image = null;
        }



        // PREGUNTAR SI GUARDA CANVIS
        private void preguntarSiGuardaCanvis(String opcio)
        {
            String missatgePregunta = "";
            String missatgeExit = "";
            String missatgeNoGuardar = "";
            bool guardarSoci = false;
            bool guardarCanvis = false;
            bool eliminarSoci = false;

            switch (opcio)
            {
                case "soci":

                    missatgePregunta = "Voleu guardar el soci?";
                    missatgeExit = "Soci guardat";
                    missatgeNoGuardar = "Soci no guardat";
                    guardarSoci = true;

                    break;

                case "canvis":

                    missatgePregunta = "Voleu guardar els canvis?";
                    missatgeExit = "Canvis guardats";
                    missatgeNoGuardar = "Canvis no guardats";
                    guardarCanvis = true;

                    break;

                case "borrar":

                    missatgePregunta = "Voleu eliminar el soci?";
                    missatgeExit = "Soci eliminat";
                    missatgeNoGuardar = "Soci no eliminat";
                    eliminarSoci = true;

                    break;
            }

            decisioGuardarCanvis(missatgePregunta, missatgeExit, missatgeNoGuardar, guardarSoci, guardarCanvis, eliminarSoci);

        }

        private void decisioGuardarCanvis(String missatgePregunta, String missatgeExit, String missatgeNoGuardar, bool guardarSoci, bool guardarCanvis, bool eliminarSoci)
        {


            if (MessageBox.Show(missatgePregunta, "Atenció", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                guardar(guardarSoci, guardarCanvis, eliminarSoci);
                MessageBox.Show(missatgeExit);
            }
            else
            {
                MessageBox.Show(missatgeNoGuardar);
            }

        }


        // PICBOXS PER GUARDAR ELS CANVIS
        // nou soci
        private void picbox_addSoci_Click(object sender, EventArgs e)
        {
            preguntarSiGuardaCanvis("soci");
            picbox_addSoci.Visible = false;
        }

        // canvis
        private void picbox_floppy_Click(object sender, EventArgs e)
        {
            preguntarSiGuardaCanvis("canvis");
            picbox_floppy.Visible = false;
        }

        // borrar
        private void picbox_borrar_Click(object sender, EventArgs e)
        {
            preguntarSiGuardaCanvis("borrar");
            picbox_borrar.Visible = false;
        }

        // BUTTONS
        // nou soci 
        private void btn_afegirNouSoci_Click(object sender, EventArgs e)
        {
            picbox_addSoci.Visible = true;
            picbox_borrar.Visible = false;
            picbox_floppy.Visible = false;
            buidarDadesFormulari();
            bloquejarEscriure(false);
        }

        // canvis
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            picbox_addSoci.Visible = false;
            picbox_borrar.Visible = false;
            picbox_floppy.Visible = true;
            bloquejarEscriure(false);
        }

        // borrar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            picbox_addSoci.Visible = false;
            picbox_borrar.Visible = true;
            picbox_floppy.Visible = false;
            bloquejarEscriure(false);
        }

        // BLOQUEJAR PODER ESCRIURE
        private void bloquejarEscriure(bool bloquegemEscriure)
        {
            txtbox_nomSoci.ReadOnly = bloquegemEscriure;
            txtbox_cognomsSoci.ReadOnly = bloquegemEscriure;
            txtbox_direccio.ReadOnly = bloquegemEscriure;
            txtbox_telefon.ReadOnly = bloquegemEscriure;
            txtbox_mail.ReadOnly = bloquegemEscriure;
            dateTimePicker_registre.Enabled = !bloquegemEscriure;
            chcklist_activitats.Enabled = !bloquegemEscriure;
        }

        // GUARDAR CANVIS EN EL ARXIU socis.txt
        private void guardar(bool soci, bool canvis, bool borrar)
        {
            modificarValorsLlistes(soci, canvis, borrar);

            System.IO.StreamWriter file = new System.IO.StreamWriter(@"socis.txt", false);

            for (int i = 0; i < socisNom.Count; i++)
            {

                string frase = (socisNom[i] + ";" + socisCognoms[i] + ";" + socisDireccio[i]) + ";" + (socisTelefon[i] + ";" + socisMail[i] + ";" + socisRegistre[i] + ";" + socisActivitats[i] + ";" + idFotos[i] + ";");

                file.WriteLine(frase);
            }
            file.Close();
        }

        // MODIFICAR LES LLISTES DE DADES
        private void modificarValorsLlistes(bool soci, bool canvis, bool borrar)
        {
            string nouNomSoci = txtbox_nomSoci.Text;
            string nousCognoms = txtbox_cognomsSoci.Text;
            string novaDireccio = txtbox_direccio.Text;
            string nouTelefon = txtbox_telefon.Text;
            string nouMail = txtbox_mail.Text;

            DateTime novaDataRegistre = dateTimePicker_registre.Value;

            string novesActivitats = activitatsSeleccionades();

            if (soci == true)
            {
                socisNom.Add(nouNomSoci);
                socisCognoms.Add(nousCognoms);
                socisDireccio.Add(novaDireccio);
                socisTelefon.Add(nouTelefon);
                socisMail.Add(nouMail);
                socisRegistre.Add(novaDataRegistre);

                socisActivitats.Add(novesActivitats);

                int nouIdFoto = idFotos[idFotos.Count - 1] + 1;
                idFotos.Add(nouIdFoto);
            }
            else if (canvis == true)
            {
                socisNom[posSoci] = nouNomSoci;
                socisCognoms[posSoci] = nousCognoms;
                socisDireccio[posSoci] = novaDireccio;
                socisTelefon[posSoci] = nouTelefon;
                socisRegistre[posSoci] = novaDataRegistre;
                socisMail[posSoci] = nouMail;
                socisActivitats[posSoci] = novesActivitats;
            }
            else if (borrar == true)
            {
                socisNom.RemoveAt(posSoci);
                socisCognoms.RemoveAt(posSoci);
                socisDireccio.RemoveAt(posSoci);
                socisTelefon.RemoveAt(posSoci);
                socisRegistre.RemoveAt(posSoci);
                socisMail.RemoveAt(posSoci);
                socisActivitats.RemoveAt(posSoci);
                idFotos.RemoveAt(posSoci);
            }
        }

        // OBTENIR ACTIVITATS SELECCIONADES DEL CHECKLIST
        private string activitatsSeleccionades()
        {
            StringBuilder activitatsSeleccionades = new StringBuilder();

            for (int i = 0; i < chcklist_activitats.Items.Count; i++)
            {
                string activitatActual = chcklist_activitats.Items[i].ToString();

                if (chcklist_activitats.GetItemChecked(i))
                {
                    activitatsSeleccionades.Append(activitatActual);
                    activitatsSeleccionades.Append(",");
                }

            }

            string novesActivitats = activitatsSeleccionades.ToString();

            return novesActivitats;
        }

        // MOURE'S PELS SOCIS
        private void picBox_primer_Click(object sender, EventArgs e)
        {
            bloquejarEscriure(true);
            posSoci = 0;
            mostrarSoci();
        }

        private void picBox_ultim_Click(object sender, EventArgs e)
        {
            bloquejarEscriure(true);
            posSoci = socisNom.Count - 1;
            mostrarSoci();
        }

        private void picBox_esquerre_Click(object sender, EventArgs e)
        {
            bloquejarEscriure(true);
            if (posSoci > 0)
            {
                posSoci--;
            }
            mostrarSoci();
        }

        private void picBox_dreta_Click(object sender, EventArgs e)
        {
            bloquejarEscriure(true);
            if (posSoci < (socisNom.Count - 1))
            {
                posSoci++;
            }
            mostrarSoci();
        }

        // TANCAR
        private void btn_tancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
