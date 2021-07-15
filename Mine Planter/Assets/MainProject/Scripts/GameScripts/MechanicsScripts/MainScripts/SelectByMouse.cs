using UnityEngine;

public class SelectByMouse : MonoBehaviour, ICellSelection
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
