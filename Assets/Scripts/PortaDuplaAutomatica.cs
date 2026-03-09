using UnityEngine;

public class PortaDuplaAutomatica : MonoBehaviour
{
    public Animator portaDireita;
    public Animator portaEsquerda;
    public string nomeParametroAbrir = "Abrir";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (portaDireita != null)
                portaDireita.SetBool(nomeParametroAbrir, true);

            if (portaEsquerda != null)
                portaEsquerda.SetBool(nomeParametroAbrir, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (portaDireita != null)
                portaDireita.SetBool(nomeParametroAbrir, false);

            if (portaEsquerda != null)
                portaEsquerda.SetBool(nomeParametroAbrir, false);
        }
    }
}
