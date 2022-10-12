using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Economy m_Vida;
    [SerializeField]
    private GameEvent m_VidaEvent;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
            ModificaVida(-1);
    }
    private void ModificaVida(int v)
    {
        m_Vida.ValorActual += v;
        m_VidaEvent.Raise();
    }
}
