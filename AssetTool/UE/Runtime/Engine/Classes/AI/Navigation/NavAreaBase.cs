namespace AssetTool
{
    [JsonAsset("NavAreaBase")]
    public class UNavAreaBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}