using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PollosHermanosRP.Logica
{
    public class ProductoBotones
    {
        public string conexion = "server=localhost;user=root;database=polloshermanosdb;port=3306;password=1234";
        public List<Item> productosSeleccionados = new List<Item>();

        private DataGridView dtgProductos;
        private Label lblTotal;

        // Constructor que recibe el DataGridView y el Label de total como parámetros
        public ProductoBotones(DataGridView dtgProductos, Label lblTotal)
        {
            this.dtgProductos = dtgProductos;
            this.lblTotal = lblTotal;
        }

        public void DibujarBotonesProductos(FlowLayoutPanel panel, string tabla, string columna, string caracteristica)
        {
            panel.Controls.Clear();
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT ID, {columna}, Precio FROM {tabla} WHERE activo = 1 AND caracteristica = '{caracteristica}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("ID");
                                string nombre = reader.GetString(columna);
                                decimal precio = reader.GetDecimal("Precio");
                                Button btn = CrearBoton(id, nombre, precio);
                                panel.Controls.Add(btn);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
                }
            }
        }

        public Button CrearBoton(int id, string nombre, decimal precio)
        {
            Button btn = new Button
            {
                Text = nombre,
                Name = "btn_" + id,
                Size = new Size(200, 100),
                BackColor = ColorTranslator.FromHtml("LightYellow"),
                Tag = new { Id = id, Nombre = nombre, Precio = precio },
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.Black;

            btn.Click += (sender, e) =>
            {
                var button = sender as Button;
                var data = (dynamic)button.Tag;
                AgregarProducto( data.Nombre, data.Precio);
                ActualizarGrid();
            };

            return btn;
        }

        public void AgregarProducto(string nombre, decimal precio)
        {
            // Buscar el producto por nombre en lugar de por ID
            var productoExistente = productosSeleccionados.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (productoExistente != null)
            {
                // Si el producto ya existe, incrementar la cantidad
                productoExistente.Cantidad++;
            }
            else
            {
                // Si el producto no existe, añadirlo a la lista con cantidad 1
                productosSeleccionados.Add(new Item
                {
                    Id = GenerarNuevoId(), // Método ficticio para generar un nuevo ID, debes implementarlo según tu lógica
                    Nombre = nombre,
                    Precio = precio,
                    Cantidad = 1
                });
            }
        }

        // Método ficticio para generar un nuevo ID único
        private int GenerarNuevoId()
        {
            // Generar un nuevo ID único (puede ser implementado de diversas maneras)
            // Aquí simplemente se utiliza un valor ficticio para ilustración
            return productosSeleccionados.Count > 0 ? productosSeleccionados.Max(p => p.Id) + 1 : 1;
        }

        public void ActualizarGrid()
        {
            dtgProductos.SuspendLayout();
            dtgProductos.Rows.Clear();

            decimal total = 0;

            foreach (var producto in productosSeleccionados)
            {
                decimal subtotal = producto.Precio * producto.Cantidad;
                total += subtotal;

                dtgProductos.Rows.Add(
                     producto.Id,
                     producto.Nombre,
                     producto.Precio.ToString("C2"),
                     producto.Cantidad,
                     subtotal.ToString("C2")
                 );
            }
            dtgProductos.ResumeLayout();
            lblTotal.Text = $"Total: {total:C2}";
        }
    }
}
