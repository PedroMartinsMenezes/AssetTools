namespace AssetTool
{
    public class FDeprecatedSerializedPackedNormal : ITransferible
    {
        public UInt32 Packed;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Packed);
            return this;
        }
    }
}
