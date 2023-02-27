using System.Security.Cryptography;
using System.Transactions;

class logica
{
    public void ejercisio1()
    {
        // Escribir un programa que pregunte al usuario su nombre, y luego lo salude.
        Console.WriteLine("escribe tu nocmbre");
        String nombre = Console.ReadLine();
        Console.WriteLine("hola " + nombre);
        Console.ReadKey();

    }
    public void ejercisio2()
    {
        /*Ejercicio 2
        Calcular el perímetro y área de un rectángulo dada su base y su altura.
        Perímetro = 2x (base + altura)
        Área = base x altura
        */
        Console.WriteLine("escribe la base");
        double baseR =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escribe la altura");
        double altura = Convert.ToInt32(Console.ReadLine());
        double perimetro = 2 * (baseR + altura);
        double area = baseR * altura;
        Console.WriteLine();
        Console.WriteLine("el perimetro es:" + perimetro + " el area es: " + area);
       
    }
    public void ejercisio3()
    {
        /*Ejercicio 3
        Dados los catetos de un triángulo rectángulo, calcular su hipotenusa.
        c = √(a² + b²)
        c = √(3² + 4²) = √(9 + 16) = √25 = 5
        */
        double cateto1 = 3;
        double cateto2 = 4;
        cateto1 = Math.Pow(cateto1, 2);
        cateto2 = Math.Pow(cateto2, 2);
        double hipotenusa = Math.Sqrt(cateto1 + cateto2);
        Console.WriteLine("la hipotenusa es:" + hipotenusa);
        Console.ReadKey();
    }
    public void ejercisio4(){

        /*
        Ejercicio 4
        Dados dos números, mostrar la suma, resta, división y multiplicación de ambos.
        */
        double valor1 = 5;
        double valor2 = 6;

        double suma = valor1 + valor2;
        double resta = valor1 - valor2;
        double division = valor1 / valor2;
        double multiplicacion = valor1 * valor2;
        Console.WriteLine("la suma es: " + suma + " la resta es: " + resta + " la division es: " + division + " la multiplicacion es: " +
                            multiplicacion);
        Console.ReadKey();
}
    public void ejercisio5()
    {
        /* Ejercicio 5
     Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius. Recordar que la fórmula para la conversión es:
            C = (F-32)*5/9 
            68 grados Fahrenheit son equivalentes a 20 grados Celsius.
        */

        double gradosFarenheit = 68;
        double gradosCelcius = (gradosFarenheit - 32) * 5 / 9;
        Console.WriteLine("Los grados Celsius son: " + gradosCelcius );
        Console.ReadKey ();

    }

    public void ejercisio6()
    {
        //Ejercicio 6
        // Calcular la media de tres números pedidos por teclado.
        Console.WriteLine("ingrese un valor numerico entero (1)");

        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese un valor numerico entero (2)");

        int valor2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese un valor numerico entero (3)");

        int valor3 = Convert.ToInt32(Console.ReadLine());

        int medio = (valor1 + valor2+ valor3) / 3;
        Console.WriteLine("la media es: " + medio);
        Console.ReadKey();
    }

    public void ejercisio7()
    {
        //Realiza un programa que reciba una cantidad de minutos y muestre por pantalla
        //a cuantas horas y minutos corresponde. Por ejemplo: 1000 minutos son 16 horas y 40 minutos.
        int minutos = 1000 ;
        int horas = minutos / 60;
        int minutosRestantes = minutos % 60;
        Console.WriteLine("Las horas son: " + horas + " los minutos: " + minutosRestantes);
        Console.ReadKey();

    } 

    public void ejercisio8()
    {
        /*Ejercicio 8
        Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas,
        el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes
        y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones.
        */

        double sueldo = 7000;
        double ventas = 5000;
        double comision= ventas * .1;
        Console.WriteLine("el sueldo total es:" + (sueldo + comision));
        Console.WriteLine("el sueldo base es: " + sueldo);
        Console.ReadKey();

    }

    public void ejercisio9()
    {
        //Una tienda ofrece un descuento del 15% sobre el total de la compra
        //y un cliente desea saber cuánto deberá pagar finalmente por su compra.

        double compra = 3000;
        double descuento = 500 * .15;
        Console.WriteLine("el total a pagar es de:" + (compra - descuento));
        Console.ReadKey();
    }

    public void ejercisio10()
    {
        /*Un alumno desea saber cuál será su calificación final en la materia de Algoritmos.
         * Dicha calificación se compone de los siguientes porcentajes:

            55% del promedio de sus tres calificaciones parciales.
            30% de la calificación del examen final.
            15% de la calificación de un trabajo final.
        */

        double cali1 =10 ;
        double cali2 = 8;
        double cali3 = 9;
        double calificacionParcial = (cali1 + cali2 + cali3) / 3;
        double Promedio = calificacionParcial * 0.55;
        double ExamenFinal = 7;
        double PorcentajeExamen = ExamenFinal * .30;
        double trabajoFinal = 9;
        double PorcentajeTrabajo = trabajoFinal * .15;
        double calificacionFinal = Promedio + PorcentajeExamen + PorcentajeTrabajo;
        Console.WriteLine("tu calificacion Final es: " + calificacionFinal);
        Console.ReadKey();
    }
    static void Main(String[] args)
{
logica obj= new logica(); //instancia de clase, sirve para llamar a la clase 

        //obj.ejercisio1();

        // obj.ejercisio2();

       //  obj.ejercisio3();

       //  obj.ejercisio4();

       //  obj.ejercisio5();

       //  obj.ejercisio6();
       // obj.ejercisio7();
       // obj.ejercisio8();
       // obj.ejercisio9();
        //obj.ejercisio10();
    }
}