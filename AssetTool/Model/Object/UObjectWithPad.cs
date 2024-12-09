namespace AssetTool
{
    [JsonAsset("UObjectWithPad")]
    public class UObjectWithPad : UObject
    {
        public UInt32 Pad1;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (GlobalObjects.CurrentObject.Size > 12)
            {
                transfer.Move(ref Pad1);
            }
            return this;
        }
    }
}
