using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray=mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                Target target= hit.transform.GetComponent<Target>();
                if(target != null)
                {
                    target.gameController.HitTarget();
                    Destroy(target.gameObject);
                }

            }
        }   
    }
}
