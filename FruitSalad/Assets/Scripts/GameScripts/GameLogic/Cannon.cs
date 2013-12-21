using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour
{
    private Vector3 mouse_pos;
    private Vector3 object_pos;
    public float angle;
    public int BulletsLeft;

    // Use this for initialization
    void Start()
    {
        BulletsLeft = 10;
    }

    // Update is called once per frame
    void Update()
    {

        Transform childTransform;
        if (Input.GetMouseButtonDown(0))
        {
            if (BulletsLeft > 0)
            {
                var pos = Input.mousePosition;
                pos.z = transform.position.z - Camera.main.transform.position.z;
                pos = Camera.main.ScreenToWorldPoint(pos);

                var q = Quaternion.FromToRotation(Vector3.up, pos - transform.position);
                foreach (Transform child in transform)
                {
                    if (child.name == "BOOM")
                    {
                        childTransform = child;
                        GameObject go = Instantiate(Resources.Load("Bullet"), new Vector3(childTransform.position.x, childTransform.position.y, childTransform.position.z), q) as GameObject;
                        //go.rigidbody2D.AddForce(Vector2.right * transform.position.x * 100);
                        go.SendMessage("AddForceCounting", (int)Mathf.CeilToInt(childTransform.position.x * 10));
                    }
                }
                BulletsLeft--;
            }


        }
    }

    void FixedUpdate()
    {
        //
        mouse_pos = Input.mousePosition;
        mouse_pos.z = 0.0f;
        object_pos = Camera.main.WorldToScreenPoint(transform.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg - 90;

        if (Mathf.Abs(angle) >= 90f && Mathf.Abs(angle) <= 270f)
        {
            Vector3 rotationVector = new Vector3(0, 0, angle);
            transform.rotation = Quaternion.Euler(rotationVector);
        }
    }

    void OnGUI()
    {
        GUI.skin = Resources.Load("UISkin") as GUISkin;
        GUI.Label(new Rect(200, 20, 100, 40), BulletsLeft.ToString());
    }
}
