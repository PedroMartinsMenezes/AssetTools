namespace AssetTool
{
    [JsonAsset("NUTActor")]
    public class ANUTActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}