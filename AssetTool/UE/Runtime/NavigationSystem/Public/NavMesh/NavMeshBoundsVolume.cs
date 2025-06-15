namespace AssetTool
{
    [JsonAsset("NavMeshBoundsVolume")]
    public class ANavMeshBoundsVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}