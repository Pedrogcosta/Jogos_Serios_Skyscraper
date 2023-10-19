using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float elevatorSpeed = 3.0f; // Velocidade do elevador
    private Transform cameraTransform; // Referência à transformação da câmera
    // Start is called before the first frame update
    void Start()
    {
        // Encontre a câmera na cena. Certifique-se de que a câmera tenha um "tag" apropriado no Unity.
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Verifique a posição da câmera
        Vector3 cameraPosition = cameraTransform.position;        

        // Verifique se a câmera está dentro da área especificada
        //if (cameraPosition.x <= -712f && cameraPosition.x >= -714f && cameraPosition.z >= 515f && cameraPosition.y <= 517f)
        //{
            // A câmera está dentro da área, mova o elevador para cima
        //    if(transform.position.y<82){
        //        transform.Translate(Vector3.up * elevatorSpeed * Time.deltaTime);
                //cameraTransform.Translate(Vector3.up * elevatorSpeed * Time.deltaTime);
        //    }
        //}
    }
}
