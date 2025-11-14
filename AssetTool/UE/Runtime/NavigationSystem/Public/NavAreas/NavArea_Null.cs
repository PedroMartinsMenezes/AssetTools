namespace AssetTool
{
    [JsonAsset("NavArea_Null")]
    public class UNavArea_Null : UNavArea
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}