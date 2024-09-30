namespace AssetTool
{
    public class FDeprecatedSerializedPackedNormal
    {
        public UInt32 Packed;

        public void Move(Transfer transfer)
        {
            transfer.Move(ref Packed);
        }
    }
}
