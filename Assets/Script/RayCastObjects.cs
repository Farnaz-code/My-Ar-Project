using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastObjects : MonoBehaviour
{
    



    void Update()
    {

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider != null)
                {
                    

                    IThouchable thouchable = hit.collider.GetComponent<IThouchable>();

                    if(thouchable != null)
                    {
                        thouchable.ReactToThouch();
                    }

                    
                }
            }
        }


    }


}
