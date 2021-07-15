using System.Collections.Generic;
using UnityEngine;

public interface IRandomCellSelector
{
    Transform GetCell(List<ICell> cells);
}
