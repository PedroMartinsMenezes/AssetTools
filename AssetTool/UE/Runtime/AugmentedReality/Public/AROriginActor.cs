namespace AssetTool
{
    [JsonAsset("AROriginActor")]
    public class AAROriginActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}