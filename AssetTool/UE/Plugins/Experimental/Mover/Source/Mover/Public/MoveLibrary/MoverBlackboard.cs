namespace AssetTool
{
    [JsonAsset("MoverBlackboard")]
    public class UMoverBlackboard : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}