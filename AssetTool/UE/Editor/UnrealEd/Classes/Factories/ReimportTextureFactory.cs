namespace AssetTool
{
    [JsonAsset("ReimportTextureFactory")]
    public class UReimportTextureFactory : UTextureFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}