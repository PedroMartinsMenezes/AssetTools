namespace AssetTool
{
    [Location("void UAnimSequence::Serialize(FArchive& Ar)")]
    public class UAnimSequence : UAnimSequenceBase
    {
        public new const string TypeName = "AnimSequence";

        public FStripDataFlags StripFlags = new();
        public List<FRawAnimSequenceTrack> RawAnimationData;
        public List<FRawAnimSequenceTrack> SourceRawAnimationData_DEPRECATED;
        public byte[] CompressedAnimData;
        public FBool bSerializeCompressedData;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            StripFlags.Move(transfer);

            if (!StripFlags.IsEditorDataStripped())
            {
                RawAnimationData = [];
                RawAnimationData.Resize(transfer);
                RawAnimationData.ForEach(x => x.Move(transfer));

                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ANIMATION_ADD_TRACKCURVES) &&
                    !Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.RemovingSourceAnimationData))
                {
                    SourceRawAnimationData_DEPRECATED = [];
                    SourceRawAnimationData_DEPRECATED.Resize(transfer);
                    SourceRawAnimationData_DEPRECATED.ForEach(x => x.Move(transfer));
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