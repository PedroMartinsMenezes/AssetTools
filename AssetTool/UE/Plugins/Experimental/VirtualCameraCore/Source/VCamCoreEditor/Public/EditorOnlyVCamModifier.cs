namespace AssetTool
{
    [JsonAsset("EditorOnlyVCamModifier")]
    public class UEditorOnlyVCamModifier : UVCamBlueprintModifier
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}