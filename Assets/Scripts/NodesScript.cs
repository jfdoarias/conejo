using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class NodesScript : MonoBehaviour
{


    public bool parahipocampoIzd;
    public bool t2Izq;
    //private GameObject sphere;
    //private GameObject sphere1;

    private Color colorActivate;
    private Color colorIntermediate;
    private Color colorUnactive;

    private Nodo[] arrayNodos;


    public enum nombreNodos{
        L_T2 = 3,
        L_PARAHIPOCAMMPUS = 0
    }




    // Use this for initialization



    void Start()
    {
        CrearNodos();
        InicializarNodo();
    
    }

    // Update is called once per frame
    void Update()
    {


    }



    //*****************************************************************



    void CrearNodos()
    {
        Nodo[] todosLosNodos = InicializarNodo();

        for (int i = 0; i < todosLosNodos.Length; i++){
            todosLosNodos[i].ObjetoNodo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            todosLosNodos[i].ObjetoNodo.tag = todosLosNodos[i].Marca;
            todosLosNodos[i].ObjetoNodo.transform.position = todosLosNodos[i].Position;
            todosLosNodos[i].ObjetoNodo.transform.localScale = todosLosNodos[i].Scale;
            todosLosNodos[i].ObjetoNodo.name = todosLosNodos[i].Name;
        }



    }
    //_____________________________________________________
    /*void Activacion()
    {
        colorActivate = new Color(1, 0, 0, 1);
        colorIntermediate = new Color(0.5f, 0.0f, 0.5f, 1.0f);
        colorUnactive = new Color(0.0f, 1.0f, 1.0f, 1.0f);


        if (t2Izq == true)
        {
            sphere1.GetComponent<Renderer>().material.color = colorActivate;
        }
        else
        {
            sphere1.GetComponent<Renderer>().material.color = colorUnactive;
        }


        if (parahipocampoIzd == true)
        {
            sphere.GetComponent<Renderer>().material.color = colorActivate;
        }
        else
        {
            sphere.GetComponent<Renderer>().material.color = colorUnactive;
        }
    }
*/
    //_________________________________________


    public Nodo[] InicializarNodo()

    {
        //Nodo nodo1 = new Nodo();

        arrayNodos = new Nodo[2];

            foreach ( nombreNodos nombre in Enum.GetValues(typeof(nombreNodos)))        {

                switch(nombre){
                    case nombreNodos.L_T2:
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)] = new Nodo();
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)].Name = "l_T2";
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)].Marca = "esfera";
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)].Position = new Vector3(5, 5, 0);
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)].Scale = new Vector3(.5f, .5f, .5f);
                    break;
                    case nombreNodos.L_PARAHIPOCAMMPUS:
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)] = new Nodo();
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)].Name = "l_parahipocammpus";
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)].Marca = "esfera";
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)].Position = new Vector3(0, 5, 0);
                    arrayNodos[Array.IndexOf(Enum.GetValues(nombre.GetType()), nombre)].Scale = new Vector3(.5f, .5f, .5f);
                    break;
                    default:
                    break;
                }

            
        }
        return arrayNodos;
    }

        /*
         * Algoritmo: 
         * 1. crear objetos-esferas en una posición específica, con un nombre específico. 
         *          a. CrearNodos();
         * 2. cambiar color de objeto si este es seleccionado
         *          b. Activacion();
         * 3. al seleccionar objeto generar conexión con nodo relacionado. //pendiente, probable LineRenderer.
         * 4. activar nodo seleccionado con color intermedio.
         * 5. controlar la cámara:
         *          a. CameraControlScript
         * 
         * 
         * 
         *
         * 
         * }
         * 
         * }
         * 
         * */



    
}
