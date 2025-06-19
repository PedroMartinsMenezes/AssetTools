namespace AssetTool
{
    [JsonAsset("NavMeshBoundsVolume")]
    public class ANavMeshBoundsVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}