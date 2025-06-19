namespace AssetTool
{
    [JsonAsset("ReimportTextureFactory")]
    public class UReimportTextureFactory : UTextureFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}