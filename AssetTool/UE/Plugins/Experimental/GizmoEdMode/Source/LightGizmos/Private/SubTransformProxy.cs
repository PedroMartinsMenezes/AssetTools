namespace AssetTool
{
    [JsonAsset("SubTransformProxy")]
    public class USubTransformProxy : UTransformProxy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}