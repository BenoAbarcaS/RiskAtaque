using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryUIHandler : MonoBehaviour
{
    public GameObject countryButton;
    public Transform countryButtonsContainer;

    public void Start()
    {
        Refresh();
    }
    public void Refresh()
    {
        Clear();
        int i = 0;
        foreach (Country country in CountryHandler.instance.countryList)
        {
            GameObject _g = Instantiate(countryButton,countryButtonsContainer);
            _g.GetComponent<CountryButton>().Init(country.name, this,i);
            i++;
        }

    }
    private void Clear()
    {
        foreach (Transform _t in countryButtonsContainer)
        {
            Destroy(_t.gameObject);
        }
    }
}
