namespace AssetTool
{
    [JsonAsset("DestructibleActor")]
    public class ADestructibleActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}