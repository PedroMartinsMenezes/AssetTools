namespace AssetTool
{
    [JsonAsset("GeometryCacheActor")]
    public class AGeometryCacheActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}