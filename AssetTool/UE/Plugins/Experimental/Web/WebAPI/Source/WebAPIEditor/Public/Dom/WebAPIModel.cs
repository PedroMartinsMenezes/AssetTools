namespace AssetTool
{
    [JsonAsset("WebAPIProperty")]
    public class UWebAPIProperty : UWebAPIModelBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPIModel")]
    public class UWebAPIModel : UWebAPIModelBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}