using TMPro;

public interface IBombNeighborUpdate
{
    TextMeshProUGUI cellNeighborWithBombsText { get; set; }
    void UpdateCell();

}

