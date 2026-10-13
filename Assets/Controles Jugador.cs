using UnityEngine;

public class ControlesJugador : MonoBehaviour
{
    public float speed = 5;
    public float distancia = 3;
    public Transform cristal;
    public Transform cristal1;
    public Transform cristal2;
    public Transform cristal3;
    public Transform cristal4;

    private bool mensajeMostrado = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Avanzar
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += Vector3.forward * Time.deltaTime * speed;
        //Retroceder
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += Vector3.back * Time.deltaTime * speed;
        //Moverse a la derecha
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * Time.deltaTime * speed;
        //Moverse a la izquierda
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Vector3.left * Time.deltaTime * speed;


        //Impulso rapido a la derecha
        if (Input.GetMouseButtonDown(1))
            transform.Translate(Vector3.right * distancia);
        //Impulso rapido a la izquierda
        if (Input.GetMouseButtonDown(0))
            transform.Translate(Vector3.left * distancia);

        //conprobacion para destruir el objeto segun la distancia si sigue activo
        if (cristal != null && Vector3.Distance(transform.position, cristal.position) < 1) 
            Destroy(cristal.gameObject);
        //conprobacion para destruir el objeto segun la distancia si sigue activo
        if (cristal1 != null && Vector3.Distance(transform.position, cristal1.position) < 1) 
            Destroy(cristal1.gameObject);
        //conprobacion para destruir el objeto segun la distancia si sigue activo
        if (cristal2 != null && Vector3.Distance(transform.position, cristal2.position) < 1) 
            Destroy(cristal2.gameObject);
        //conprobacion para destruir el objeto segun la distancia si sigue activo
        if (cristal3 != null && Vector3.Distance(transform.position, cristal3.position) < 1) 
            Destroy(cristal3.gameObject);
        //conprobacion para destruir el objeto segun la distancia si sigue activo
        if (cristal4 != null && Vector3.Distance(transform.position, cristal4.position) < 1) 
            Destroy(cristal4.gameObject);

        //Mensaje de finalizacion al comprobar si se consiguieron todos los cristales
        if (cristal == null && cristal1 == null && cristal2 == null && cristal3 == null && cristal4 == null && !mensajeMostrado)
        {
            print("Felicidades, conseguiste todos los cristales!! ");
            mensajeMostrado = true;
        }

    }
}
