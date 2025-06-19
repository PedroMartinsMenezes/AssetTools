namespace AssetTool
{
    [JsonAsset("NavArea_Null")]
    public class UNavArea_Null : UNavArea
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}