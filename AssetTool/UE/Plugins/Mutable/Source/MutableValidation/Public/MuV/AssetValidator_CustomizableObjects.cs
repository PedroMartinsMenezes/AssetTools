namespace AssetTool
{
    [JsonAsset("AssetValidator_CustomizableObjects")]
    public class UAssetValidator_CustomizableObjects : UEditorValidatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}