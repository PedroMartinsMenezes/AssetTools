namespace AssetTool
{
    [JsonAsset("RecastNavMesh")]
    public class ARecastNavMesh : ANavigationData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}