namespace AssetTool
{
    [JsonAsset("NavArea")]
    public class UNavArea : UNavAreaBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}