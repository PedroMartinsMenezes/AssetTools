namespace AssetTool
{
    [JsonAsset("NavTestRenderingComponent")]
    public class UNavTestRenderingComponent : UDebugDrawComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}