namespace AssetTool
{
    [JsonAsset("DrawFrustumComponent")]
    public class UDrawFrustumComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}