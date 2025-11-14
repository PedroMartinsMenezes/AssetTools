namespace AssetTool
{
    [JsonAsset("EditorOnlyVCamModifierBlueprint")]
    public class UEditorOnlyVCamModifierBlueprint : UBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}