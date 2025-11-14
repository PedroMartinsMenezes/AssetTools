namespace AssetTool
{
    [JsonAsset("AnimDataModel")]
    public class UAnimDataModel : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}