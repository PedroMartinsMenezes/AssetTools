namespace AssetTool
{
    [JsonAsset("EQSRenderingComponent")]
    public class UEQSRenderingComponent : UDebugDrawComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}