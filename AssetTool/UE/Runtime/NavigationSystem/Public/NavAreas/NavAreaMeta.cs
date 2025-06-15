namespace AssetTool
{
    [JsonAsset("NavAreaMeta")]
    public class UNavAreaMeta : UNavArea
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}