using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class StartMenuUi : MonoBehaviour
{
    
    public TMP_InputField ponernomames;

    
    
    
    public void startgame() 
    {
        MoinManager.Instance.nombreparaenviar = ponernomames.text;
        Debug.Log("hola" + ponernomames.text);
        SceneManager.LoadScene(1);}

}
