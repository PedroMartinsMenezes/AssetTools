namespace AssetTool
{
    [JsonAsset("NavMeshRenderingComponent")]
    public class UNavMeshRenderingComponent : UDebugDrawComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}