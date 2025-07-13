namespace AssetTool
{
    [JsonAsset("WorldLocationsConfig")]
    public class UWorldLocationsConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}