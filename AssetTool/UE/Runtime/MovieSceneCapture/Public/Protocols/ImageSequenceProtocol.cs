namespace AssetTool
{
    [JsonAsset("ImageSequenceProtocol")]
    public class UImageSequenceProtocol : UFrameGrabberProtocol
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompressedImageSequenceProtocol")]
    public class UCompressedImageSequenceProtocol : UImageSequenceProtocol
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ImageSequenceProtocol_BMP")]
    public class UImageSequenceProtocol_BMP : UImageSequenceProtocol
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ImageSequenceProtocol_PNG")]
    public class UImageSequenceProtocol_PNG : UCompressedImageSequenceProtocol
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ImageSequenceProtocol_JPG")]
    public class UImageSequenceProtocol_JPG : UCompressedImageSequenceProtocol
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ImageSequenceProtocol_EXR")]
    public class UImageSequenceProtocol_EXR : UImageSequenceProtocol
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}