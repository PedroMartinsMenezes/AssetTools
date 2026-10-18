namespace AssetTool
{
    [JsonAsset("ArrayProperty")]
    public class UArrayProperty : UProperty
    {
        public UInt32 Inner;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Inner);
            return this;
        }
    }
}
