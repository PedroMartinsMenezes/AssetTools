namespace AssetTool
{
    [JsonAsset("PCGPointMatchAndSetSettings")]
    public class UPCGPointMatchAndSetSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}