namespace AssetTool
{
    [JsonAsset("MoverBlackboard")]
    public class UMoverBlackboard : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}