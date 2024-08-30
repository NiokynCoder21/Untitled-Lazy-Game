using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject circle;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (KeyManager.Instance.currentAmount > 0)
            {
                KeyManager.Instance.LossKey(-1);
                Destroy(circle);
            }
        }
    }
}
