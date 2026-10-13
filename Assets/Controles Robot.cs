using Unity.VisualScripting;
using UnityEngine;

public class ControlesRobot : MonoBehaviour
{
    public float speed = 7;
    public float distancia = 3;
    public float velocidadGiroX = 200;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Avanzar
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime * speed;
        //Retroceder
        if (Input.GetKey(KeyCode.S))
            transform.position += -transform.forward * Time.deltaTime * speed;
        //girar a la derecha
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * Time.deltaTime * velocidadGiroX); 
        //girar a la izquierda
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up * Time.deltaTime * -velocidadGiroX);

        //Impulso rapido hacia adelante
        if (Input.GetKeyDown(KeyCode.Space))
            transform.Translate(Vector3.forward *distancia);

        
    }
}
