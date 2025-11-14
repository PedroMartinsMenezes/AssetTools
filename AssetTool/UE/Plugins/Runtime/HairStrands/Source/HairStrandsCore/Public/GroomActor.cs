namespace AssetTool
{
    [JsonAsset("GroomActor")]
    public class AGroomActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}