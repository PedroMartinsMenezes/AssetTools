namespace AssetTool
{
    [JsonAsset("NavAreaBase")]
    public class UNavAreaBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}