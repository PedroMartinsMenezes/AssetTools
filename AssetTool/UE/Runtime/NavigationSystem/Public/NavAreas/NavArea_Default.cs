namespace AssetTool
{
    [JsonAsset("NavArea_Default")]
    public class UNavArea_Default : UNavArea
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}