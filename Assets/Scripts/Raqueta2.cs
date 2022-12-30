using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta2 : MonoBehaviour
{
    public float velocidadMovimiento;

    private void FixedUpdate()
    {
        float v2 = Input.GetAxisRaw("Vertical2");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v2 * velocidadMovimiento);
    }
}
