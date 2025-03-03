namespace AssetTool
{
    [JsonAsset("PCGWorldActor")]
    public class APCGWorldActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}