namespace AssetTool
{
    [JsonAsset("Engine")]
    public class UEngine : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}