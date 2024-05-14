using UnityEngine;

public class Mill : HouseBlueprint
{
    public override void MakeEffect()
    {
        AddSquareEffect(Node, RadiusBlocker);
    }

    private void AddSquareEffect(Node startPoint, int countMultiply)
    {
        for (int i = startPoint.GetNodeIndex().x - countMultiply; i <= startPoint.GetNodeIndex().x + countMultiply; i++)
        {
            if (i < 0 || i > Node.BuildManager.Area.dimensions.x - 1)
                continue;

            for (int j = startPoint.GetNodeIndex().y - countMultiply; j <= startPoint.GetNodeIndex().y + countMultiply; j++)
            {
                if (j < 0 || j > Node.BuildManager.Area.dimensions.y - 1)
                    continue;

                Node.BuildManager.Area.m_Tiles[i, j].TakeNode().SetMillZone();
            }
        }
    }
}
