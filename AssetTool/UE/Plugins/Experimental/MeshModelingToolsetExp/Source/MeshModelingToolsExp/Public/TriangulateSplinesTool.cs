namespace AssetTool
{
    [JsonAsset("TriangulateSplinesToolProperties")]
    public class UTriangulateSplinesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TriangulateSplinesTool")]
    public class UTriangulateSplinesTool : UBaseMeshFromSplinesTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TriangulateSplinesToolBuilder")]
    public class UTriangulateSplinesToolBuilder : UBaseMeshFromSplinesToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}