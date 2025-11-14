namespace AssetTool
{
    [JsonAsset("DestructibleActor")]
    public class ADestructibleActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}