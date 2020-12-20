using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Npgsql;
using System.Collections.Generic;
namespace Clasificacion_Texturas
{
    public partial class Form1 : Form
    {
        int cR, cB, cG;
        int cmR, cmB, cmG;

        //Dictionary<String, int[]> textures = new Dictionary<String, int[]>();
        //Dictionary<String, Color> colors = new Dictionary<String, Color>();
        Bitmap bmpg;
        Bitmap bmpt;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Bitmap bg, Bitmap bt)
        {
            InitializeComponent();
            bmpg = bg;
            bmpt = bt;
            pictureBox1.Image = bmpg;
        }

        public List<String[]> select()
        {
            List<String[]> textures = new List<String[]>();

            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123456;Database=TextureColors");
            con.Open();
            String sql = "select * from textura";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                String[] txr = new String[8];
                txr[0] = rdr.GetInt32(0) + "";
                txr[1] = rdr.GetString(1) + "";
                txr[2] = rdr.GetInt32(2) + "";
                txr[3] = rdr.GetInt32(3) + "";
                txr[4] = rdr.GetInt32(4) + "";
                txr[5] = rdr.GetInt32(5) + "";
                txr[6] = rdr.GetInt32(6) + "";
                txr[7] = rdr.GetInt32(7) + "";

                textures.Add(txr);
            }

            con.Close();
            return textures;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Bitmap bmp2 = new Bitmap(bmpg.Width, bmpg.Height);
            List<String[]> textures = select();

            
            int ciR, ciG, ciB;
            Color c = new Color();
            int interv = 10;

            for (int i = 0; i < bmpt.Width; i++)
            {
                for (int j = 0; j < bmpt.Height; j++)
                {

                    c = bmpg.GetPixel(i, j);
                    int[] cls = { c.R, c.G, c.B };

                    foreach (String[] k in textures)
                    {
                        bool sw = true;
                        int r = Int32.Parse(k[2]);
                        int g = Int32.Parse(k[3]);
                        int b = Int32.Parse(k[4]);
                        int[] clText = { r, g, b };

                        for (int l = 0; l < clText.Length; l++)
                        {
                            if (!(clText[l] - interv < cls[l] && cls[l] < clText[l] + interv))
                            {
                                sw = false;
                                break;
                            }

                        }

                        if (sw)
                        {
                            int rc = Int32.Parse(k[5]);
                            int gc = Int32.Parse(k[6]);
                            int bc = Int32.Parse(k[7]);
                            
                           
                            Color clr = Color.FromArgb(rc, gc, bc);
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    bmp2.SetPixel(x, y, clr);
                                }

                            break;

                        }
                        else
                        {
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    bmp2.SetPixel(x, y, c);
                                }
                        }
                    }

                }
            }
            pictureBox1.Image = bmp2;
            
            

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null) {
                var fileName = data as String[];
                if (fileName.Length > 0) {
                    Bitmap bmp = new Bitmap(fileName[0]);
                    pictureBox1.Image = bmp;
                    bmpg = new Bitmap(fileName[0]);
                    calcular();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(bmpg, bmpt);
            f2.ShowDialog();
            this.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            List<String[]> textures = select();
            ListViewGroup texturas = new ListViewGroup("Nombre Textura");
            foreach(String[] i in textures) {
                ListViewItem l = new ListViewItem(i[1], texturas);
                int r = Int32.Parse(i[5]);
                int g = Int32.Parse(i[6]);
                int b = Int32.Parse(i[7]);

                l.BackColor = Color.FromArgb(r,g,b);
                l.ForeColor = Color.White;
               
                listView1.Items.Add(l);
            }
            
            
            listView1.Groups.Add(texturas);
        }
    

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        public void calcular() {
            int n = 5;
            int n2 = n * n;

            bmpt = new Bitmap(bmpg.Width-n, bmpg.Height-n);
           
            int ciR, ciG, ciB;
            Color c = new Color();
            
            for (int i = 0; i < bmpg.Width - n; i++)
            {
                for (int j = 0; j < bmpg.Height - n; j++)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;

                    for (int x = i; x < i + n; x++)
                        for (int y = j; y < j + n; y++)
                        {
                            c = bmpg.GetPixel(x, y);
                            ciR += c.R;
                            ciG += c.G;
                            ciB += c.B;
                        }
                    ciR /= n2;
                    ciG /= n2;
                    ciB /= n2;

                    bmpt.SetPixel(i,j, Color.FromArgb(ciR, ciG, ciB));
            
                }
            }

 
        }
    }
}
