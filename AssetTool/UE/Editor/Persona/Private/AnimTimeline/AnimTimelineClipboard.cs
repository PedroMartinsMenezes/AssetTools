namespace AssetTool
{
    [JsonAsset("AnimCurveBaseCopyObject")]
    public class UAnimCurveBaseCopyObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FloatCurveCopyObject")]
    public class UFloatCurveCopyObject : UAnimCurveBaseCopyObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TransformCurveCopyObject")]
    public class UTransformCurveCopyObject : UAnimCurveBaseCopyObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VectorCurveCopyObject")]
    public class UVectorCurveCopyObject : UAnimCurveBaseCopyObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimTimelineClipboardContent")]
    public class UAnimTimelineClipboardContent : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}