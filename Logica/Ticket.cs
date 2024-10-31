using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;

namespace PollosHermanosRP.Logica
{
    class Ticket
    {
        public int PedidoID { get; set; }
        public int NumeroMesa { get; set; }
        public string Cliente { get; set; }
        public List<ItemConsumido> Items { get; set; }
        public decimal TotalAPagar { get; set; }
        public string MetodoDePago { get; set; }

        public string Mesero { get; set; }
        public DateTime FechaHora { get; set; }


        public static Ticket GenerarTicket(int pedidoID)
        {
            Ticket ticket = new Ticket();
            ticket.Items = new List<ItemConsumido>();

            using (var connection = new MySqlConnection(Conexion.conexion))
            {
                connection.Open();

                var cmdPedido = new MySqlCommand(@"
            SELECT p.ID, p.NumeroMesa, p.Total_a_pagar, p.Metodo_de_pago, f.Nombre as Mesero, p.detallesPedido
            FROM Pedido p 
            JOIN FUNCIONARIO f ON p.Mesero = f.ID 
            WHERE p.ID = @pedidoID", connection);
                cmdPedido.Parameters.AddWithValue("@pedidoID", pedidoID);

                using (var reader = cmdPedido.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ticket.PedidoID = reader.GetInt32("ID");
                        ticket.NumeroMesa = reader.GetInt32("NumeroMesa");
                        ticket.TotalAPagar = reader.GetDecimal("Total_a_pagar");
                        ticket.MetodoDePago = reader.GetString("Metodo_de_pago");
                        ticket.Mesero = reader.GetString("Mesero");

                        // Procesar el JSON de detallesPedido
                        string detallesPedidoJson = reader.GetString("detallesPedido");
                        ProcessDetallesPedido(detallesPedidoJson, ticket, connection);
                    }
                }
            }

            return ticket;
        }
        private static void ProcessDetallesPedido(string detallesPedidoJson, Ticket ticket, MySqlConnection connection)
        {
            var detalles = JsonConvert.DeserializeObject<List<DetalleItem>>(detallesPedidoJson);

            foreach (var detalle in detalles)
            {
                string query = detalle.tipo == "producto"
                    ? "SELECT Nombre, Precio FROM Platillos WHERE ID = @id"
                    : "SELECT Nombre, Precio FROM Bebidas WHERE ID = @id";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", detalle.id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ticket.Items.Add(new ItemConsumido
                            {
                                Nombre = reader.GetString("Nombre"),
                                Precio = reader.GetDecimal("Precio"),
                                Cantidad = detalle.cantidad
                            });
                        }
                    }
                }
            }
        }

        public class DetalleItem
        {
            public int id { get; set; }
            public string tipo { get; set; }
            public int cantidad { get; set; }
        }


        public static void GuardarTicketComoJson(Ticket ticket)
        {
            string ticketDirectory = obtenerDirectorio();

            // Asegurarse de que el directorio exista
            if (!Directory.Exists(ticketDirectory))
            {
                Directory.CreateDirectory(ticketDirectory);
            }

            string nombreArchivo = Path.Combine(ticketDirectory, $"Ticket_{ticket.PedidoID.ToString()}_{ticket.Mesero}.json");

            string jsonTicket = JsonConvert.SerializeObject(ticket, Formatting.Indented);
            File.WriteAllText(nombreArchivo, jsonTicket);
            MessageBox.Show("Archivo Guardado");
        }

        public void ImprimirTicket(Ticket ticket)
        {
            Console.WriteLine("========== Pollos Hermanos ==========");
            Console.WriteLine($"Pedido: {ticket.PedidoID}");
            Console.WriteLine($"Mesa: {ticket.NumeroMesa}");
            Console.WriteLine($"Cliente: {ticket.Cliente}");
            Console.WriteLine($"Mesero: {ticket.Mesero}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Artículo                      Precio");
            Console.WriteLine("-------------------------------------");
            foreach (var item in ticket.Items)
            {
                Console.WriteLine($"{item.Nombre.PadRight(30)} ${item.Precio}");
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Total a pagar:               ${ticket.TotalAPagar}");
            Console.WriteLine($"Método de pago: {ticket.MetodoDePago}");
            Console.WriteLine("======== Gracias por su visita ======");
        }
        private static string obtenerDirectorio()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return Path.Combine(desktopPath, "PollosHermanosHub", "PollosHermanosRp", "Logica","Tickets");
        }
    }
}
