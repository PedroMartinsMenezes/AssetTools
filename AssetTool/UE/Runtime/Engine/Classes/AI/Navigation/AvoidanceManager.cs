namespace AssetTool
{
    [JsonAsset("AvoidanceManager")]
    public class UAvoidanceManager : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}