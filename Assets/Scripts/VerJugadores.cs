using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VerJugadores : MonoBehaviour
{
    public int NroJ;
    public TextMeshProUGUI J0;
    public string j0;
    public TextMeshProUGUI J1;
    public string j1;
    public TextMeshProUGUI J2;
    public string j2;
    public TextMeshProUGUI J3;
    public string j3;
    public TextMeshProUGUI J4;
    public string j4;
    public TextMeshProUGUI J5;
    public string j5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (NroJ==3)
        {
            J0.text = j0;
            J1.text = j1;
            J2.text = j2;
        }
        if (NroJ==4)
        {
            J0.text = j0;
            J1.text = j1;
            J2.text = j2;
            J3.text = j3;
        }
        if (NroJ==5)
        {
            J0.text = j0;
            J1.text = j1;
            J2.text = j2;
            J3.text = j3;
            J4.text = j4;
        }
        if (NroJ==6)
        {
            J0.text = j0;
            J1.text = j1;
            J2.text = j2;
            J3.text = j3;
            J4.text = j4;
            J5.text = j5;
        }
    }
}
