namespace AssetTool
{
    [JsonAsset("InterchangeAnimationTrackSetNode")]
    public class UInterchangeAnimationTrackSetNode : UInterchangeBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeAnimationTrackBaseNode")]
    public class UInterchangeAnimationTrackBaseNode : UInterchangeBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeAnimationTrackSetInstanceNode")]
    public class UInterchangeAnimationTrackSetInstanceNode : UInterchangeAnimationTrackBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeAnimationTrackNode")]
    public class UInterchangeAnimationTrackNode : UInterchangeAnimationTrackBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeTransformAnimationTrackNode")]
    public class UInterchangeTransformAnimationTrackNode : UInterchangeAnimationTrackNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeSkeletalAnimationTrackNode")]
    public class UInterchangeSkeletalAnimationTrackNode : UInterchangeAnimationTrackBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}