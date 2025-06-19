namespace AssetTool
{
    [JsonAsset("AvaNullActor")]
    public class AAvaNullActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}