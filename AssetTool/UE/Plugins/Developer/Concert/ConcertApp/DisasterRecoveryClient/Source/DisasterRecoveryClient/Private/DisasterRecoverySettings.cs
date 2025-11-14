namespace AssetTool
{
    [JsonAsset("DisasterRecoverClientConfig")]
    public class UDisasterRecoverClientConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}