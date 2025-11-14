namespace AssetTool
{
    [JsonAsset("CableActor")]
    public class ACableActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}