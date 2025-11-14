namespace AssetTool
{
    [JsonAsset("AConstraintsActor")]
    public class AConstraintsActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}