namespace AssetTool
{
    [JsonAsset("TriangulateSplinesToolProperties")]
    public class UTriangulateSplinesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TriangulateSplinesTool")]
    public class UTriangulateSplinesTool : UBaseMeshFromSplinesTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TriangulateSplinesToolBuilder")]
    public class UTriangulateSplinesToolBuilder : UBaseMeshFromSplinesToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}