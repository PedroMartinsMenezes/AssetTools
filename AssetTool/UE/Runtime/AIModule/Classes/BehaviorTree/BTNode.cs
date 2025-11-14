namespace AssetTool
{
    [JsonAsset("BTNode")]
    public class UBTNode : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}