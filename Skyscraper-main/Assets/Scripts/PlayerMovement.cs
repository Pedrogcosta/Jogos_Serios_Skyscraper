using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Transform cameraTransform;
    private Transform originTransform;
    private Transform playerTransform;
    private Canvas initialCanvas;
    private Canvas instructionsCanvas;

    [HideInInspector] public float walkSpeed;
    [HideInInspector] public float sprintSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        originTransform = GameObject.FindGameObjectWithTag("XROrigin").transform;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        initialCanvas = GameObject.Find("MenuInicial").GetComponent<Canvas>();
        instructionsCanvas = GameObject.Find("Instrucoes").GetComponent<Canvas>();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        playerTransform.position = cameraTransform.position;
    }
    
    public void teleportPlayer(){
        Debug.Log("calling teleport player");
        Vector3 spawn = new Vector3(-706.73999f, 10.3000002f, 520.190002f);
        originTransform.position = spawn;
        playerTransform.position = spawn;
    }

    public void renderInstructions(){
        initialCanvas.enabled = !initialCanvas.enabled;
        instructionsCanvas.enabled = !instructionsCanvas.enabled;
    }

    public void killSimulation(){
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    /*
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        // Normalize the direction vector to ensure consistent speed in all directions
        //moveDirection.Normalize();

        // Move the player based on the direction and moveSpeed
        //rb.velocity = moveDirection * moveSpeed;
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        // limit velocity if needed
        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }*/
}