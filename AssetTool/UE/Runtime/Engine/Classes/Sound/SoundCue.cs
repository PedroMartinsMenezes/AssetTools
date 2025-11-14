namespace AssetTool
{
    [JsonAsset("SoundCue")]
    public class USoundCue : USoundBase
    {
        public FStripDataFlags StripFlags;
        public UInt32 SoundCueGraph;

        [Location("void USoundCue::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT)
            {
                transfer.Move(ref StripFlags);
                if (!StripFlags.IsEditorDataStripped())
                {
                    transfer.Move(ref SoundCueGraph);
                }
            }
            return this;
        }
    }
}