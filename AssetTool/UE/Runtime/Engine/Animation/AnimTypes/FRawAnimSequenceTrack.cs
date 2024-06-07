namespace AssetTool
{
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
