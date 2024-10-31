using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollosHermanosRP.Logica
{
    class MesasBotones
    {
    

        public static void dibujarMesas(FlowLayoutPanel panel, string area)
        {
           
                panel.Controls.Clear();
            try
            {
                Conexion.Abrir();

                // Dibujar mesas disponibes
                string queryPlatillos = "SELECT ID, NoMesa  FROM MESA WHERE activo = 1 && area=@area;";
                using (MySqlCommand cmd = new MySqlCommand(queryPlatillos, Conexion.con))
                {
                    cmd.Parameters.AddWithValue("@area", area);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string noMesa = reader.GetString("NoMesa");


                            Button btn = CrearBoton(id, noMesa);
                            btn.Tag = noMesa;

                            btn.Click += (sender, e) =>
                            {
                                string NoMesa = btn.Tag.ToString();

                                MesasForm.SetValorNoMesa(NoMesa);
                                MesasForm.AsignacionMesa(id);
                            };
                            panel.Controls.Add(btn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
            finally { Conexion.Cerrar(); }
            
        }


        public static void dibujarMesas(FlowLayoutPanel panel, int mesero, string area)
        {
            panel.Controls.Clear();
            try
            {
                Conexion.Abrir();

                // Dibujar mesas 
                string consulta = "SELECT id,NoMesa FROM mesa WHERE mesero = @mesero && area = @area;";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                comando.Parameters.AddWithValue("@mesero", mesero);
                comando.Parameters.AddWithValue("@area", area);


                MySqlDataReader reader = comando.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string noMesa = reader.GetString("NoMesa");


                            Button btn = CrearBoton(id, noMesa);
                            btn.Tag = noMesa;

                            btn.Click += (sender, e) =>
                            {
                                string NoMesa = btn.Tag.ToString();

                                MesasForm.SetValorNoMesa(NoMesa);
                                MesasForm.AsignacionMesa(id);
                            };
                            panel.Controls.Add(btn);
                        }
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
            finally { Conexion.Cerrar(); }
        }
        
        private static Button CrearBoton(int id, string nombre)
        {
            Button btn = new Button
            {
                Text = nombre,
                Name = "btn_" + id,
                Size = new System.Drawing.Size(213, 110),
                BackColor = ColorTranslator.FromHtml("LightYellow"),
                Tag = id,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 14, FontStyle.Bold)

            };

            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.Black;

            return btn;
        }
    }
}
