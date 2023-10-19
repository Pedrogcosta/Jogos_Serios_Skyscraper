using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoor : MonoBehaviour
{
    public float doorSpeed = 3.0f; // Velocidade da porta
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

        // Calcula a distância euclidiana entre os dois objetos.
        float distancia = Vector3.Distance(cameraPosition, transform.position);

        if(distancia <= 5){
            if(transform.localPosition.z < 2.7068099f){
                transform.localPosition = new Vector3(0.04f, 0.12f, transform.localPosition.z + (doorSpeed * Time.deltaTime));
            }
            if(cameraPosition.x <= -712f && cameraPosition.x >= -714f && cameraPosition.z >= 515f && cameraPosition.y <= 517f){
                if(transform.localPosition.z > 0.7068099){
                    transform.localPosition = new Vector3(0.04f, 0.12f, transform.localPosition.z - (doorSpeed * Time.deltaTime));
                }           
            }
        }
            
        
    }
}
