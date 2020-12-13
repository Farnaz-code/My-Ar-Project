using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase03 : ItemBasePhase
{
    //Item at the middle of its life


    public override void EnteringPhase(Manager sceneManager)
    {
        ChangingVariables(sceneManager);
        ChangingModel(sceneManager);
    }

   







    private void ChangingVariables(Manager sceneManager)
    {
        sceneManager.currentSocialSustainabilityRank = sceneManager.arItem.socialSustainabilityRank[3];
        sceneManager.currenetSocialSustainabilityExplain = sceneManager.arItem.socialSustainabilityExplain[3];

        sceneManager.currentMaterialSustainabilityRank = sceneManager.arItem.materialSustainabilityRank[3];
        sceneManager.currentMaterialSustainabilityExplain = sceneManager.arItem.materialSustainabilityExplain[3];

        sceneManager.currentDonationRank = sceneManager.arItem.donationRank[3];
        sceneManager.currentDonationExplain = sceneManager.arItem.donationExplain[3];
    }



    private void ChangingModel(Manager sceneManager)
    {


        switch (sceneManager.useFrequency)
        {
            case 0: //weekly wash
                sceneManager.modelForItem.transform.GetChild(0).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(1).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(2).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(3).gameObject.SetActive(true);
                sceneManager.modelForItem.transform.GetChild(4).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(5).gameObject.SetActive(false);

                break;
            case 1: //monthly wash
                sceneManager.modelForItem.transform.GetChild(0).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(1).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(2).gameObject.SetActive(true);
                sceneManager.modelForItem.transform.GetChild(3).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(4).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(5).gameObject.SetActive(false);
                break;
            case 2: //ocassionally
                sceneManager.modelForItem.transform.GetChild(0).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(1).gameObject.SetActive(true);
                sceneManager.modelForItem.transform.GetChild(2).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(3).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(4).gameObject.SetActive(false);
                sceneManager.modelForItem.transform.GetChild(5).gameObject.SetActive(false);
                break;
        }


       
           

        
    }
}
