using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameController gameController;�@//�Q�[���Ǘ�

    private void OnMouseDown()
    {
        gameController.HitTarget();

        Destroy(gameObject);
    }
}
