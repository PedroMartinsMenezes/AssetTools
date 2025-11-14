namespace AssetTool
{
    [JsonAsset("XRCreativeTransformInteraction")]
    public class UXRCreativeTransformInteraction : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}