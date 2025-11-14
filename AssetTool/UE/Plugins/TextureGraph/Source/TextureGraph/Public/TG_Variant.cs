namespace AssetTool
{
    [TransferableStruct("TG_Variant")]
    public class FTG_Variant : ITransferable
    {
        public TVariant<TFloat, FLinearColor, FVector4f, FTG_Texture> Data;

        [Location("friend FArchive& operator<<(FArchive& Ar, FTG_Variant& D)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Data);
            return this;
        }
    }

    public class FTG_VariantArray : ITransferable
    {
        public List<FTG_Variant> Array;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Array);
            return this;
        }
    }
}
