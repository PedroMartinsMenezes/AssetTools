namespace AssetTool
{
    [JsonAsset("AvaBroadcast")]
    public class UAvaBroadcast : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}