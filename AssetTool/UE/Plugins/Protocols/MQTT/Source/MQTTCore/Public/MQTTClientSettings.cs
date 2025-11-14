namespace AssetTool
{
    [JsonAsset("MQTTClientSettings")]
    public class UMQTTClientSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}