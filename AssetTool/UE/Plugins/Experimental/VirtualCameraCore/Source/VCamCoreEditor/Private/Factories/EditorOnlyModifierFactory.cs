namespace AssetTool
{
    [JsonAsset("EditorOnlyModifierFactory")]
    public class UEditorOnlyModifierFactory : UVCamObjectWithInputFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}