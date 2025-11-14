namespace AssetTool
{
    [JsonAsset("GameplayDebuggerRenderingComponent")]
    public class UGameplayDebuggerRenderingComponent : UDebugDrawComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}