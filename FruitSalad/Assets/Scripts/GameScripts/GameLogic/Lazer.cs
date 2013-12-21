using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }
}
