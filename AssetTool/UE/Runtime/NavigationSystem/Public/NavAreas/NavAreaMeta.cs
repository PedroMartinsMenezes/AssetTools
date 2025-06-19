namespace AssetTool
{
    [JsonAsset("NavAreaMeta")]
    public class UNavAreaMeta : UNavArea
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}