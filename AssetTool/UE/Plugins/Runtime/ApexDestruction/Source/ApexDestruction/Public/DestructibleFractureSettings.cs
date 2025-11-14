namespace AssetTool
{
    [JsonAsset("DestructibleFractureSettings")]
    public class UDestructibleFractureSettings : UObject
    {
        public uint8[] Buffer;

        [Location("void UDestructibleFractureSettings::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Buffer);
            return this;
        }
    }
}