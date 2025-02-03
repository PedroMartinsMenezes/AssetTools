namespace AssetTool
{
    ///[TransferibleStruct("AnimNotifyEvent")]
    ///public class FAnimNotifyEvent : FAnimLinkableElement
    ///{
    ///    public override ITransferible Move(Transfer transfer)
    ///    {
    ///        return base.Move(transfer);
    ///    }
    ///}

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

    #region RawAnimSequenceTrack
    [TransferibleStruct("RawAnimSequenceTrack")]
    public class FRawAnimSequenceTrackSelector : ITransferibleSelector
    {
        public const string StructName = "RawAnimSequenceTrack";

        public object Move(Transfer transfer, int num, object value)
        {
            //@@@ [Mystery]
            if ((num - 24) % 40 == 0)
                return value.ToObject<FRawAnimSequenceTrack>().Move(transfer);
            else
                return GlobalObjects.Transfer.MoveTags(value.ToObject<List<object>>(), 0, null);
        }

        ///C:\src\UnrealEngine\Engine\Source\Runtime\Engine\Public\Animation\AnimTypes.h
        ///bool Serialize(FArchive& Ar)
        ///{
        ///    Ar.UsingCustomVersion(FUE5ReleaseStreamObjectVersion::GUID);
        ///    // Previously generated content was saved without bulk array serialization, so have to rely on UProperty serialization until resaved
        ///    if (Ar.CustomVer(FUE5ReleaseStreamObjectVersion::GUID) < FUE5ReleaseStreamObjectVersion::RawAnimSequenceTrackSerializer)
        ///    {
        ///        return false;
        ///    }
        ///    Ar << *this;
        ///    return true;
        ///}
    }

    public class FRawAnimSequenceTrack : ITransferible
    {
        public const string StructName = "RawAnimSequenceTrack";

        public List<FVector3f> PosKeys;
        public List<FQuat4f> RotKeys;
        public List<FVector3f> ScaleKeys;

        [Location("FArchive& operator<<(FArchive& Ar, FRawAnimSequenceTrack& T)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(FVector3f.SIZE);
            transfer.Move(ref PosKeys);

            transfer.Move(FQuat4f.SIZE);
            transfer.Move(ref RotKeys);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ANIM_SUPPORT_NONUNIFORM_SCALE_ANIMATION))
            {
                transfer.Move(FVector3f.SIZE);
                transfer.Move(ref ScaleKeys);
            }

            return this;
        }
    }
    #endregion
}