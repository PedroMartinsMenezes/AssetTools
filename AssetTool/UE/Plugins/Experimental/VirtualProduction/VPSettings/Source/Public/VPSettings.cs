namespace AssetTool
{
    [JsonAsset("VPSettings")]
    public class UVPSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}