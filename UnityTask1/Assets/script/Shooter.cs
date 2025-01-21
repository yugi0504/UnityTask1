using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public Camera mainCamera;
    public GameObject gameController;

    Target target;
    GameController gameControllerController;

    private void Start()
    {
        gameControllerController=gameController.GetComponent<GameController>();
            //target = targetGameObject.GetComponent<Target>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray=mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                target = hit.transform.GetComponent<Target>();
                if(target != null)
                {
                    gameControllerController.HitTarget();
                    //Destroy(target.gameObject);
                    Debug.Log("çÌèú");
                }

            }
        }   
    }
}
