namespace AssetTool
{
    [JsonAsset("FavoriteFilterContainer")]
    public class UFavoriteFilterContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}