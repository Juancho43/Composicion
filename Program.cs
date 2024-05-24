using Composicion;
using Composicion.Model;
AppStatic.InstanciarTodo();
List<Transport> transports = AppStatic.Transports;
foreach (Transport transport in transports){
    Console.WriteLine("Vehiculo: " + transport.Deliver("Miramar","Yerba mate"));
}
