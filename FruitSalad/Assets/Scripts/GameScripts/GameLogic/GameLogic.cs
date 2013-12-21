using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {
        PlayerPrefs.SetInt("Points", 0);
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            
        }
    }

    

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 50, 50), "Points: "+ PlayerPrefs.GetInt("Points").ToString());
    }
}
