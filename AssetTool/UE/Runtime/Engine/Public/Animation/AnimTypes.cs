namespace AssetTool
{
    [TransferibleStruct("AnimSyncMarker")]
    public class FAnimSyncMarker : ITransferible
    {
        public UScriptStruct Struct = new();

        [Location("bool FAnimSyncMarker::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            Struct.SerializeTaggedProperties(transfer);
            return this;
        }
    }

    [TransferibleStruct("RawAnimSequenceTrack")]
    public class FRawAnimSequenceTrack : ITransferible
    {
        public List<FVector3f> PosKeys;
        public List<FQuat4f> RotKeys;
        public List<FVector3f> ScaleKeys;
        public List<object> Tags;

        [Location("bool Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.RawAnimSequenceTrackSerializer)
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
        public ITransferible MoveStream(Transfer transfer)
        {
            transfer.Move(FVector3f.SIZE);
            transfer.Move(ref PosKeys);
            transfer.Move(FQuat4f.SIZE);
            transfer.Move(ref RotKeys);
            if (Supports.VER_UE4_ANIM_SUPPORT_NONUNIFORM_SCALE_ANIMATION)
            {
                transfer.Move(FVector3f.SIZE);
                transfer.Move(ref ScaleKeys);
            }
            return this;
        }
    }
}