// See https://aka.ms/new-console-template for more information
/*using DataStructures.Poly;
InstagramAccount tomas = new InstagramAccount("Tomas", 26);
InstagramAccount elizabeth = new InstagramAccount("Elizabeth", 22);
InstagramAccount jonathan = new InstagramAccount("Jonathan", 26);

List<InstagramAccount> usuarios = new List<InstagramAccount>();

usuarios.Add(tomas);
usuarios.Add(elizabeth);
usuarios.Add(jonathan);

tomas.agregarComentario("primer posteo");
tomas.agregarComentario("segunDOOOO posteo");
tomas.agregarComentario("que onda amigos de yt");

tomas.mostrarComentarios();
tomas.GetId();
*/

//------------------------------------------------- LINEAR SEARCH -----------------------------------------------------

/*

int[] arreglo = new int[10];
for (int i = 0; i < arreglo.Length; i++)
{
    arreglo[i] = i;
}

Console.WriteLine(BusquedaLineal(arreglo, 4));

bool BusquedaLineal(int[] arreglo, int busqueda)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        if (arreglo[i] == busqueda)
        {
            return true;
        }
    }
    return false;
}

*/



//------------------------------------------------- LINKED LIST -----------------------------------------------------

/*
using DataStructures.LinkedList;

Node node1 = new Node();
Node node2 = new Node();
Node node3 = new Node();
Node node4 = new Node();
Node node5 = new Node();
Node node6 = new Node();
node1.Data = 1;
node1.Next = node2;
node2.Data = 2;
node2.Next = node3;
node3.Data = 3;
node3.Next = node4;
node4.Data = 4;
node4.Next = node5;
node5.Data = 5;
node5.Next = node6;
node6.Data = 6;

LinkedList lista = new LinkedList();
lista.Head = node1;
lista.InsertFirst(54);
lista.InsertLast(123);
lista.DeleteFirst();
lista.DeleteLast();
lista.IterateThrough();

*/

//------------------------------------------------- STACK -----------------------------------------------------

/*

using DataStructures.Stack;

Stack stack = new Stack(10);
Console.WriteLine(stack.Peek());

int control = 1;
while (!stack.isFull())
{
    stack.Push($"{control}");
    Console.WriteLine(stack.Peek());
    control++;
}
Console.WriteLine("--------------------");

while (stack.Peek() != $"{5}")
{
    stack.Pop();
}
Console.WriteLine(stack.Peek());

*/

//------------------------------------------------- QUEUE -----------------------------------------------------

/*
using DataStructures.Queue;

Queue queue = new Queue(10);

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);
queue.Enqueue(7);
queue.Enqueue(8);

queue.Dequeue();
queue.Dequeue();
Console.WriteLine(queue.Peek());
*/

//------------------------------------------------- BINARY SEARCH -----------------------------------------------------


/*


int[] arreglo = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

Console.WriteLine(BinarySearch(arreglo, 4));

bool BinarySearch(int[] arreglo, int item)
{
    int start = 0;
    int end = arreglo.Length -1;

    while (start <= end)
    {
        int midPoint = (start + end) / 2;
        Console.WriteLine(arreglo[midPoint]);
        if (arreglo[midPoint] == item)
        {
            return true;
        }else if (arreglo[midPoint] < item)
        {
            start = midPoint +1;
        }
        else
        {
            end = midPoint -1;
        }
    }
    return false;
}

int BinaryRecursion(int[] arreglo, int item, int start, int end)
{

    int midPoint = (start + end) / 2;
    if (arreglo[midPoint] == item)
    {
        return midPoint;
    }
    else
    {
        if (arreglo[midPoint] < item)
        {
            Console.WriteLine(arreglo[midPoint]);
            return BinaryRecursion(arreglo, item, midPoint +1, end);
        }
        else if(arreglo[midPoint] > item)
        {
            Console.WriteLine(arreglo[midPoint]);
            return BinaryRecursion(arreglo, item, end, midPoint -1);
        }
        else
        {
            return -1;
        }
    }
}
*/

/*

int[] Achicar(int[] arreglo, int start, int end)
{
    int control = 0;

    for (int i = 0; i < arreglo.Length; i++)
    {
        if (i >= start && i <= end)
        {
            control++;
        }
    }

    int[] listaCorta = new int[control];

    control = 0;

    for (int i = 0; i < arreglo.Length; i++)
    {
        if (i >= start && i <= end)
        {
            listaCorta[control] = arreglo[i];
            control++;
        }
    }
    return listaCorta;
}

int BinaryRecursion(int[] arreglo, int item)
{

    int midPoint = (0 + arreglo.Length) / 2;

    if (arreglo[midPoint] == item)
    {
        return midPoint;
    }
    else
    {
        if (arreglo[midPoint] < item)
        {

            return BinaryRecursion(Achicar(arreglo,midPoint,arreglo.Length), item);
        }
        else if (arreglo[midPoint] > item)
        {

            return BinaryRecursion(Achicar(arreglo,0, midPoint), item);
        }
        else
        {
            return -1;
        }
    }
}


int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

Console.WriteLine(BinaryRecursion(arreglo, 15));

*/

//------------------------------------------------- BINARY SEARCH -----------------------------------------------------

/*

using DataStructures.BinarySearchTree;

BinarySearchTree tree = new BinarySearchTree();
tree.Insert(0, "tomas");
tree.Insert(4, "elizabeth");
tree.Insert(23, "jonathan");
tree.Insert(5, "alexis");
tree.Insert(124, "alexander");
tree.Insert(12, "angel");
Console.WriteLine(tree.Find(4));


*/

//------------------------------------------------- BUBBLE SORT -----------------------------------------------------

/*

int[] arreglo = { 5,8,7,3,1,72,2,17,6};

var arreglado = BubbleSort(arreglo);

foreach (var item in arreglado)
{
    Console.WriteLine(item);
}


int[] BubbleSort(int[] arreglo)
{
    int temp = 0;

    for (int i = 0; i < arreglo.Length; i++)
    {
        for (int j = 0; j < arreglo.Length -1; j++)
        {
            if (arreglo[j] > arreglo[j + 1])
            {
                temp = arreglo[j + 1];
                arreglo[j + 1] = arreglo[j];
                arreglo[j] = temp;
            }   
        }
    }
    return arreglo;
}

*/

//------------------------------------------------- FACTORIAL -----------------------------------------------------

/*

Console.WriteLine(Factorial(5));
int Factorial(int numero)
{
    if (numero == 0)
    {
        return 1;
    }
    return numero * Factorial(numero - 1);
}

*/



//------------------------------------------------- BASIC BACKTRACKING -----------------------------------------------------

/*

void CalcSubset(List<int> A, List<List<int>> res, List<int> subset, int index)
{
    // Add the current subset to the result list
    res.Add(new List<int>(subset));

    // Generate subsets by recursively including and
    // excluding elements
    for (int i = index; i < A.Count; i++)
    {
        // Include the current element in the subset
        subset.Add(A[i]);

        // Recursively generate subsets with the current
        // element included

        CalcSubset(A, res, subset, i + 1);

        // Exclude the current element from the subset
        // (backtracking)
        subset.RemoveAt(subset.Count - 1);

    }
}

List<List<int>> Subsets(List<int> A)
{
    List<int> subset = new List<int>();
    List<List<int>> res = new List<List<int>>();
    int index = 0;
    CalcSubset(A, res, subset, index);
    return res;
}


List<int> array = new List<int> { 1, 2, 3 };

List<List<int>> res = Subsets(array);

// Print the generated subsets

foreach (List<int> i in res)
{
    Console.Write("{");
    foreach (int numero in i)
    {
        Console.Write(numero);
    }
    Console.WriteLine("}");
}

*/

//------------------------------------------------- GRAPH -----------------------------------------------------

/*

Graph g = new Graph(5);
g.addEdge(0, 1);
g.addEdge(0, 2);
g.addEdge(0, 3);
g.addEdge(1, 3);
g.addEdge(2, 3);
g.addEdge(1, 4);
g.addEdge(2, 4);

int s = 0, d = 3;

// Function call
Console.WriteLine(g.countPaths(s, d));


*/


//------------------------------------------------- TOWER OF HANOI -----------------------------------------------------

/*
using DataStructures.HanoiTower;


int N = 4;

// A, B and C are names of rods 
HanoiTower.towerOfHanoi(N, 'A', 'C', 'B');

*/

//------------------------------------------------- HASH SET PROPIO (PRACTICA) -----------------------------------------------------


/*
using DataStructures.HashTable;

HashTable hash = new HashTable(15);
Console.WriteLine(hash.AddNode("tomas"));
Console.WriteLine(hash.AddNode("elizabet"));
Console.WriteLine(hash.AddNode("giuliana"));
Console.WriteLine(hash.AddNode("tomasss"));
Console.WriteLine(hash.AddNode("tomigay"));
List<Node> resultado = hash.Find(9);

foreach (var item in resultado)
{
    Console.WriteLine(item.Value + " " + item.Key);
}

*/


//------------------------------------------------- STACK (PRACTICA) -----------------------------------------------------

/* DOUBLE STACK */

/*
using DataStructures.Practice.StackAndQueues;

DoubleStack doble = new DoubleStack(5);
doble.Push1("tomas");
doble.Push1("alexander");
doble.Push2("jonathan");
doble.Push2("elizabeth");
doble.Push2("alexis");
doble.Pop1();
doble.Pop2();
doble.Pop2();
doble.Pop1();
doble.Pop1();
doble.Pop1();
doble.Pop2();
doble.Pop2();
Console.WriteLine(doble.Peek1());
Console.WriteLine(doble.Peek2());
*/

/*

using DataStructures.Practice.StackAndQueues;

Stack pila = new Stack(5);
for (int i = 1; i < 6; i++)
{
    pila.Push($"{i}");
}
for (int i = 1; i < 6; i++)
{
    Console.WriteLine(pila.Pop());
}
for (int i = 1; i < 6; i++)
{
    pila.Push($"{i}");
}
Console.WriteLine("-----------------");

Stack pilaInvertida = new Stack(pila.MaxSize);
for (int i = 0; i < pila.MaxSize; i++)
{
    pilaInvertida.Push(pila.Pop());
}

for (int i = 1; i < 6; i++)
{
    Console.WriteLine(pilaInvertida.Pop());
}

*/









/*
using DataStructures.Practice.StackAndQueues;

Stack pila = new Stack(5);
pila.Push("3");
pila.Push("5");
pila.Push("1");
pila.Push("2");
pila.Push("4");

Ordenar(pila);

for (int i = 0; i < pila.MaxSize; i++)
{
    Console.WriteLine(pila.Pop());
}


void Ordenar(Stack pila)
{
    for (int i = 0; i < pila.MaxSize; i++)
    {
        MoverValores(pila, (pila.MaxSize - i));
    }
}

void MoverValores(Stack pila, int tope)
{
    int mayor = 0;
    Stack temporal = new Stack(pila.MaxSize);

    for (int i = 0; i < tope; i++)
    {
        if (int.Parse(pila.Peek()) > mayor)
        {
            mayor = int.Parse(pila.Peek());
        }
        temporal.Push(pila.Pop());
    }

    pila.Push(mayor.ToString());

    for (int i = 0; i < tope; i++)
    {
        if (int.Parse(temporal.Peek()) != mayor)
        {
            pila.Push(temporal.Pop());
        }
        else
        {
            temporal.Pop();
        }
    }
}
*/



//------------------------------------------------- HASHTABLE (lineal probing) -----------------------------------------------------



/*
using DataStructures.Practice.HashTableOpenAdressing;

HashTable tabla = new HashTable(100);

Console.WriteLine(tabla.Add(5421));
Console.WriteLine(tabla.Add(521));
Console.WriteLine(tabla.Add(3421));
Console.WriteLine(tabla.Add(55421));
Console.WriteLine(tabla.Search(3421));

Console.WriteLine(tabla.Search(321));

Console.WriteLine(tabla.Delete(55421));
Console.WriteLine(tabla.Search(55421));
*/

//------------------------------------------------- BACKTRACKING (8 queens problem) -----------------------------------------------------

Initialize();

void Initialize()
{
    int[,] tablero =
    {
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0}
    };

    if (FindSol(tablero,0) == false)
    {
        Console.WriteLine("no existe solucion");
    }
    else
    {
        Imprimir(tablero);
    }


}
bool FindSol(int[,] tablero, int col)
{
    if (col >= 4)
    {
        return true;
    }

    for (int i = 0; i < 4; i++)
    {
        if (isLegal(tablero, i, col))
        {
            tablero[i, col] = 1;
            if (FindSol(tablero, col + 1)) return true;
            tablero[i, col] = 0;
        }
    }
    return false;
}

bool isLegal(int[,] tablero, int row, int col)
{
    if (tablero[row, col] == 1)
    {
        return false;
    }

    for (int i = 0; i < 4; i++)
    {
        if (tablero[i, col] == 1)
        {
            return false;
        }
        if (tablero[row, i] == 1)
        {
            return false;
        }
    }
    // Verificar la diagonal superior izquierda
    for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
    {
        if (tablero[i, j] == 1)
        {
            return false;
        }
    }

    // Verificar la diagonal superior derecha
    for (int i = row, j = col; i >= 0 && j < tablero.GetLength(1); i--, j++)
    {
        if (tablero[i, j] == 1)
        {
            return false;
        }
    }

    // Verificar la diagonal inferior izquierda
    for (int i = row, j = col; i < tablero.GetLength(0) && j >= 0; i++, j--)
    {
        if (tablero[i, j] == 1)
        {
            return false;
        }
    }

    // Verificar la diagonal inferior derecha
    for (int i = row, j = col; i < tablero.GetLength(0) && j < tablero.GetLength(1); i++, j++)
    {
        if (tablero[i, j] == 1)
        {
            return false;
        }
    }

    return true;
}

void Imprimir(int[,] tablero)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"[{tablero[i,j]}], ");
        }
        Console.WriteLine();
    }
}

