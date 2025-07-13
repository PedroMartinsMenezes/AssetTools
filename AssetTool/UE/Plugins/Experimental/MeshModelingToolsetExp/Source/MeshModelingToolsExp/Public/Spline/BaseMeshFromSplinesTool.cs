namespace AssetTool
{
    [JsonAsset("BaseMeshFromSplinesTool")]
    public class UBaseMeshFromSplinesTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BaseMeshFromSplinesToolBuilder")]
    public class UBaseMeshFromSplinesToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}