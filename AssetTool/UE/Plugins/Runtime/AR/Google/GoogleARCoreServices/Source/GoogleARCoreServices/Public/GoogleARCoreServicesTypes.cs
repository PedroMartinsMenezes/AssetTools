namespace AssetTool
{
    [JsonAsset("CloudARPin")]
    public class UCloudARPin : UARPin
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}