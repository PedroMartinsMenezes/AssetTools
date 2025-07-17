namespace AssetTool
{
    [JsonAsset("GameUIPolicy")]
    public class UGameUIPolicy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}