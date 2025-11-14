namespace AssetTool
{
    [JsonAsset("NUTActor")]
    public class ANUTActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}