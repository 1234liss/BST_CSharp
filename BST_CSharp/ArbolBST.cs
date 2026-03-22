using System;

public class ArbolBST
{
    public Nodo Raiz;

    public ArbolBST()
    {
        Raiz = null;
    }

    // INSERTAR
    public void Insertar(int valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);

        return nodo;
    }

    // BUSCAR
    public bool Buscar(int valor)
    {
        return BuscarRecursivo(Raiz, valor);
    }

    private bool BuscarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null)
            return false;

        if (valor == nodo.Valor)
            return true;

        if (valor < nodo.Valor)
            return BuscarRecursivo(nodo.Izquierdo, valor);
        else
            return BuscarRecursivo(nodo.Derecho, valor);
    }

    // MINIMO
    public int Minimo()
    {
        Nodo actual = Raiz;
        while (actual.Izquierdo != null)
            actual = actual.Izquierdo;

        return actual.Valor;
    }

    // MAXIMO
    public int Maximo()
    {
        Nodo actual = Raiz;
        while (actual.Derecho != null)
            actual = actual.Derecho;

        return actual.Valor;
    }

    // ALTURA
    public int Altura()
    {
        return AlturaRecursiva(Raiz);
    }

    private int AlturaRecursiva(Nodo nodo)
    {
        if (nodo == null)
            return -1;

        int izquierda = AlturaRecursiva(nodo.Izquierdo);
        int derecha = AlturaRecursiva(nodo.Derecho);

        return Math.Max(izquierda, derecha) + 1;
    }

    // RECORRIDOS
    public void Inorden()
    {
        InordenRecursivo(Raiz);
        Console.WriteLine();
    }

    private void InordenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            InordenRecursivo(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            InordenRecursivo(nodo.Derecho);
        }
    }

    public void Preorden()
    {
        PreordenRecursivo(Raiz);
        Console.WriteLine();
    }

    private void PreordenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            PreordenRecursivo(nodo.Izquierdo);
            PreordenRecursivo(nodo.Derecho);
        }
    }

    public void Postorden()
    {
        PostordenRecursivo(Raiz);
        Console.WriteLine();
    }

    private void PostordenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            PostordenRecursivo(nodo.Izquierdo);
            PostordenRecursivo(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }

    // ELIMINAR
    public void Eliminar(int valor)
    {
        Raiz = EliminarRecursivo(Raiz, valor);
    }

    private Nodo EliminarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null)
            return nodo;

        if (valor < nodo.Valor)
            nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = EliminarRecursivo(nodo.Derecho, valor);
        else
        {
            if (nodo.Izquierdo == null)
                return nodo.Derecho;
            else if (nodo.Derecho == null)
                return nodo.Izquierdo;

            nodo.Valor = MinimoNodo(nodo.Derecho);
            nodo.Derecho = EliminarRecursivo(nodo.Derecho, nodo.Valor);
        }

        return nodo;
    }

    private int MinimoNodo(Nodo nodo)
    {
        int min = nodo.Valor;
        while (nodo.Izquierdo != null)
        {
            min = nodo.Izquierdo.Valor;
            nodo = nodo.Izquierdo;
        }
        return min;
    }

    // LIMPIAR
    public void Limpiar()
    {
        Raiz = null;
    }
}