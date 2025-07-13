namespace AssetTool
{
    [JsonAsset("ConvertMeshesToolBuilder")]
    public class UConvertMeshesToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConvertMeshesToolProperties")]
    public class UConvertMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConvertMeshesTool")]
    public class UConvertMeshesTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}