namespace AssetTool
{
    [JsonAsset("UsdStageActor")]
    public class AUsdStageActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}