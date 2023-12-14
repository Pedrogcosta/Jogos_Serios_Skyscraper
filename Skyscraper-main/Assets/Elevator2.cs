using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;

public class Elevator2 : MonoBehaviour
{
    public float elevatorSpeed = 3.0f;
    private Transform cameraTransform;
    public GameObject player;
    public GameObject botao;
    Collider playerCollider;
    Collider elevatorCollider;
    private bool playerInsideElevator = false;
    private bool buttonPressed = false;
    public GameObject porta;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GameObject.FindGameObjectWithTag("XROrigin").transform;
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
        if ((Input.GetKey(KeyCode.X) || buttonPressed) && playerInsideElevator)
            {
                if(transform.position.y<34.4){
                    transform.Translate(Vector3.up * elevatorSpeed * Time.deltaTime);
                    cameraTransform.Translate(Vector3.up * elevatorSpeed * Time.deltaTime);
                    player.transform.Translate(Vector3.up * elevatorSpeed * Time.deltaTime);
                }
            }
    }

    public void moveElevator()
    {
        if (playerInsideElevator)
        {
            buttonPressed = !buttonPressed;
        }
    }

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            playerInsideElevator = true;
        }
    }

    private void OnTriggerExit(Collider collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            playerInsideElevator = false;
        }
    }
}
