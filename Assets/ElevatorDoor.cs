using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoor : MonoBehaviour
{
    public float doorSpeed = 2.0f;
    private Transform cameraTransform;
    public GameObject botao;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        botao = GameObject.Find("speaker grill");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = cameraTransform.position;   
        float distanciaBotao = Vector3.Distance(botao.transform.position, cameraPosition);
        float distancia = Vector3.Distance(cameraPosition, transform.position);

        if(distancia <= 5){
            
            if(distanciaBotao <= 1.1f && botao.transform.position.x < cameraPosition.x){
                //fecha a porta quando o player entra
                if(transform.localPosition.z > 0.7068099){
                    print("fechando a porta");
                    transform.localPosition = new Vector3(0.04f, 0.12f, transform.localPosition.z - (doorSpeed * Time.deltaTime));
                }
            }
            else{
                //abre a porta quando o player chega perto
                if(transform.localPosition.z < 2.7068099f){
                    transform.localPosition = new Vector3(0.04f, 0.12f, transform.localPosition.z + (doorSpeed * Time.deltaTime));
                }
            }
        }
            
        
    }
}
