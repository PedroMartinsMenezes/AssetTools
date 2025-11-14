namespace AssetTool
{
    [JsonAsset("NavTestRenderingComponent")]
    public class UNavTestRenderingComponent : UDebugDrawComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}