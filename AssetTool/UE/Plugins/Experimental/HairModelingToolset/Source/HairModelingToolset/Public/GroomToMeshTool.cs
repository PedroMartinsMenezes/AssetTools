namespace AssetTool
{
    [JsonAsset("GroomToMeshToolBuilder")]
    public class UGroomToMeshToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroomToMeshToolProperties")]
    public class UGroomToMeshToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroomToMeshTool")]
    public class UGroomToMeshTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}