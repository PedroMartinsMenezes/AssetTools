namespace AssetTool
{
    public struct FDeprecatedSerializedPackedNormal : ITransferible
    {
        public UInt32 Packed;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Packed);
            return this;
        }
    }

    public struct FPackedNormal : ITransferible
    {
        public int8 X, Y, Z, W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }
}
