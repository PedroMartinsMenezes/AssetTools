namespace AssetTool
{
    [JsonAsset("AnimSingleNodeInstance")]
    public class UAnimSingleNodeInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}