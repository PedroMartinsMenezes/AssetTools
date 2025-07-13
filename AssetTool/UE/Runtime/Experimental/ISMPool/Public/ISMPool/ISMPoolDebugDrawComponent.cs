namespace AssetTool
{
    [JsonAsset("ISMPoolDebugDrawComponent")]
    public class UISMPoolDebugDrawComponent : UDebugDrawComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}