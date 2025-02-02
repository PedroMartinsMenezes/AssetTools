namespace AssetTool
{
    [JsonAsset("LightMapTexture2D")]
    public class ULightMapTexture2D : UTexture2D, ITransferible
    {
        public UInt32 Flags;

        [Location("void ULightMapTexture2D::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Flags);
            return this;
        }

        ITransferible ITransferible.Move(Transfer transfer)
        {
            return (ITransferible)Move(transfer);
        }
    }
}