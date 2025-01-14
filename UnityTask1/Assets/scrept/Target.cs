using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameController gameController;Å@//ÉQÅ[ÉÄä«óù

    private void OnMouseDown()
    {
        gameController.HitTarget();

        Destroy(gameObject);
    }
}
