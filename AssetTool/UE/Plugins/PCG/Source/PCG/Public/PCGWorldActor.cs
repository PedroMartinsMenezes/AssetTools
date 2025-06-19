namespace AssetTool
{
    [JsonAsset("PCGWorldActor")]
    public class APCGWorldActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}