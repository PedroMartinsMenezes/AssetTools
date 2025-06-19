namespace AssetTool
{
    [JsonAsset("TerrainSplineActorFactory")]
    public class UTerrainSplineActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}