using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_plat1 : MonoBehaviour
{
    public Sliding_v slider;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            slider.enabled = true;
        }
    }
}
