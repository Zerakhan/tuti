using UnityEngine;

public class director : MonoBehaviour
{
    public GameObject NPC;
    public static director instance = null;              //Instancia para saber que es el único
    public Transform [][] Rutas;                    // Para el numero de rutas
    public Transform [] Ruta1;                      // Para cada ruta, un número distinto
    public Transform[] Ruta2;
    public Transform[] Ruta3;
    public Transform[] Ruta4;
    public Transform[] Ruta5;
    public Transform[] Ruta6;
    public Transform[] Ruta7;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

    }
    void PatrullasParaTodos ()
    {
        //No me acuerdo de como hacer esto, pero es básicamente un Random.Range (0, X) para seleccionar un número y según el número, se asigna la patrulla.
        //llamar a un NPC y darle su patrulla asignada según el número del Random.Range
    }
    
    void RecibirNuevaPatrulla()
    {
        //No tengo esto muy claro, pero este es para recibir la info del final de patrulla y re mandar una patrulla.
        //Una vez re mandada, el director vuelve a la inactividad.
    }
}