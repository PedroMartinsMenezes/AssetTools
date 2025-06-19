namespace AssetTool
{
    public class FDeprecatedSerializedPackedNormal : ITransferible
    {
        public UInt32 Packed;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Packed);
            return this;
        }
    }
}
