namespace AssetTool
{
    [JsonAsset("AROriginActor")]
    public class AAROriginActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}