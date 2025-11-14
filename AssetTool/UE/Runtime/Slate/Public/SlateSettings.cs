namespace AssetTool
{
    [JsonAsset("SlateSettings")]
    public class USlateSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}