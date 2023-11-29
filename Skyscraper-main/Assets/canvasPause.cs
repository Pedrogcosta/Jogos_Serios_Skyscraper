using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class canvasPause : MonoBehaviour {


    public Canvas menu;
    void Start() {
        menu = GameObject.FindGameObjectWithTag("Panico").GetComponent<Canvas>();
    }
 
    void Update() {
          



          // Verifica se o botão principal foi pressionado
            if (Input.GetKey(KeyCode.Z))
            {
                // Chama a função desejada
                PrimaryButtonPressed();
            }
    

    }
 
    public void PausarJogo() {
        Debug.Log("pausar jogo");
        menu.enabled = !menu.enabled;
    }

     void PrimaryButtonPressed()
    {
        // Coloque aqui o código para a ação que você deseja realizar
        Debug.Log("Botão principal do controle de VR (por exemplo, botão 'A') pressionado! Chamando a função...");
        PausarJogo();
    }
 
}
