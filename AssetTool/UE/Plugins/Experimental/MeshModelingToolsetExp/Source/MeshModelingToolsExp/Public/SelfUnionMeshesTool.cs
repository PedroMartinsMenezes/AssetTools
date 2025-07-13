namespace AssetTool
{
    [JsonAsset("SelfUnionMeshesToolProperties")]
    public class USelfUnionMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SelfUnionMeshesTool")]
    public class USelfUnionMeshesTool : UBaseCreateFromSelectedTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SelfUnionMeshesToolBuilder")]
    public class USelfUnionMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}