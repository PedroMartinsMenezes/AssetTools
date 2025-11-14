namespace AssetTool
{
    [JsonAsset("VCamModifierFactory")]
    public class UVCamModifierFactory : UVCamObjectWithInputFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}