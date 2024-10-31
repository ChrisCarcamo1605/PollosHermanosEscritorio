using MySql.Data.MySqlClient;
using PollosHermanosRP.Logica;
using System.Data;

namespace PollosHermanosRP
{
    public partial class GestionMenu : Form
    {



        private void Addelement_Load(object sender, EventArgs e)
        {

            imprimirDatos();

        }
        //validacion y asignacion de las variables
        private bool ValidateInputs(out string tipo, out string caracteristica)
        {
            tipo = "";
            caracteristica = "";

            string nombreElemento = txtnombreelemento.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            string precioText = txtprecio.Text.Trim();

            if (string.IsNullOrEmpty(nombreElemento))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el elemento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, ingrese una descripción para el elemento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(precioText) || !decimal.TryParse(precioText, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un precio válido mayor que 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!chkalimento.Checked && !chkbebida.Checked)
            {
                MessageBox.Show("Por favor, seleccione si el elemento es un Alimento o una Bebida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            tipo = chkalimento.Checked ? "Alimento" : "Bebida";

            if (chkbebida.Checked)
            {
                Bebida bebidaForm = panel1.Controls.OfType<Bebida>().FirstOrDefault();
                if (bebidaForm == null)
                {
                    MessageBox.Show("El formulario de bebida no está abierto o no se puede encontrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (bebidaForm.chkfria.Checked)
                {
                    caracteristica = "Bebida Fría";
                }
                else if (bebidaForm.chkcaliente.Checked)
                {
                    caracteristica = "Bebida Caliente";
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una característica para la bebida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (chkalimento.Checked)
            {
                Alimento alimentoForm = panel1.Controls.OfType<Alimento>().FirstOrDefault();
                if (alimentoForm == null)
                {
                    MessageBox.Show("El formulario de alimento no está abierto o no se puede encontrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (alimentoForm.chkentrada.Checked)
                {
                    caracteristica = "Plato Entrada";
                }
                else if (alimentoForm.chkplatofuerte.Checked)
                {
                    caracteristica = "Plato Fuerte";
                }
                else if (alimentoForm.chkpostre.Checked)
                {
                    caracteristica = "Postre";
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una característica para el alimento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        public void imprimirDatos(string tabla)
        {
            try
            {
                Conexion.Abrir();
                string consulta = $"select * from {tabla}";
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, Conexion.con);
                DataTable dt1 = new DataTable();
                comando.Fill(dt1);
                dtgelementos.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Conexion.Cerrar(); }
        }

        public void imprimirDatos()
        {
            try
            {
                string consulta1 = $"select * from Platillos";
                string consulta2 = $"select * from Bebidas";
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta1, Conexion.con);
                MySqlDataAdapter comando2 = new MySqlDataAdapter(consulta2, Conexion.con);
                DataTable dt1 = new DataTable();
                comando.Fill(dt1);
                DataTable dt2 = new DataTable();
                comando2.Fill(dt2);
                dt1.Merge(dt2);
                dtgelementos.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Conexion.Cerrar(); }

        }

        public GestionMenu()
        {
            InitializeComponent();

        }

        public void chkbebida_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbebida.Checked)
            {
                if (chkalimento.Checked)
                {
                    chkalimento.Checked = false;
                }

                Bebida bebida = new Bebida
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                panel1.Controls.Clear();
                panel1.Controls.Add(bebida);
                bebida.Show();
            }
            else if (!chkalimento.Checked && !chkbebida.Checked)
            {
                panel1.Controls.Clear();
            }
        }

        public void chkalimento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkalimento.Checked)
            {
                if (chkbebida.Checked)
                {
                    chkbebida.Checked = false;
                }

                Alimento alimento = new Alimento
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                panel1.Controls.Clear();
                panel1.Controls.Add(alimento);
                alimento.Show();
            }
            else if (!chkalimento.Checked && !chkbebida.Checked)
            {
                panel1.Controls.Clear();
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtprice = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.' || e.KeyChar == ',') && txtprice.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }
            if (txtprice.Text.Contains("."))
            {
                string[] splitText = txtprice.Text.Split('.');
                if (splitText.Length > 1 && splitText[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
        }
        private void txtnombreelemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
        }
        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void btnagregar_Click(object sender, EventArgs e)
        {

            // Validar las entradas
            if (ValidateInputs(out string tipo, out string Caracteristica))
            {
                string tipoRegistro = "";
                switch (tipo)
                {

                    case "Bebida":
                        tipoRegistro = "Bebidas";
                        break;
                    case "Alimento":
                        tipoRegistro = "Platillos";

                        break;

                }


                // Obtener los datos de los controles
                string nombreElemento = txtnombreelemento.Text.Trim();
                string descripcion = txtdescripcion.Text.Trim();
                string precioText = txtprecio.Text.Trim();
                decimal precio = decimal.Parse(precioText);
                try
                {
                    Conexion.Abrir();
                    string consulta = "INSERT INTO " + tipoRegistro + "(Nombre, Precio, Tipo,caracteristica,descripcion) VALUES (@NombreElemento, @Precio,@tipo, @Caracteristica, @Descripcion)";
                    MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                    comando.Parameters.AddWithValue("@NombreElemento", nombreElemento);
                    comando.Parameters.AddWithValue("@Precio", precio);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    comando.Parameters.AddWithValue("@Caracteristica", Caracteristica);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Conexion.Cerrar();
                }

                imprimirDatos(tipoRegistro);

                // Limpiar los controles
                txtnombreelemento.Clear();
                txtdescripcion.Clear();
                txtprecio.Clear();
                chkalimento.Checked = false;
                chkbebida.Checked = false;

                // Resetear los formularios Bebida y Alimento
                Bebida bebidaFormInPanel = panel1.Controls.OfType<Bebida>().FirstOrDefault();
                if (bebidaFormInPanel != null)
                {
                    bebidaFormInPanel.chkfria.Checked = false;
                    bebidaFormInPanel.chkcaliente.Checked = false;
                }

                Alimento alimentoFormInPanel = panel1.Controls.OfType<Alimento>().FirstOrDefault();
                if (alimentoFormInPanel != null)
                {
                    alimentoFormInPanel.chkentrada.Checked = false;
                    alimentoFormInPanel.chkplatofuerte.Checked = false;
                    alimentoFormInPanel.chkpostre.Checked = false;
                }


            }
        }


        public void actuaizarRegistro(string tabla, string columna, string registroNuevo, int id)
        {
            try
            {
                Conexion.Abrir();
                string consulta = "UPDATE " + tabla + " set " + columna + " = @registroNuevo WHERE id = @Id";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@registroNuevo", registroNuevo);
                comando.Parameters.AddWithValue("@Tabla", tabla);
                comando.ExecuteNonQuery();
                imprimirDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Conexion.Cerrar(); }

        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dtgelementos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string tipo = "";
                string caracteristica = "";


                tipo = chkalimento.Checked ? "Alimento" : "Bebida";

                if (chkbebida.Checked)
                {
                    Bebida bebidaForm = panel1.Controls.OfType<Bebida>().FirstOrDefault();
                    if (bebidaForm == null)
                    {
                        MessageBox.Show("El formulario de bebida no está abierto o no se puede encontrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (bebidaForm.chkfria.Checked)
                    {
                        caracteristica = "Bebida Fría";
                    }
                    else if (bebidaForm.chkcaliente.Checked)
                    {
                        caracteristica = "Bebida Caliente";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione una característica para la bebida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                        ;
                    }
                }
                else if (chkalimento.Checked)
                {
                    Alimento alimentoForm = panel1.Controls.OfType<Alimento>().FirstOrDefault();
                    if (alimentoForm == null)
                    {
                        MessageBox.Show("El formulario de alimento no está abierto o no se puede encontrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (alimentoForm.chkentrada.Checked)
                    {
                        caracteristica = "Plato Entrada";
                    }
                    else if (alimentoForm.chkplatofuerte.Checked)
                    {
                        caracteristica = "Plato Fuerte";
                    }
                    else if (alimentoForm.chkpostre.Checked)
                    {
                        caracteristica = "Postre";
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione una característica para el alimento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DataGridViewRow filaSeleccionada = dtgelementos.SelectedRows[0];
                var idCelda = filaSeleccionada.Cells[0].Value;

                int id = Convert.ToInt16(idCelda);
                string nombre = txtnombreelemento.Text.Trim();
                string descripcion = txtdescripcion.Text.Trim();
                string precio = txtprecio.Text.Trim();

                if (id != 0)
                {
                    string tabla = string.Empty;
                    switch (tipo)
                    {
                        case "Bebida":
                            tabla = "Bebidas";
                            break;
                        case "Alimento":
                            tabla = "Platillos";
                            break;
                            break;
                    }
                    tabla = "Platillos";
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        actuaizarRegistro(tabla, "nombre", nombre, id);
                    }
                    if (!string.IsNullOrEmpty(precio))
                    {
                        actuaizarRegistro(tabla, "precio", precio, id);
                    }
                    if (chkalimento.Checked || chkbebida.Checked)
                    {
                        actuaizarRegistro(tabla, "tipo", tipo, id);
                    }
                    if (chkalimento.Checked || chkbebida.Checked)
                    {
                        actuaizarRegistro(tabla, "caracteristica", caracteristica, id);
                    }
                    if (!string.IsNullOrEmpty(descripcion))
                    {
                        actuaizarRegistro(tabla, "descripcion", descripcion, id);
                    }
                    if (!string.IsNullOrEmpty(descripcion))
                    {
                        imprimirDatos(tabla);
                        actuaizarRegistro(tabla, "descripcion", descripcion, id);
                    }
                    // Limpia los campos y restablece las casillas de verificación
                    txtnombreelemento.Clear();
                    txtdescripcion.Clear();
                    txtprecio.Clear();
                    chkalimento.Checked = false;
                    chkbebida.Checked = false;
                    txtdescripcion.Clear();
                    Bebida bebidaFormInPanel = panel1.Controls.OfType<Bebida>().FirstOrDefault();
                    if (bebidaFormInPanel != null)
                    {
                        bebidaFormInPanel.chkfria.Checked = false;
                        bebidaFormInPanel.chkcaliente.Checked = false;
                    }
                    else
                    {
                        Alimento alimentoFormInPanel = panel1.Controls.OfType<Alimento>().FirstOrDefault();
                        if (alimentoFormInPanel != null)
                        {
                            alimentoFormInPanel.chkentrada.Checked = false;
                            alimentoFormInPanel.chkplatofuerte.Checked = false;
                            alimentoFormInPanel.chkpostre.Checked = false;
                            alimentoFormInPanel.chkentrada.Checked = false;
                        }

                    }

                }
            }
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (dtgelementos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pregunta al usuario si está seguro de eliminar la fila
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la fila seleccionada?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                DataGridViewRow filaSeleccionada = dtgelementos.SelectedRows[0];
                var idCelda = filaSeleccionada.Cells[0].Value;
                var tablaCelda = filaSeleccionada.Cells[3].Value;
                string tabla = string.Empty;
                switch (tablaCelda)
                {

                    case "Bebida":
                        tabla = "Bebidas";
                        break;
                    case "Alimento":
                        tabla = "Platillos";
                        break;

                }
                int id = Convert.ToInt16(idCelda);

                try
                {
                    Conexion.Abrir();
                    string comandoSql = "Delete from " + tabla + " where id = @id";
                    MySqlCommand comando = new MySqlCommand(comandoSql, Conexion.con);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();


                }
                finally
                {
                    Conexion.Cerrar();
                    imprimirDatos(tabla);
                }

            }
        }



        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda y eliminar espacios en blanco al inicio y al final
            string textoBuscar = txtbuscar.Text.Trim();

            // Validar el texto de búsqueda
            if (string.IsNullOrEmpty(textoBuscar))
            {
                // Si el texto de búsqueda está vacío, mostrar todos los datos
                imprimirDatos(); // Método para cargar todos los datos
            }
            else
            {
                // Realizar la búsqueda en la base de datos
                buscarEnBaseDeDatos(textoBuscar);
            }
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            btnbuscar_Click(sender, e); // Llama al método de búsqueda cuando cambia el texto
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txtnombreelemento_TextChanged(object sender, EventArgs e)
        {

        }
        private void buscarEnBaseDeDatos(string textoBuscar)
        {

            try
            {
                Conexion.Abrir();


                string consulta = @"
                (SELECT 'Platillo' AS Tipo, ID, Nombre, Precio, caracteristica, Descripcion 
                 FROM Platillos 
                 WHERE CONCAT_WS(' ', Nombre, Precio, Tipo, caracteristica, Descripcion) LIKE @TextoBuscar)
                UNION ALL
                (SELECT 'Bebida' AS Tipo, ID, Nombre, Precio,  caracteristica, Descripcion 
                 FROM Bebidas 
                 WHERE CONCAT_WS(' ', Nombre, Precio, Tipo, caracteristica, Descripcion) LIKE @TextoBuscar)";

                using (MySqlCommand comando = new MySqlCommand(consulta, Conexion.con))
                {
                    comando.Parameters.AddWithValue("@TextoBuscar", "%" + textoBuscar + "%");

                    // Depuración: Verificar la consulta SQL
                    Console.WriteLine("Consulta SQL: " + consulta);
                    Console.WriteLine("Texto de búsqueda: " + textoBuscar);
                    //messi
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable resultados = new DataTable();
                    adaptador.Fill(resultados);

                    // Depuración: Verificar el número de filas obtenidas
                    Console.WriteLine("Número de filas obtenidas: " + resultados.Rows.Count);

                    // Asignar los resultados al DataGridView
                    dtgelementos.DataSource = resultados;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
            finally
            {
                Conexion.Cerrar();
            }


        }

        private void btncambiaractivo_Click(object sender, EventArgs e)
        {
            if (dtgelementos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para cambiar el estado de activo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dtgelementos.SelectedRows[0];
            int id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
            int estadoActual = Convert.ToInt32(filaSeleccionada.Cells["Activo"].Value);

            // Determinar el nuevo estado
            int nuevoEstado = estadoActual == 0 ? 1 : 0;

            // Actualizar la columna en el DataGridView
            filaSeleccionada.Cells["Activo"].Value = nuevoEstado;

            try
            {
                // Actualizar el estado en la base de datos
                Conexion.Abrir();
                string consulta = "UPDATE " + (filaSeleccionada.Cells["Tipo"].Value.ToString() == "Bebida" ? "Bebidas" : "Platillos") + " SET Activo = @NuevoEstado WHERE ID = @ID";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                comando.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado: " + ex.Message);
            }
            finally
            {
                Conexion.Cerrar();
            }
            MessageBox.Show("Se guardo el cambio correctamente");
        }
    }

}
