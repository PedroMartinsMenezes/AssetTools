namespace AssetTool
{
    [JsonAsset("ArrayProperty")]
    public class UArrayProperty : UProperty
    {
        public UInt32 Inner;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Inner);
            return this;
        }
    }
}
