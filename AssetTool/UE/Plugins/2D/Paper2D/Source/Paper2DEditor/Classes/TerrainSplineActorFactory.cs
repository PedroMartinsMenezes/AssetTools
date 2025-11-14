namespace AssetTool
{
    [JsonAsset("TerrainSplineActorFactory")]
    public class UTerrainSplineActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}