namespace AssetTool
{
    [JsonAsset("PCGPointMatchAndSetSettings")]
    public class UPCGPointMatchAndSetSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}