namespace AssetTool
{
    [JsonAsset("UTBEditorBlueprint")]
    public class UUTBEditorBlueprint : UEditorUtilityBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}