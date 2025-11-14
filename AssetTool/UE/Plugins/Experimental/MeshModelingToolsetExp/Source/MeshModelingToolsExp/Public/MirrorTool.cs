namespace AssetTool
{
    [JsonAsset("MirrorToolBuilder")]
    public class UMirrorToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MirrorToolProperties")]
    public class UMirrorToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MirrorOperatorFactory")]
    public class UMirrorOperatorFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MirrorToolActionPropertySet")]
    public class UMirrorToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MirrorTool")]
    public class UMirrorTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}