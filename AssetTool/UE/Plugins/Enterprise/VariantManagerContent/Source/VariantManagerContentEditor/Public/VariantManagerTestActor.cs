namespace AssetTool
{
    [JsonAsset("VariantManagerTestActor")]
    public class AVariantManagerTestActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}