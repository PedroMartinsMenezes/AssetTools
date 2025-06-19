namespace AssetTool
{
    [JsonAsset("NavMeshRenderingComponent")]
    public class UNavMeshRenderingComponent : UDebugDrawComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}