namespace AssetTool
{
    [JsonAsset("EditorOnlyModifierFactory")]
    public class UEditorOnlyModifierFactory : UVCamObjectWithInputFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}