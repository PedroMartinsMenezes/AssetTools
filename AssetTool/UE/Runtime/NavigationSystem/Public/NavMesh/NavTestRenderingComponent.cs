namespace AssetTool
{
    [JsonAsset("NavTestRenderingComponent")]
    public class UNavTestRenderingComponent : UDebugDrawComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}