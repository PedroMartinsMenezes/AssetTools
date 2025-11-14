namespace AssetTool
{
    [JsonAsset("DynamicEntryBox")]
    public class UDynamicEntryBox : UDynamicEntryBoxBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}