namespace AssetTool
{
    [JsonAsset("EditorOnlyVCamModifierBlueprint")]
    public class UEditorOnlyVCamModifierBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}