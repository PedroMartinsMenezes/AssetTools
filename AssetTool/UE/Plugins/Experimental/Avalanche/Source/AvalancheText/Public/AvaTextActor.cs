namespace AssetTool
{
    [JsonAsset("AvaTextActor")]
    public class AAvaTextActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}