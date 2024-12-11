namespace AssetTool
{
    [JsonAsset("SoundNodeWavePlayer")]
    public class USoundNodeWavePlayer : USoundNodeAssetReferencer
    {
        public UInt32 SoundWave;

        [Location("void USoundNodeWavePlayer::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.HardSoundReferences)
            {
                transfer.Move(ref SoundWave);
            }
            return this;
        }
    }
}