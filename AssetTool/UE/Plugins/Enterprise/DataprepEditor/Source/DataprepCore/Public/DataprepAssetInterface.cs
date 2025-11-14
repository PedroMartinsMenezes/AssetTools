namespace AssetTool
{
    [JsonAsset("DataprepRecipeInterface")]
    public class UDataprepRecipeInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepAssetInterface")]
    public class UDataprepAssetInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}