namespace AssetTool
{
    [JsonAsset("SoundBase")]
    public class USoundBase : UObject
    {
        [Location("void USoundBase::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public UObject USoundBaseMove(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
