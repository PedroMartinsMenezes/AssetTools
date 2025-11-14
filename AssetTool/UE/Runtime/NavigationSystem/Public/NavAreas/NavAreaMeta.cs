namespace AssetTool
{
    [JsonAsset("NavAreaMeta")]
    public class UNavAreaMeta : UNavArea
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}