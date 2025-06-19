namespace AssetTool
{
    [JsonAsset("World")]
    public class UWorld : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}