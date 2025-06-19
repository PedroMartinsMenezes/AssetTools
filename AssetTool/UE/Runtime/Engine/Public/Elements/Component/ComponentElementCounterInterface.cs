namespace AssetTool
{
    [JsonAsset("ComponentElementCounterInterface")]
    public class UComponentElementCounterInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}