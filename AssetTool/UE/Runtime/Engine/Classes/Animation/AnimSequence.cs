namespace AssetTool
{
    [JsonAsset("AnimSequence")]
    public class UAnimSequence : UAnimSequenceBase
    {
        public FStripDataFlags StripFlags;
        public List<FRawAnimSequenceTrack> RawAnimationData;
        public List<FRawAnimSequenceTrack> SourceRawAnimationData_DEPRECATED;
        public byte[] CompressedAnimData;
        public FBool bSerializeCompressedData;

        public UAnimSequence()
        {
            ArrayMovers.Add("Keys", (transfer, value) => value.ToObject<FRichCurveKey>(transfer).Move(transfer));
            ArrayMovers.Add("AnimationTrackNames", (transfer, value) => value.ToObject<FName>(transfer).Move(transfer));
            ArrayMovers.Add("CompressedTrackOffsets", (transfer, value) => value.ToObject<TInt32>(transfer).Move(transfer));
        }

        [Location("void UAnimSequence::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref StripFlags);

            if (!StripFlags.IsEditorDataStripped())
            {
                transfer.Move(ref RawAnimationData, (x) => x.MoveStream(transfer));
                if (transfer.Supports.VER_UE4_ANIMATION_ADD_TRACKCURVES && !transfer.Supports.RemovingSourceAnimationData)
                {
                    transfer.Move(ref SourceRawAnimationData_DEPRECATED, (x) => x.MoveStream(transfer));
                }
            }

            if (!transfer.Supports.MoveCompressedAnimDataToTheDDC)
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