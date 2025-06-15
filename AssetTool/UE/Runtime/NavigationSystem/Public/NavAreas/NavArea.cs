namespace AssetTool
{
    [JsonAsset("NavArea")]
    public class UNavArea : UNavAreaBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}