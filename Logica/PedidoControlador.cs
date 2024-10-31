using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PollosHermanosRP.Logica
{
    using System.Diagnostics;
    using System.Diagnostics.Metrics;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms.VisualStyles;

    public class PedidoControlador
    {
        string cliente = "";
        string mesa = "";

        public static int GuardarPedido(DataGridView dgvPedido,int mesero, string cliente, int mesa, decimal  total)
        {
            cliente = cliente ?? "";
           

            int pedidoId = 0;
            
            string jsonString = "";


            try
            {
                jsonString = GenerarJsonPedido(dgvPedido);

               

                Conexion.Abrir();
                string query = "INSERT INTO pedido (NumeroMesa, Cliente, fecha,mesero, detallesPedido, total_a_pagar)VALUES (@Mesa, @Cliente, @Fecha,@mesero, @Detalles,@total); SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.con))
                {
                    cmd.Parameters.AddWithValue("@Mesa", mesa);
                    cmd.Parameters.AddWithValue("@Cliente", cliente);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Detalles", jsonString);
                    cmd.Parameters.AddWithValue("@mesero", mesero);
                    cmd.Parameters.AddWithValue("@total", total);


                pedidoId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                MessageBox.Show("Pedido guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pedido KARNAL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Cerrar();
            }

            return pedidoId;
        }

        public static decimal CalcularTotal(DataGridView dgvPedido)
        {
             decimal total = 0;

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Extraer el valor de la celda como string
                    string precioStr = row.Cells[4].Value.ToString();
                    string cantidadStr = row.Cells["Cantidad"].Value.ToString();

                    // Eliminar símbolos de moneda y convertir a decimal
                    decimal precio = Convert.ToDecimal(precioStr.Replace("$", ""), CultureInfo.InvariantCulture);
                    int cantidad = Convert.ToInt32(cantidadStr, CultureInfo.InvariantCulture);

                    total += precio * cantidad;
                    Debug.WriteLine($"Fila: Precio={precio}, Cantidad={cantidad}, Subtotal={precio * cantidad}, TOTAL={total}");
                }
            }
            return total;
        }


        private static string GenerarJsonPedido(DataGridView dgvPedido)
        {
            List<object> items = new List<object>();

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Obtén el valor de la celda como cadena
                    string precioString = row.Cells["Precio"].Value.ToString();

                    // Limpiar el valor para eliminar caracteres no numéricos
                    precioString = precioString.Replace("$", "").Replace(",", "").Trim();

                    // Convertir el valor limpio a decimal
                    decimal precio;
                    bool conversionSuccess = Decimal.TryParse(precioString, NumberStyles.Number, CultureInfo.InvariantCulture, out precio);

                    if (!conversionSuccess)
                    {
                        // Manejar el error de conversión
                        MessageBox.Show($"Error al convertir el precio '{precioString}' en la fila '{row.Index}'.", "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue; // O manejar de otra manera si es necesario
                    }

                    items.Add(new
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        Nombre = row.Cells["Nombre"].Value.ToString(),
                        Precio = precio,
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value)
                    });
                }
            }
            return JsonConvert.SerializeObject(items);
        }

       


    }

}
