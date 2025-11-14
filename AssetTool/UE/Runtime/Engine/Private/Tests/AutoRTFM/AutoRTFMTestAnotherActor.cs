namespace AssetTool
{
    [JsonAsset("AutoRTFMTestAnotherActor")]
    public class AAutoRTFMTestAnotherActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}