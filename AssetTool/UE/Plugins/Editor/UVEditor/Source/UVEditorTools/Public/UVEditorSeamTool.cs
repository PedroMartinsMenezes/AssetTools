namespace AssetTool
{
    [JsonAsset("UVEditorSeamToolProperties")]
    public class UUVEditorSeamToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorSeamToolBuilder")]
    public class UUVEditorSeamToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorSeamTool")]
    public class UUVEditorSeamTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}