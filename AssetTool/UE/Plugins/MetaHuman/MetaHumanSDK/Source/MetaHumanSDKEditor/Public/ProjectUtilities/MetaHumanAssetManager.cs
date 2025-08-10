namespace AssetTool
{
    [JsonAsset("MetaHumanAssetManager")]
    public class UMetaHumanAssetManager : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}