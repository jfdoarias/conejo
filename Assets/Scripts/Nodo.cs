using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodo
{

    private string name, marca, jerarquia;
    private Vector3 scale, position;
    private GameObject objetoNodo;


    public Nodo(){
        
    }

    public string Name//propiedad
    {
        get { return name; }
        set { name = value; }
    }

    public Vector3 Position//propiedad
    {
        get { return position; }
        set { position = value; }
    }

    public Vector3 Scale//propiedad
    {
        get { return scale; }
        set { scale = value; }
    }



    public string Marca//propiedad
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Jerarquia//propiedad
    {
        get { return jerarquia; }
        set { jerarquia = value; }
    }

    public GameObject ObjetoNodo{

        get {return objetoNodo;}
        set { objetoNodo = value; }
    }
       
        
}
