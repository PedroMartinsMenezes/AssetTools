namespace AssetTool
{
    public class FTypedParameter : ITransferable
    {
        public uint8 Version;
        public FVariant Value;

        [Location("bool FTypedParameter::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Version);
            transfer.Move(ref Value);
            return this;
        }
    }
}
