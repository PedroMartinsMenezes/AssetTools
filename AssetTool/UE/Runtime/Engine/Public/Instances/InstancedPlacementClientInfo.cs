namespace AssetTool
{
    [JsonAsset("InstancedPlacemenClientSettings")]
    public class UInstancedPlacemenClientSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}