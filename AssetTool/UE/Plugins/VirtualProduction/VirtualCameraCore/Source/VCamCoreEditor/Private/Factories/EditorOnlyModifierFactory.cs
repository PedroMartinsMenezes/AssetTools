namespace AssetTool
{
    [JsonAsset("EditorOnlyModifierFactory")]
    public class UEditorOnlyModifierFactory : UVCamObjectWithInputFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}