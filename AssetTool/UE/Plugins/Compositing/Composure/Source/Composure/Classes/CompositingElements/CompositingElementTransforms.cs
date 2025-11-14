namespace AssetTool
{
    [JsonAsset("CompositingPostProcessPass")]
    public class UCompositingPostProcessPass : UCompositingElementTransform
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompositingElementMaterialPass")]
    public class UCompositingElementMaterialPass : UCompositingPostProcessPass
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompositingTonemapPass")]
    public class UCompositingTonemapPass : UCompositingElementTransform
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MultiPassChromaKeyer")]
    public class UMultiPassChromaKeyer : UCompositingElementTransform
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MultiPassDespill")]
    public class UMultiPassDespill : UCompositingElementTransform
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AlphaTransformPass")]
    public class UAlphaTransformPass : UCompositingElementTransform
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompositingOpenColorIOPass")]
    public class UCompositingOpenColorIOPass : UCompositingElementTransform
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}