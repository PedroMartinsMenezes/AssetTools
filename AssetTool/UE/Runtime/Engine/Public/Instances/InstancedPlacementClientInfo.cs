namespace AssetTool
{
    [JsonAsset("InstancedPlacemenClientSettings")]
    public class UInstancedPlacemenClientSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}