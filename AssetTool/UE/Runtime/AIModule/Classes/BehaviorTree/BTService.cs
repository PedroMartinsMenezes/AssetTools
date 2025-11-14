namespace AssetTool
{
    [JsonAsset("BTService")]
    public class UBTService : UBTAuxiliaryNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}