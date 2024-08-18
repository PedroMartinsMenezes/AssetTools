namespace AssetTool
{
    public static class FRawAnimSequenceTrackSelector
    {
        public const string StructName = "RawAnimSequenceTrack";

        public static object Move(Transfer transfer, int num, object value)
        {
            if ((num - 24) % 40 == 0)
                return value.ToObject<FRawAnimSequenceTrack>().Move(transfer);
            else
                return GlobalObjects.Transfer.MoveTags(value.ToObject<List<object>>(), 0, null);
        }
    }

    [Location("FArchive& operator<<(FArchive& Ar, FRawAnimSequenceTrack& T)")]
    public class FRawAnimSequenceTrack
    {
        public const string StructName = "RawAnimSequenceTrack";

        public List<FVector3f> PosKeys = [];
        public List<FQuat4f> RotKeys = [];
        public List<FVector3f> ScaleKeys = [];

        public FRawAnimSequenceTrack Move(Transfer transfer)
        {
            transfer.Move(FVector3f.SIZE);
            PosKeys.Resize(transfer);
            PosKeys.ForEach(x => x.Move(transfer));

            transfer.Move(FQuat4f.SIZE);
            RotKeys.Resize(transfer);
            RotKeys.ForEach(x => x.Move(transfer));

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ANIM_SUPPORT_NONUNIFORM_SCALE_ANIMATION))
            {
                transfer.Move(FVector3f.SIZE);
                ScaleKeys.Resize(transfer);
                ScaleKeys.ForEach(x => x.Move(transfer));
            }

            return this;
        }
    }
}
