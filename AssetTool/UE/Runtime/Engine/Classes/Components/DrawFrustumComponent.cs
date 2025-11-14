namespace AssetTool
{
    [JsonAsset("DrawFrustumComponent")]
    public class UDrawFrustumComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}