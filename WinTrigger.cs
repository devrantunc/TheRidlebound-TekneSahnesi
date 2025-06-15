using UnityEngine;
using UnityEngine.UI; 

public class WinTrigger : MonoBehaviour
{
    public Text winText; 

    void Start()
    {
        winText.gameObject.SetActive(false); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            winText.text = "Kazand�n!";
            winText.gameObject.SetActive(true);
        }
    }
}