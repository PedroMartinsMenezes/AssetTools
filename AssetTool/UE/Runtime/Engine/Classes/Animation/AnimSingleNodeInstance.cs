namespace AssetTool
{
    [JsonAsset("AnimSingleNodeInstance")]
    public class UAnimSingleNodeInstance : UAnimInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}