namespace AssetTool
{
    [JsonAsset("XRCreativeTransformInteraction")]
    public class UXRCreativeTransformInteraction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}