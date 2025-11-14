namespace AssetTool
{
    [JsonAsset("EditorOnlyVCamModifier")]
    public class UEditorOnlyVCamModifier : UVCamBlueprintModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}