namespace AssetTool
{
    [JsonAsset("DestructibleActor")]
    public class ADestructibleActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}