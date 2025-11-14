namespace AssetTool
{
    [JsonAsset("UVEditorGridProperties")]
    public class UUVEditorGridProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorUDIMProperties")]
    public class UUVEditorUDIMProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorMode")]
    public class UUVEditorMode : UEdMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}