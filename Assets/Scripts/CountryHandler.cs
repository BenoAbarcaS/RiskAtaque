using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryHandler : MonoBehaviour
{
    public List<Country> countryList = new List<Country>();


    public static CountryHandler instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            return;

        }
        Destroy(this.gameObject);
    }

}
