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
                transfer.IsMoveStream = true;
                transfer.Move(ref RawAnimationData);
                transfer.IsMoveStream = false;
                if (Supports.VER_UE4_ANIMATION_ADD_TRACKCURVES && !Supports.RemovingSourceAnimationData)
                {
                    transfer.IsMoveStream = true;
                    transfer.Move(ref SourceRawAnimationData_DEPRECATED);
                    transfer.IsMoveStream = false;
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