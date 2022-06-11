using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class frontiersScript : MonoBehaviour
{
    public string Fronteras;
    public TextMeshProUGUI textElement;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = Fronteras; 
    }
}
