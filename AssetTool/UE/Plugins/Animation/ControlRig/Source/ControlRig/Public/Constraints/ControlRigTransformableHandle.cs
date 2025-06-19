namespace AssetTool
{
    [JsonAsset("TransformableControlHandle")]
    public class UTransformableControlHandle : UTransformableHandle
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}