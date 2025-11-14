namespace AssetTool
{
    [TransferableStruct("AnimSyncMarker")]
    public class FAnimSyncMarker : ITransferable
    {
        public UScriptStruct Struct = new();

        [Location("bool FAnimSyncMarker::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            Struct.SerializeTaggedProperties(transfer);
            return this;
        }
    }

    [TransferableStruct("RawAnimSequenceTrack")]
    public class FRawAnimSequenceTrack : ITransferable
    {
        public List<FVector3f> PosKeys;
        public List<FQuat4f> RotKeys;
        public List<FVector3f> ScaleKeys;
        public Dictionary<string, object> Tags;

        [Location("bool Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.RawAnimSequenceTrackSerializer)
            {
                Tags ??= new();
                transfer.MoveTags(Tags);
                return this;
            }
            else
            {
                return MoveStream(transfer);
            }
        }

        [Location("FArchive& operator<<(FArchive& Ar, FRawAnimSequenceTrack& T)")]
        public ITransferable MoveStream(Transfer transfer)
        {
            transfer.MoveConst(FVector3f.SIZE);
            transfer.Move(ref PosKeys);
            transfer.MoveConst(FQuat4f.SIZE);
            transfer.Move(ref RotKeys);
            if (transfer.Supports.VER_UE4_ANIM_SUPPORT_NONUNIFORM_SCALE_ANIMATION)
            {
                transfer.MoveConst(FVector3f.SIZE);
                transfer.Move(ref ScaleKeys);
            }
            return this;
        }
    }
}