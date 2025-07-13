namespace AssetTool
{
    [JsonAsset("AssetValidator_AssetReferenceRestrictions")]
    public class UAssetValidator_AssetReferenceRestrictions : UEditorValidatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}