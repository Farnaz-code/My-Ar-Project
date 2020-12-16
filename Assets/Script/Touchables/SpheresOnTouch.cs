using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpheresOnTouch : MonoBehaviour, IThouchable
{

    [SerializeField] CanvasGroup banner;
    [SerializeField] GameObject informationImage;
float destination;
    float homePlace;


    private bool canvasIsActive;



    private void Start()
    {
        canvasIsActive = false;
        homePlace = informationImage.transform.position.y;
        destination = homePlace - 0.08f;
      
    }


    public void ReactToThouch()
    {
        
        if (!canvasIsActive)
        {
            LeanTween.alphaCanvas(banner, 1, 1f).setOnComplete(MovingOn);
            canvasIsActive = true;

        }
        else
        {
            LeanTween.moveY(informationImage, homePlace, 0.5f).setOnComplete(Disappearing);
            canvasIsActive = false;
        }
    }



    void MovingOn()
    {
        LeanTween.moveY(informationImage, destination, 1f);
    }
    private void Disappearing()
    {
        LeanTween.alphaCanvas(banner, 0, 1f);

    }
}
