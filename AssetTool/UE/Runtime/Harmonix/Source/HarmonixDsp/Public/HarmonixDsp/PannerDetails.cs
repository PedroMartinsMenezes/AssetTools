namespace AssetTool
{
    [TransferibleStruct("PannerDetails")]
    public class FPannerDetails : ITransferible
    {
        public uint8 Version;
        public EPannerMode Mode;
        public ESpeakerChannelAssignment ChannelAssignment;
        public float Pan;
        public float EdgeProximity;

        [Location("bool FPannerDetails::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Version);
            transfer.MoveEnum(ref Mode);
            if (Mode == EPannerMode.DirectAssignment)
            {
                transfer.MoveEnum(ref ChannelAssignment);
            }
            else
            {
                transfer.Move(ref Pan);
                transfer.Move(ref EdgeProximity);
            }
            return this;
        }
    }

    public enum EPannerMode : uint8
    {
        LegacyStereo,
        Stereo,
        Surround,
        PolarSurround,
        DirectAssignment,
        Num,
        Invalid
    }

    public enum ESpeakerChannelAssignment : uint8
    {
        LeftFront,
        RightFront,
        Center,
        LFE,
        LeftSurround,
        RightSurround,
        LeftRear,
        RightRear,
        FrontPair,
        CenterAndLFE,
        SurroundPair,
        RearPair,
        AmbisonicW,
        AmbisonicX,
        AmbisonicY,
        AmbisonicZ,
        AmbisonicWXPair,
        AmbisonicYZPair,
        UnspecifiedMono,
        Num,
        Invalid
    }
}