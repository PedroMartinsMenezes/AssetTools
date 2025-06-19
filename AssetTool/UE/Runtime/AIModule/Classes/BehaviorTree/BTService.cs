namespace AssetTool
{
    [JsonAsset("BTService")]
    public class UBTService : UBTAuxiliaryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}