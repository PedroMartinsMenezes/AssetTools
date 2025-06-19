namespace AssetTool
{
    [JsonAsset("ReimportVectorFieldStaticFactory")]
    public class UReimportVectorFieldStaticFactory : UVectorFieldStaticFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}