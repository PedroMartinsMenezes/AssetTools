namespace AssetTool
{
    [JsonAsset("WebAPICompositeModel")]
    public class UWebAPICompositeModel : UWebAPIModelBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}