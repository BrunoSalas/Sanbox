using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacoBoxeo : MonoBehaviour
{
    public float life;


    public void RecibirDaņo(float valor)
    {
        life -= valor;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
