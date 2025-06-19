namespace AssetTool
{
    [JsonAsset("AvoidanceManager")]
    public class UAvoidanceManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}