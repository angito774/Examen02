using Examen02.Clase;
using Examen02.Interfaces;

List<EmpleadoBase> empleados = new List<EmpleadoBase>();

char option;
do
{
	Console.WriteLine(" ** Menú Principal **");
	Console.WriteLine("1) Ingresar Empleado");
	Console.WriteLine("2) Mostrar Listado Empleado");
	Console.WriteLine("3) Presione S para salir");
	Console.Write("Seleccione una opción: ");
	option = Console.ReadKey().KeyChar;
	Console.WriteLine();
	Console.Clear();

	switch (option)
	{
		case '1':
			IngresarEmpleado();
			break;
		case '2':
			MostrarListado();
			break;
		case 'S':
			Console.WriteLine("Saliendo...");
			break;
		case 's':
			Console.WriteLine("Saliendo...");
			break;
		default:
			Console.WriteLine("Opción no válida. Intente de nuevo.");
			break;
	}
} while (option != 'S' && option != 's');


void IngresarEmpleado()
{
	//Gerente gerente = new Gerente(); Desarollador desarollador = new Desarollador(); GerenteRRHH gerenterrhh = new GerenteRRHH(); ConsultorExterno consultor = new ConsultorExterno();

	char option;
	Console.WriteLine("Seleccione el Tipo de Empleado a Ingresar:");
	Console.WriteLine("1) Gerente");
	Console.WriteLine("2) Desarrollador");
	Console.WriteLine("3) Gerente RRHH");
	Console.WriteLine("4) Consultor Externo");
	option = Console.ReadKey().KeyChar;
	Console.WriteLine();


	EmpleadoBase nuevoEmpleado = null;
	switch (option)
	{
		case '1':
			nuevoEmpleado = new Gerente();
			break;
		case '2':
			nuevoEmpleado = new GerenteRRHH();
			break;
		case '3':
			nuevoEmpleado = new Desarollador();
			break;
		case '4':
			nuevoEmpleado = new ConsultorExterno();
			break;
		default:
			Console.WriteLine("Tipo de empleado no válido. Inténtelo de nuevo.");
			return;
	}

	Console.WriteLine("Ingrese Id Empleado: ");
	nuevoEmpleado.IdEmpleado = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Ingrese Nombre Empleado: ");
	nuevoEmpleado.Nombre = Console.ReadLine();
	Console.WriteLine("Ingrese Puesto Empleado: ");
	nuevoEmpleado.Puesto = Console.ReadLine();

	empleados.Add(nuevoEmpleado);
}

void MostrarListado()
{
	double sumnewsueldo = 0;
	foreach (var empleado in empleados)
	{
		var newsueldo = empleado.CalcularSueldo();
		empleado.MostrarDetalle();
		Console.WriteLine("Nuevo Sueldo es: " + newsueldo.ToString());

		if (empleado is ISueldoBonificable empleadoBonificable)
		{
			var bono = empleadoBonificable.CalcularBonificacion();
			Console.WriteLine("La Bonificacion del Empleado es: " + bono.ToString());
		}
		if (empleado is IDescuentoImpuesto empleadoDescuento)
		{
			var desc = empleadoDescuento.DescontarSueldo();
			Console.WriteLine("Descuento del Empleado es: " + desc.ToString());
		}
		Console.WriteLine("****************************************************");
		sumnewsueldo += newsueldo;
	}
	Console.WriteLine("**** Resumen Planilla ******************");
	Console.WriteLine("Total de Empleados: " + empleados.Count());
	Console.WriteLine("Suma Total Sueldos: " + sumnewsueldo.ToString());

}

