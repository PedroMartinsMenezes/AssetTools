namespace AssetTool
{
    [JsonAsset("EQSRenderingComponent")]
    public class UEQSRenderingComponent : UDebugDrawComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}