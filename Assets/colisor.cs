
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class colisor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou é um controlador XR
        XRController controller = other.GetComponent<XRController>();
        if (controller != null)
        {
            // O jogador entrou na área, faça o que for necessário, como mostrar uma mensagem
            MostrarMensagem("Bem-vindo à área!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Se necessário, lide com eventos quando o jogador sair da área
    }

    private void MostrarMensagem(string mensagem)
    {
        // Coloque aqui o código para mostrar a mensagem na tela, como usando UI Canvas
        Debug.Log(mensagem);
    }
}
