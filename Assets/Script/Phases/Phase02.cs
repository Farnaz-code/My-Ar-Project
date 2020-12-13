using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase02 : ItemBasePhase
{
    //Item at the middle of its life





    public override void EnteringPhase(Manager sceneManager)
    {
        ChangingVariables(sceneManager);
        ChangingModel(sceneManager);
    }

    






    private void ChangingVariables(Manager sceneManager)
    {
        sceneManager.currentSocialSustainabilityRank = sceneManager.arItem.socialSustainabilityRank[2];
        sceneManager.currenetSocialSustainabilityExplain = sceneManager.arItem.socialSustainabilityExplain[2];

        sceneManager.currentMaterialSustainabilityRank = sceneManager.arItem.materialSustainabilityRank[2];
        sceneManager.currentMaterialSustainabilityExplain = sceneManager.arItem.materialSustainabilityExplain[2];

        sceneManager.currentDonationRank = sceneManager.arItem.donationRank[2];
        sceneManager.currentDonationExplain = sceneManager.arItem.donationExplain[2];
    }


    private void ChangingModel(Manager sceneManager)
    {
        if (sceneManager.arItem.theModel.transform.childCount > 0)
        {

            switch (sceneManager.useFrequency)
            {
                case 0: //weekly wash
                    sceneManager.modelForItem.transform.GetChild(0).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(1).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(2).gameObject.SetActive(true);
                    sceneManager.modelForItem.transform.GetChild(3).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(4).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(5).gameObject.SetActive(false);

                    break;
                case 1: //monthly wash
                    sceneManager.modelForItem.transform.GetChild(0).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(1).gameObject.SetActive(true);
                    sceneManager.modelForItem.transform.GetChild(2).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(3).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(4).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(5).gameObject.SetActive(false);
                    break;
                case 2: //ocassionally
                    sceneManager.modelForItem.transform.GetChild(0).gameObject.SetActive(true);
                    sceneManager.modelForItem.transform.GetChild(1).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(2).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(3).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(4).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(5).gameObject.SetActive(false);
                    break;
            }


          

            
        }
    }
}
