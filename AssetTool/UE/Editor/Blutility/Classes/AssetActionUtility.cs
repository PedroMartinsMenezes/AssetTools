namespace AssetTool
{
    [JsonAsset("AssetActionUtility")]
    public class UAssetActionUtility : UEditorUtilityObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}