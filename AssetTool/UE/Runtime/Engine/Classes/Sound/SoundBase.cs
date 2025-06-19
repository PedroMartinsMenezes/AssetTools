namespace AssetTool
{
    [JsonAsset("SoundBase")]
    public class USoundBase : UObject
    {
        [Location("void USoundBase::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public ITransferible USoundBaseMove(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
