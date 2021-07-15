using UnityEngine;

public class CellBombChecking : MonoBehaviour, IBombChecking
{
    [SerializeField] SpriteRenderer spriteRenderer;

    [SerializeField] Color correctColor, wrongColor;

    public void TurnCell()
    {

        if (GetComponent<ICellBomb>().isWithBomb)
        {
            spriteRenderer.color = correctColor;
        }
        else
        {
            spriteRenderer.color = wrongColor;
        }
    }
}
