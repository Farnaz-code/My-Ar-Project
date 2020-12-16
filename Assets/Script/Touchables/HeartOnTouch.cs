using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartOnTouch : MonoBehaviour, IThouchable
{

    bool liked;

    private void Awake()
    {
        liked = false;
    }
    public void ReactToThouch()
    {
        if (!liked)
        {
            LeanTween.color(this.gameObject, Color.red, 1f);
            gameObject.GetComponent<ParticleSystem>().Play();
            liked = true;
        }
        else
        {
            LeanTween.color(this.gameObject, Color.white, 0.4f);
            liked = false;
        }
    }


}
