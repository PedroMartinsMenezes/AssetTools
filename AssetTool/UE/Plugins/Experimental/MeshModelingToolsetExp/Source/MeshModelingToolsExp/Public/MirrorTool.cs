namespace AssetTool
{
    [JsonAsset("MirrorToolBuilder")]
    public class UMirrorToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MirrorToolProperties")]
    public class UMirrorToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MirrorOperatorFactory")]
    public class UMirrorOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MirrorToolActionPropertySet")]
    public class UMirrorToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MirrorTool")]
    public class UMirrorTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}