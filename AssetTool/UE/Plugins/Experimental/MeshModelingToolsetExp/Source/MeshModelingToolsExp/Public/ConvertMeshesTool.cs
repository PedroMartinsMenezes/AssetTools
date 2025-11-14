namespace AssetTool
{
    [JsonAsset("ConvertMeshesToolBuilder")]
    public class UConvertMeshesToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConvertMeshesToolProperties")]
    public class UConvertMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConvertMeshesTool")]
    public class UConvertMeshesTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}