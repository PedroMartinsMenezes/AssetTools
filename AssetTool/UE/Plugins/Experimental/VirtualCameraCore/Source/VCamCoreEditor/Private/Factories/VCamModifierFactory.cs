namespace AssetTool
{
    [JsonAsset("VCamModifierFactory")]
    public class UVCamModifierFactory : UVCamObjectWithInputFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}