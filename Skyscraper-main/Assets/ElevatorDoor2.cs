using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoor2 : MonoBehaviour
{
    public float doorSpeed = 2.0f;
    private Transform cameraTransform;
    public GameObject botao;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        botao = GameObject.Find("speaker grill 2");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = cameraTransform.position;   
        float distanciaBotao = Vector3.Distance(botao.transform.position, cameraPosition);
        float distancia = Vector3.Distance(cameraPosition, transform.position);

        if(distancia <= 5){
            Debug.Log("distancia botão: " + distanciaBotao);
            if(distanciaBotao <= 1.2f && botao.transform.position.x < cameraPosition.x){
                
                if(transform.position.y<73){
                    //fecha a porta quando o player entra
                    //xr origin position: Vector3(-541.630005,10.3000002,453.359985)
                    //elevator 2 position: Vector3(-672.179993,34.4900017,519)
                    //altura maxima: 73.16
                    if(transform.localPosition.z < 0.7068099){
                        print("fechando a porta");
                        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + (doorSpeed * Time.deltaTime));
                    }
                }
                else{
                   //abre a porta quando o elevador termina de subir
                 if(transform.localPosition.z > -1.2931901f){
                     transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - (doorSpeed * Time.deltaTime));
                 } 
                }
                
            }
            else{
                //abre a porta quando o player chega perto
                if(transform.localPosition.z > -1.2931901f){
                    transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - (doorSpeed * Time.deltaTime));
                }
            }
        }
            
        
    }
}
