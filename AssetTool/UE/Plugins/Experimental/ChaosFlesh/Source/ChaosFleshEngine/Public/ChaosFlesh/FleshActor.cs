namespace AssetTool
{
    [JsonAsset("FleshActor")]
    public class AFleshActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}