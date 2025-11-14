namespace AssetTool
{
    [JsonAsset("WorldLocationsConfig")]
    public class UWorldLocationsConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}