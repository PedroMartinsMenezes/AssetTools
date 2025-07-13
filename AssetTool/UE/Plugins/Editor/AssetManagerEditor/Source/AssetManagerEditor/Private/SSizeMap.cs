namespace AssetTool
{
    [JsonAsset("SizeMapSettings")]
    public class USizeMapSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}