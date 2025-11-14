namespace AssetTool
{
    [JsonAsset("SoundscapePalette")]
    public class USoundscapePalette : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ActiveSoundscapePalette")]
    public class UActiveSoundscapePalette : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}