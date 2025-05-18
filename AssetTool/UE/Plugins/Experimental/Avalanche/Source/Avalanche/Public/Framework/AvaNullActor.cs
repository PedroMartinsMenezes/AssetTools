namespace AssetTool
{
    [JsonAsset("AvaNullActor")]
    public class AAvaNullActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}