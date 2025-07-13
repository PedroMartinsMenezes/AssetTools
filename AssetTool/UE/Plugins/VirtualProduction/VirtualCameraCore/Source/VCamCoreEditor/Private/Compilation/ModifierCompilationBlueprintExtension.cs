namespace AssetTool
{
    [JsonAsset("ModifierCompilationBlueprintExtension")]
    public class UModifierCompilationBlueprintExtension : UBlueprintExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}