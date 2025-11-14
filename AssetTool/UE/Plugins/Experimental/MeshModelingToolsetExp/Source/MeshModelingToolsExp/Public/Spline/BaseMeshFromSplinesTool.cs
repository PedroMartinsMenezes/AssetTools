namespace AssetTool
{
    [JsonAsset("BaseMeshFromSplinesTool")]
    public class UBaseMeshFromSplinesTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BaseMeshFromSplinesToolBuilder")]
    public class UBaseMeshFromSplinesToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}