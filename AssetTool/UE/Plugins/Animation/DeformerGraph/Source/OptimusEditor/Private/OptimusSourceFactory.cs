namespace AssetTool
{
    [JsonAsset("OptimusSourceFactory")]
    public class UOptimusSourceFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}