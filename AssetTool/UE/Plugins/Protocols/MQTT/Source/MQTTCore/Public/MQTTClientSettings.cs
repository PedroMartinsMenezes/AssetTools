namespace AssetTool
{
    [JsonAsset("MQTTClientSettings")]
    public class UMQTTClientSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}