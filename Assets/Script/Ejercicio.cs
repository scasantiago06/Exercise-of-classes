using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    void Start()
    {
        PrimeraClase holaMundo = new PrimeraClase();
        holaMundo.HolaMundo();

        SegundaClase suma = new SegundaClase();
        suma.SumaLiterales(1,2);
    }
}

public class PrimeraClase
{
    public void HolaMundo()
    {
        Debug.Log("Hola Mundo");
    }
}

public class SegundaClase
{
    public void SumaLiterales(int numeroUno, int numeroDos)
    {
        Debug.Log(numeroUno + numeroDos);
    }
}

public class TerceraClase
{
    int variable1 = 1;
    int variable2 = 2;
    int variable3 = 3;
    int variable4 = 4;
    int variable5 = 5;
    int variable6 = 6;
    int variable7 = 7;
    int variable8 = 8;
    int variable9 = 9;
    int variable10 = 10;
    
    public void SumaDiezVariables()
    {
        Debug.Log(variable1 + variable2 + variable3 + variable4 + variable5 + variable6 + variable7 + variable8 + variable9 + variable10);
    }
}

public class CuartaClase
{
    int literal1 = 1;
    int literal2 = 2;
    int literal3 = 3;
    int literal4 = 4;
    int literal5 = 5;

    public void Promedio()
    {
        Debug.Log((literal1 + literal2 + literal3 + literal4 + literal5) / 5);
    }
}

public class QuintaClase
{

}
