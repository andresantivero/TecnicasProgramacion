using System;

namespace ejerciciosSemanaUno
{
    class Program
    {
        static int Mensaje()
        {
            /*Mensaje de consulta por ejercicio*/

            int numero;
            Console.WriteLine("Elija del 1 al 5 el ejercicio que desea ver y 0 para cerrar");            
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            return numero;

        }

        static void Main(string[] args)
        {
            /*Tramo I – Semana 1
            Ejercicios:
            Resolver con los algoritmos necesarios, los siguientes ejercicios:
            1.	Dadas las horas mensuales trabajadas de un empleado y el valor en pesos de cada hora,
            calcular el sueldo que se abonará al finalizar el mes.
            2.	Elaborar un algoritmo que lea los 3 lados de un triángulo cualquiera y 
            calcule su perímetro considerando A, B y C como lados. 
            3.	Una maratón tiene 26 millas y 385 yardas. Sabiendo que una milla tiene 1760 yardas,
            calcular la distancia de la maratón en kilómetros. 
            4.	Una empresa comercializa 3 productos y desea saber cuál es el que le da mayor 
            porcentaje de ventas. Para esto debe ingresar el total recaudado por cada producto y 
            el valor de cada uno. Tener en cuenta que el programa debe informar la cantidad vendida 
            de cada producto, y su total de ventas y el porcentaje que dicha cantidad de ventas 
            significa del total.  
            5.	Una familia de 4 personas desea irse de viaje. Para esto deben tener en cuenta
            lo siguiente: a) Precio de pasajes aéreos. b) Precio de un hotel por noche. 
            c) Cantidad de noches. d) Alquiler de un auto (precio por día). 
            El programa debe calcular el total que saldrá el viaje, teniendo en cuenta que
            el alquiler del auto será por la mitad de la estadía
            */

            /*declaracion de variables*/

            int codigo;
            float valorHora, horasTrabajadas, trianguloLadoA, trianguloLadoB, trianguloLadoC, totalVentaProductoUno, totalVentaProductoDos, totalVentaProductoTres, valorProductoUno,valorProductoDos, valorProductoTres, cantidadProductoUno, cantidadProductoDos, cantidadProductoTres, cantidadProductoTotal, precioPasajes, precioHotelNoche, precioAlquilerAuto, totalViaje, cantidadNoches;


            codigo = Mensaje();
            
            /*ciclo repetitivo para hacer los ejercicios*/

            while (codigo != 0)
            {

                if (codigo == 1)
                {
                    Console.WriteLine("Dadas las horas mensuales trabajadas de un empleado y el valor en pesos de cada hora, calcular el sueldo que se abonará al finalizar el mes.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese la cantidad de horas trabajadas");
                    horasTrabajadas = float.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el valor de la hora");
                    valorHora = float.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("El sueldo mensual del trabajador es de: " + (horasTrabajadas * valorHora));
                    Console.WriteLine(" ");
                    codigo = Mensaje();
                }
                else if (codigo == 2)
                {
                    Console.WriteLine("Elaborar un algoritmo que lea los 3 lados de un triángulo cualquiera y calcule su perímetro considerando A, B y C como lados.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el primer lado");
                    trianguloLadoA = float.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el segundo lado");
                    trianguloLadoB = float.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el tercer lado");
                    trianguloLadoC = float.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("El perimetro del triangulo es: " + (trianguloLadoA + trianguloLadoB + trianguloLadoC));
                    Console.WriteLine(" ");
                    codigo = Mensaje();

                } else if (codigo == 3)
                {
                    Console.WriteLine("Una maratón tiene 26 millas y 385 yardas. Sabiendo que una milla tiene 1760 yardas, calcular la distancia de la maratón en kilómetros.");
                    Console.WriteLine(" ");
                    Console.WriteLine("La distancia de la maraton en kilometros es: " + (((26 * 1760) + 385) * 0.0009144));
                    Console.WriteLine(" ");
                    codigo = Mensaje();

                } else if (codigo == 4)
                {
                    Console.WriteLine("Una empresa comercializa 3 productos y desea saber cuál es el que le da mayor porcentaje de ventas. Para esto debe ingresar el total recaudado por cada producto y el valor de cada uno. Tener en cuenta que el programa debe informar la cantidad vendidade cada producto, y su total de ventas y el porcentaje que dicha cantidad de ventas significa del total.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese la venta total del producto 1");
                    totalVentaProductoUno = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del producto 1");
                    valorProductoUno = float.Parse(Console.ReadLine());
                    cantidadProductoUno = totalVentaProductoUno / valorProductoUno;
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese la venta total del producto 2");
                    totalVentaProductoDos = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del producto 2");
                    valorProductoDos= float.Parse(Console.ReadLine());
                    cantidadProductoDos = totalVentaProductoDos / valorProductoDos;
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese la venta total del producto 3");
                    totalVentaProductoTres = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del producto 3");
                    valorProductoTres = float.Parse(Console.ReadLine());
                    cantidadProductoTres = totalVentaProductoTres / valorProductoTres;
                    cantidadProductoTotal = cantidadProductoUno + cantidadProductoDos + cantidadProductoTres;
                    Console.WriteLine(" ");
                    Console.WriteLine("El total de Productos vendidos es: " + cantidadProductoTotal);
                    Console.WriteLine(" ");
                    Console.WriteLine("El producto 1 vendio " + cantidadProductoUno + " unidades y representa el " + ((cantidadProductoUno * 100) / cantidadProductoTotal) + "% de las ventas");
                    Console.WriteLine(" ");
                    Console.WriteLine("El producto 2 vendio " + cantidadProductoDos + " unidades y representa el " + ((cantidadProductoDos * 100) / cantidadProductoTotal) + "% de las ventas");
                    Console.WriteLine(" ");
                    Console.WriteLine("El producto 3 vendio " + cantidadProductoTres + " unidades y representa el " + ((cantidadProductoTres * 100) / cantidadProductoTotal) + "% de las ventas");
                    Console.WriteLine(" ");
                    codigo = Mensaje();
                } else if(codigo == 5)
                {
                    totalViaje = 0;
                    Console.WriteLine("Una familia de 4 personas desea irse de viaje. Para esto deben tener en cuenta lo siguiente: a) Precio de pasajes aéreos. b) Precio de un hotel por noche. c) Cantidad de noches.d) Alquiler de un auto(precio por día). El programa debe calcular el total que saldrá el viaje, teniendo en cuenta que el alquiler del auto será por la mitad de la estadía");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el precio unitario del pasaje");
                    precioPasajes = float.Parse(Console.ReadLine());
                    totalViaje += precioPasajes * 4;
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese la cantidad de noches");
                    cantidadNoches = float.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el precio del hotel por noche");
                    precioHotelNoche = float.Parse(Console.ReadLine());
                    totalViaje += precioHotelNoche * cantidadNoches;
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el precio del auto por dia");
                    precioAlquilerAuto = float.Parse(Console.ReadLine());
                    totalViaje += precioAlquilerAuto * (cantidadNoches / 2);
                    Console.WriteLine(" ");
                    Console.WriteLine("El total gastado en el viaje es: " + totalViaje);
                    Console.WriteLine(" ");
                    Mensaje();
                } else
                {
                    Console.WriteLine("Ha ingresado un valor invalido.");
                    Console.WriteLine(" ");
                    Mensaje();
                }
            }
            Console.WriteLine("Se ha cerrado el programa.");
        }
    }
}
