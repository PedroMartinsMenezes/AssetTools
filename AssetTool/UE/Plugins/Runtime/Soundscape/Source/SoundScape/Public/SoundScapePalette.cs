namespace AssetTool
{
    [JsonAsset("SoundscapePalette")]
    public class USoundscapePalette : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ActiveSoundscapePalette")]
    public class UActiveSoundscapePalette : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}