namespace AssetTool
{
    [JsonAsset("PCGWorldActor")]
    public class APCGWorldActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}