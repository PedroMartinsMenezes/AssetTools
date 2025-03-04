namespace AssetTool
{
    [JsonAsset("VCamModifierFactory")]
    public class UVCamModifierFactory : UVCamObjectWithInputFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}