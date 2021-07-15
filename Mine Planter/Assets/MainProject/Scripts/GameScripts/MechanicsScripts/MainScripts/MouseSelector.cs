using System.Collections.Generic;
using UnityEngine;

public class MouseSelector : MonoBehaviour, IManualCellSelector
{
    IColliderGetter colliderGetter;

    private void Awake()
    {
        colliderGetter = GetComponent<IColliderGetter>();
    }


    public Transform GetCell()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var hit = colliderGetter.GetCollider(mousePoint);

            if (hit != null)
            {
                return hit.transform;
            }
        }

        return null;
    }
}
