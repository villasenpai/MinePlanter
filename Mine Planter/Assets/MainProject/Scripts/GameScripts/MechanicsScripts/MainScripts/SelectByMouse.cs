using UnityEngine;

public class SelectByMouse : MonoBehaviour, ICellSelection
{
    public Transform GetCell()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePoint, Vector3.forward);

            if (hit.collider != null)
            {
                return hit.collider.transform;
            }
        }

        return null;
    }
}
