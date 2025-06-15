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
            winText.text = "Kazandýn!";
            winText.gameObject.SetActive(true);
        }
    }
}