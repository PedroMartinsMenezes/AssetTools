namespace AssetTool
{
    [JsonAsset("GeometryCollectionActor")]
    public class AGeometryCollectionActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}