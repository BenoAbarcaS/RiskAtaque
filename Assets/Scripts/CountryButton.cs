using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CountryButton : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    private CountryUIHandler ownerUIHandler;
    private int index;
    public void Init(string _name,CountryUIHandler ownerUIHandler, int index)
    {
        nameText.text = _name;
        this.ownerUIHandler = ownerUIHandler;
        this.index = index;
    }

    public void OnClick()
    {
        CountryHandler.instance.countryList.RemoveAt(index);
        ownerUIHandler.Refresh();
    }

}
