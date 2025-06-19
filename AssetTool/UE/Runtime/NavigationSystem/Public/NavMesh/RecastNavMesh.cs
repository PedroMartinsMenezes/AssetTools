namespace AssetTool
{
    [JsonAsset("RecastNavMesh")]
    public class ARecastNavMesh : ANavigationData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}