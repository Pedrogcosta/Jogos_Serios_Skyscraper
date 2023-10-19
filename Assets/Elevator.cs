using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float elevatorSpeed = 3.0f;
    private Transform cameraTransform;
    public GameObject player;
    public GameObject botao;
    Collider playerCollider;
    Collider elevatorCollider;
    private bool playerInsideElevator = false;
    public GameObject porta;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        player = GameObject.Find("Player");
        playerCollider = player.GetComponent<Collider>();
        elevatorCollider = GetComponent<Collider>();
        botao = GameObject.Find("speaker grill");
        porta = GameObject.Find("Door");
    }

    // Update is called once per frame
    void Update()
    {
        // Verifique a posição da câmera
        Vector3 cameraPosition = cameraTransform.position;
        float distanciaBotao = Vector3.Distance(botao.transform.position, cameraPosition);
        if (Input.GetKey(KeyCode.X))
            {
                    if(transform.position.y<34.4){
                        transform.Translate(Vector3.up * elevatorSpeed * Time.deltaTime);
                        //cameraTransform.Translate(Vector3.up * elevatorSpeed * Time.deltaTime);
                    }
            }        
    }
}
