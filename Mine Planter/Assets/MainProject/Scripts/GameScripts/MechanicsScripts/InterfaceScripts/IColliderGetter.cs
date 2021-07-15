using UnityEngine;

public interface IColliderGetter
{
    Collider2D GetCollider(Vector2 mousePoint);
}
