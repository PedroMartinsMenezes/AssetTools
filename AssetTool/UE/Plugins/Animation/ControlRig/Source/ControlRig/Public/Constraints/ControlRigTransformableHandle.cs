namespace AssetTool
{
    [JsonAsset("TransformableControlHandle")]
    public class UTransformableControlHandle : UTransformableHandle
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}