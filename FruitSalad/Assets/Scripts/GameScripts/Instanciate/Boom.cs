using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rigidbody2D.AddForce(Vector2.right * 8);
    }

    void OnMouseOver()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject boomys = Instantiate(Resources.Load("Bullet")) as GameObject;
            
            boomys.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 1);
        }
    }
}
