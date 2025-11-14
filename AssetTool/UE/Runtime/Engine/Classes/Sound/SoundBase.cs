namespace AssetTool
{
    [JsonAsset("SoundBase")]
    public class USoundBase : UObject
    {
        [Location("void USoundBase::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public ITransferable USoundBaseMove(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
