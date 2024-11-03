namespace AssetTool
{
    [JsonAsset("AnimSequence")]
    public class UAnimSequence : UAnimSequenceBase
    {
        public FStripDataFlags StripFlags = new();
        public List<FRawAnimSequenceTrack> RawAnimationData;
        public List<FRawAnimSequenceTrack> SourceRawAnimationData_DEPRECATED;
        public byte[] CompressedAnimData;
        public FBool bSerializeCompressedData;

        [Location("void UAnimSequence::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            StripFlags.Move(transfer);

            if (!StripFlags.IsEditorDataStripped())
            {
                transfer.Move(ref RawAnimationData);
                if (Supports.VER_UE4_ANIMATION_ADD_TRACKCURVES && !Supports.RemovingSourceAnimationData)
                {
                    transfer.Move(ref SourceRawAnimationData_DEPRECATED);
                }
            }

            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.MoveCompressedAnimDataToTheDDC))
            {
                transfer.Move(ref CompressedAnimData);
            }
            else
            {
                transfer.Move(ref bSerializeCompressedData);
                if (bSerializeCompressedData.Value)
                    transfer.Move(ref CompressedAnimData);
            }

            return this;
        }
    }
}