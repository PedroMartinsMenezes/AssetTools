namespace AssetTool
{
    [JsonAsset("NameSpacedUserData")]
    public class  UNameSpacedUserData : UAssetUserData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataAssetLink")]
    public class  UDataAssetLink : UNameSpacedUserData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}