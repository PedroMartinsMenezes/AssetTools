namespace AssetTool
{
    [JsonAsset("FleshActor")]
    public class AFleshActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}