using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameController GameController
    {
        get => gameController.GetComponent<GameController>(); 
    }
    private void OnMouseDown()
    {
        //gameController.HitTarget();

        Destroy(gameObject);
    }
}
