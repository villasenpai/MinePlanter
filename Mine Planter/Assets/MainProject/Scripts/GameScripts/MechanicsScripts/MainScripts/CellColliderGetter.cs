using UnityEngine;

public class CellColliderGetter : MonoBehaviour, IColliderGetter
{
    public Collider2D GetCollider(Vector2 selectionPoint)
    {
        return Physics2D.OverlapCircle(selectionPoint, 0.1f);
    }
}
