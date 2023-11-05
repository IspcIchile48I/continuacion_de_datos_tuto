using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUi : MonoBehaviour
{
    public TextMeshProUGUI nombrefinal;

    void Start() { nombrefinal.text = MoinManager.Instance.nombreparaenviar; }





}
