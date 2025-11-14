namespace AssetTool
{
    [JsonAsset("TransformableHandle")]
    public class UTransformableHandle : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TransformableComponentHandle")]
    public class UTransformableComponentHandle : UTransformableHandle
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}