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

        [Location("void UAnimSequence::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            if (ArrayMovers.Count == 0)
                ArrayMovers.Add("Keys", (transfer, value) => value.ToObject<FRichCurveKey>(transfer).Move(transfer));

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