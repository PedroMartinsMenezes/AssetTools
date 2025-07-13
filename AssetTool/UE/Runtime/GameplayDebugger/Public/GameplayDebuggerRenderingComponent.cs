namespace AssetTool
{
    [JsonAsset("GameplayDebuggerRenderingComponent")]
    public class UGameplayDebuggerRenderingComponent : UDebugDrawComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}