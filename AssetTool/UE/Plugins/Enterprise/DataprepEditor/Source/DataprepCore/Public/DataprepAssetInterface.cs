namespace AssetTool
{
    [JsonAsset("DataprepRecipeInterface")]
    public class UDataprepRecipeInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepAssetInterface")]
    public class UDataprepAssetInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}