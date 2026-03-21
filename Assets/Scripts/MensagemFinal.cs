using UnityEngine;

public class MensagemFinal : MonoBehaviour
{
    public GameObject modal;
    public GameObject modalFinal;
    public void VerResultados()
    {
        modal.SetActive(false);
        modalFinal.SetActive(true);
    }
}
