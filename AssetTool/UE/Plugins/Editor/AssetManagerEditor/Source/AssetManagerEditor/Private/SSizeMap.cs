namespace AssetTool
{
    [JsonAsset("SizeMapSettings")]
    public class USizeMapSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}