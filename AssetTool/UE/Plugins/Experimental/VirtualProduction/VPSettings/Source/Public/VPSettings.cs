namespace AssetTool
{
    [JsonAsset("VPSettings")]
    public class UVPSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}