namespace AssetTool
{
    [JsonAsset("World")]
    public class UWorld : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}