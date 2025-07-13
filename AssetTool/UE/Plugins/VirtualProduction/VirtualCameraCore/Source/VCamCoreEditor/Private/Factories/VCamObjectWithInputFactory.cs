namespace AssetTool
{
    [JsonAsset("VCamObjectWithInputFactory")]
    public class UVCamObjectWithInputFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}