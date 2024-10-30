namespace AssetTool
{
    [JsonAsset("TransformableHandle")]
    public class UTransformableHandle : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TransformableComponentHandle")]
    public class UTransformableComponentHandle : UTransformableHandle
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}