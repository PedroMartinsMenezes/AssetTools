namespace AssetTool
{
    [JsonAsset("NavMeshRenderingComponent")]
    public class UNavMeshRenderingComponent : UDebugDrawComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}