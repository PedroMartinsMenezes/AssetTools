namespace AssetTool
{
    [JsonAsset("UsdStageActor")]
    public class AUsdStageActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}