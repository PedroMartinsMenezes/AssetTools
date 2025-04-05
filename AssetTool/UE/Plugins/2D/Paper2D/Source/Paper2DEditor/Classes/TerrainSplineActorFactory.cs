namespace AssetTool
{
    [JsonAsset("TerrainSplineActorFactory")]
    public class UTerrainSplineActorFactory : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}