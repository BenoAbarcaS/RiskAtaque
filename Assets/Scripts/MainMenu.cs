using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void onClickDebug()
    {
        SceneManager.LoadScene("Debug");
    }
    public void onClickStartNewGame()
    {
        Debug.Log("A�n no est� programado");
    }
    public void onClickEditMap ()
    {
        Debug.Log("A�n no est� programado");
    }
}
