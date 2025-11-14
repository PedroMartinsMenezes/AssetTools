namespace AssetTool
{
    [JsonAsset("FleshActor")]
    public class AFleshActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}