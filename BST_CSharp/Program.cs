using System;

class Program
{
    static void Main(string[] args)
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENU BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Mostrar recorridos");
            Console.WriteLine("5. Minimo y Maximo");
            Console.WriteLine("6. Altura");
            Console.WriteLine("7. Limpiar arbol");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Insertar(valor);
                    break;

                case 2:
                    Console.Write("Buscar valor: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(valor) ? "Existe" : "No existe");
                    break;

                case 3:
                    Console.Write("Eliminar valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Eliminar(valor);
                    break;

                case 4:
                    Console.WriteLine("Inorden:");
                    arbol.Inorden();
                    Console.WriteLine("Preorden:");
                    arbol.Preorden();
                    Console.WriteLine("Postorden:");
                    arbol.Postorden();
                    break;

                case 5:
                    Console.WriteLine("Minimo: " + arbol.Minimo());
                    Console.WriteLine("Maximo: " + arbol.Maximo());
                    break;

                case 6:
                    Console.WriteLine("Altura: " + arbol.Altura());
                    break;

                case 7:
                    arbol.Limpiar();
                    Console.WriteLine("Arbol limpiado");
                    break;
            }

        } while (opcion != 0);
    }
}