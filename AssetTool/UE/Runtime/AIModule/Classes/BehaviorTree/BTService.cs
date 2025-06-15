namespace AssetTool
{
    [JsonAsset("BTService")]
    public class UBTService : UBTAuxiliaryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}