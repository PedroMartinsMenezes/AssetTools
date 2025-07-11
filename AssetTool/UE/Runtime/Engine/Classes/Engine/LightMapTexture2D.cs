namespace AssetTool
{
    [JsonAsset("LightMapTexture2D")]
    public class ULightMapTexture2D : UTexture2D
    {
        public UInt32 Flags;

        [Location("void ULightMapTexture2D::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Flags);
            return this;
        }
    }
}