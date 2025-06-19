namespace AssetTool
{
    [JsonAsset("AvaScene")]
    public class AAvaScene : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}