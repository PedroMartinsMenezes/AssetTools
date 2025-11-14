namespace AssetTool
{
    [JsonAsset("LineBatchComponent")]
    public class ULineBatchComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}