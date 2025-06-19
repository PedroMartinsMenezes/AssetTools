namespace AssetTool
{
    [JsonAsset("InstancedPlacemenClientSettings")]
    public class UInstancedPlacemenClientSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}