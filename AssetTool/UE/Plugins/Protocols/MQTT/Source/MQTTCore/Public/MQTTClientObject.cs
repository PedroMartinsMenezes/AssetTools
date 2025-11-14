namespace AssetTool
{
    [JsonAsset("MQTTSubscriptionObject")]
    public class UMQTTSubscriptionObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MQTTClientObject")]
    public class UMQTTClientObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}