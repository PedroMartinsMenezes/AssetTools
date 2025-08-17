namespace AssetTool
{
    [TransferibleStruct("TG_Variant")]
    public class FTG_Variant : ITransferible
    {
        public TVariant<TFloat, FLinearColor, FVector4f, FTG_Texture> Data;

        [Location("friend FArchive& operator<<(FArchive& Ar, FTG_Variant& D)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Data);
            return this;
        }
    }

    public class FTG_VariantArray : ITransferible
    {
        public List<FTG_Variant> Array;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Array);
            return this;
        }
    }
}
