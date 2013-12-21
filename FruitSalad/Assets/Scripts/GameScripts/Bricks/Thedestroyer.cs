using UnityEngine;
using System.Collections;
using Assets.Scripts.Framework.Common;
public class Thedestroyer : MonoBehaviour
{
    private bool destroy;
    private AssassinObject assassinObject = new AssassinObject();
    public GameObject blabla;

    void Update()
    {
        if(destroy == true)
        {
            gameObject.SetActive(false);
            Destroy(gameObject, 0.5f);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(assassinObject.HitPoints>0)
        {
            assassinObject.HitPoints--;
        }
        
        if(assassinObject.HitPoints == 0 || assassinObject.HitPoints < 0)
        {
            destroy = true;
            GivePoints();
        }
       
    }

    private void GivePoints()
    {
        int Points = PlayerPrefs.GetInt("Points");
        Points += assassinObject.Points;
        PlayerPrefs.SetInt("Points", Points);
    }

    void OnGUI()
    {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        screenPosition.y = Screen.height - screenPosition.y;
        GUI.Label(new Rect(screenPosition.x + 10, screenPosition.y - 40, 100, 20), assassinObject.HitPoints.ToString());
    }
}
