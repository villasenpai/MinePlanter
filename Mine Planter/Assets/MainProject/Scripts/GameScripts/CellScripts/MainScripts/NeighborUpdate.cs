using UnityEngine;

public class NeighborUpdate : MonoBehaviour, INeighborUpdate
{
    [SerializeField] Transform[] neighborCells;
    IColliderGetter colliderGetter;


    private void Awake()
    {
        colliderGetter = GetComponent<IColliderGetter>();
    }


    public void UpdateNeighbors()
    {

        for (int x = 0; x < neighborCells.Length; x++)
        {
            var hit = colliderGetter.GetCollider(neighborCells[x].position);

            if (hit == null)
                continue;

            hit.transform.GetComponent<IBombNeighborUpdate>().UpdateCell();
        }
    }
}

