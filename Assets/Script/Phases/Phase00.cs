using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase00 : ItemBasePhase
{
    //Item at the very beginning of its life

    public override void EnteringPhase(Manager sceneManager)
    {
        ChangingVariables(sceneManager);
        ChangingModel(sceneManager);

    }





    //changing the variables that change through life cycle of the product

    private void ChangingVariables(Manager sceneManager)
    {
        sceneManager.currentSocialSustainabilityRank = sceneManager.arItem.socialSustainabilityRank[0];
        sceneManager.currenetSocialSustainabilityExplain = sceneManager.arItem.socialSustainabilityExplain[0];

        sceneManager.currentMaterialSustainabilityRank = sceneManager.arItem.materialSustainabilityRank[0];
        sceneManager.currentMaterialSustainabilityExplain = sceneManager.arItem.materialSustainabilityExplain[0];

        sceneManager.currentDonationRank = sceneManager.arItem.donationRank[0];
        sceneManager.currentDonationExplain = sceneManager.arItem.donationExplain[0];
    }



    //activing the right child of the model based on the current phase and deactiving the rest
    private void ChangingModel(Manager sceneManager)
    {
        

        if (sceneManager.arItem.theModel.transform.childCount > 0)
        {

            switch (sceneManager.useFrequency)
            {
                case 0: //weekly wash
                    sceneManager.modelForItem.transform.GetChild(0).gameObject.SetActive(true);
                    sceneManager.modelForItem.transform.GetChild(1).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(2).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(3).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(4).gameObject.SetActive(false);
                    sceneManager.modelForItem.transform.GetChild(5).gameObject.SetActive(false);

                    break;
                case 1: //monthly wash
                    sceneManager.modelForItem.transform.GetChild(0).gameObject.SetActive(true);
                    sceneManager.modelForItem.transform.GetChild(1).gameObject.SetActive(false);
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
