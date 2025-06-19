namespace AssetTool
{
    [JsonAsset("EditorOnlyVCamModifier")]
    public class UEditorOnlyVCamModifier : UVCamBlueprintModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}