namespace AssetTool
{
    [JsonAsset("NavAreaBase")]
    public class UNavAreaBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}