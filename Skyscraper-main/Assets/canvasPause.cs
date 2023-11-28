using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class canvasPause : MonoBehaviour {


    public GameObject painelMenu;
    void Start() {

         painelMenu.SetActive(false);
    }
 
    void Update() {
          Debug.Log(" fui chamado");



          // Verifica se o botão principal foi pressionado
            if (Input.GetKey(KeyCode.Z))
            {
                // Chama a função desejada
                PrimaryButtonPressed();
            }
    

    }
 
    void PausarJogo() {
        if (Time.timeScale == 0) {
            Time.timeScale = 1;
            painelMenu.SetActive(true);
        } else if (Time.timeScale == 1) {
            painelMenu.SetActive(false);
            Time.timeScale = 0;
        }
    }

     void PrimaryButtonPressed()
    {
        // Coloque aqui o código para a ação que você deseja realizar
        Debug.Log("Botão principal do controle de VR (por exemplo, botão 'A') pressionado! Chamando a função...");
        PausarJogo();
    }
 
}
