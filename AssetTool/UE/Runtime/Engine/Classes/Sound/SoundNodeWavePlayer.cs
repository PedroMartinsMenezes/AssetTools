namespace AssetTool
{
    [JsonAsset("SoundNodeWavePlayer")]
    public class USoundNodeWavePlayer : USoundNode
    {
        public UInt32 SoundWave;

        [Location("void USoundNodeWavePlayer::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.HardSoundReferences)
            {
                transfer.Move(ref SoundWave);
            }
            return this;
        }
    }
}