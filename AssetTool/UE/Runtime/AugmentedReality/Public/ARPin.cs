namespace AssetTool
{
    [JsonAsset("ARPin")]
    public class UARPin : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}