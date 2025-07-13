namespace AssetTool
{
    [JsonAsset("AutoRTFMTestAnotherActor")]
    public class AAutoRTFMTestAnotherActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}