using Reflexion;

Type tipo = typeof(int);

int edad = 999;

Type tipiDatoEdad = edad.GetType();

Type tipoDeDatoSystemInt32 = Type.GetType("System.int32")!;

Console.WriteLine($"¿Es {tipo.Name} un arreglo? {tipo.IsArray}");

Console.WriteLine($"El valoe maximo de un entero es(sin reflexion): {int.MaxValue}");

var valor = tipo.GetField("MaxValue")!.GetValue(default(int));

Console.WriteLine($"El valoe maximo de un entero es(con reflexion): {valor}");


//instanciando una clase por el tipo

var tipo2 = typeof(Persona);
var personaSinNombreViaType = (Persona)Activator.CreateInstance(tipo2)!;

Console.WriteLine("persona instanciada por el type" + personaSinNombreViaType);


var personaConNombreViaType = (Persona)Activator.CreateInstance(typeof(Persona),
    new object[] { "Felipe" })!;

Console.WriteLine("El nombre de la persona es " + personaConNombreViaType.Nombre);

//invocando Metodos

var tipo4 = typeof(Utilidades);
var utiliades = Activator.CreateInstance(tipo4);

tipo4.InvokeMember("ImprimirHoraActual", System.Reflection.BindingFlags.InvokeMethod,
    binder: null, target :utiliades, args: new object[] { });

//ejemplo 2

tipo.InvokeMember("ImprimirMensaje", System.Reflection.BindingFlags.InvokeMethod,
    binder: null, target: utiliades, args: new object[] { "Usando reflexion" });


