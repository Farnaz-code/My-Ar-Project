using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SustainabilitySphere : MonoBehaviour
{
 

    private Color32 color00 = new Color32(118, 255, 105, 87);
    private Color32 color01 = new Color32(197, 255, 105, 87);
    private Color32 color02 = new Color32(255, 242, 105, 87);
    private Color32 color03 = new Color32(255, 183, 105, 87);
    private Color32 color04 = new Color32(255, 112, 105, 87);
    private Color32 color05 = new Color32(255, 105, 124, 20);


  

    // Update is called once per frame
    void Update()
    {
        ChangingSpheresMaterial();
    }





    void ChangingSpheresMaterial()
    {
        //material sustainability Sphere
        if (this.gameObject.CompareTag("Material"))
        {
            TweeningColor(Manager.Instance.currentMaterialSustainabilityRank);


            }

        //Earth sphere
        if (this.gameObject.CompareTag("Social"))
        {
            TweeningColor(Manager.Instance.currentSocialSustainabilityRank);


        }

        //donation sphere
        if (this.gameObject.CompareTag("Donation"))
        {
            TweeningColor(Manager.Instance.currentDonationRank);
         
        }
    }

   





    void TweeningColor(int rank)
    {
        switch(rank)
        { 
       case 0:
                
                LeanTween.color(transform.GetChild(0).gameObject, color00, 0.3f);
                LeanTween.color(transform.GetChild(1).gameObject, color00, 0.3f);




                break;
        case 1:
                
                LeanTween.color(transform.GetChild(0).gameObject, color01, 0.3f);
                LeanTween.color(transform.GetChild(1).gameObject, color01, 0.3f);

                break;
        case 2:
                
                LeanTween.color(transform.GetChild(0).gameObject, color02, 0.3f);
                LeanTween.color(transform.GetChild(1).gameObject, color02, 0.3f);

                break;
        case 3:

                
                LeanTween.color(transform.GetChild(0).gameObject, color03, 0.3f);
                LeanTween.color(transform.GetChild(1).gameObject, color03, 0.3f);
                break;
        case 4:

                
                LeanTween.color(transform.GetChild(0).gameObject, color04, 0.3f);
                LeanTween.color(transform.GetChild(1).gameObject, color04, 0.3f);
                break;
        case 5:
                
                LeanTween.color(transform.GetChild(0).gameObject, color05, 0.3f);
                LeanTween.color(transform.GetChild(1).gameObject, color05, 0.3f);
                break;

        }
    }
}
