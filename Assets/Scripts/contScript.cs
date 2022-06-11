using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class contScript : MonoBehaviour
{
    public string Continente;
    public string Paises;
    public TextMeshProUGUI textElement;
    public TextMeshProUGUI textElement2;
    



    // Start is called before the first frame update
    void Start()
    {
        textElement.text = Continente; 
        textElement2.text = Paises; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
