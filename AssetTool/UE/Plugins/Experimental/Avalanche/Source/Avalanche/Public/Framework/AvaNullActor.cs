namespace AssetTool
{
    [JsonAsset("AvaNullActor")]
    public class AAvaNullActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}