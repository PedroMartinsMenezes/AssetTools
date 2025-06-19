namespace AssetTool
{
    [JsonAsset("AnimDataModel")]
    public class UAnimDataModel : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}