namespace AssetTool
{
    [JsonAsset("NavMeshBoundsVolume")]
    public class ANavMeshBoundsVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}