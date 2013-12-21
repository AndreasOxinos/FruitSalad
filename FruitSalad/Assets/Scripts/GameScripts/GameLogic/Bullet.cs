using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public int count;
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
        if(count > 0)
        {
            count--;
            rigidbody2D.AddForce(Vector2.right * count * 5); 
        }
        if (count < 0)
        {
            count++;
            rigidbody2D.AddForce(Vector2.right * count * 5);
        }
    }

    void AddForceCounting(int cou)
    {
        count = cou;
    }
}
