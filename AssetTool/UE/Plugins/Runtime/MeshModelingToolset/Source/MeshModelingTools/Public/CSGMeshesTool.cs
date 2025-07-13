namespace AssetTool
{
    [JsonAsset("CSGMeshesToolProperties")]
    public class UCSGMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TrimMeshesToolProperties")]
    public class UTrimMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CSGMeshesTool")]
    public class UCSGMeshesTool : UBaseCreateFromSelectedTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CSGMeshesToolBuilder")]
    public class UCSGMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}