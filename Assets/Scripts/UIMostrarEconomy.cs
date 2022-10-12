using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIMostrarEconomy : MonoBehaviour
{
    [SerializeField]
    private Economy m_ElementAMostrar;
    public void ActualitzarValors()
    {
        GetComponent<TextMeshProUGUI>().text =
            m_ElementAMostrar.ValorActual + "/" + m_ElementAMostrar.ValorMax;
    }
}
