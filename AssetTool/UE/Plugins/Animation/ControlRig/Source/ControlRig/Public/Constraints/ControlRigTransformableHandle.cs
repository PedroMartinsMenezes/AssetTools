namespace AssetTool
{
    [JsonAsset("TransformableControlHandle")]
    public class UTransformableControlHandle : UTransformableHandle
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}