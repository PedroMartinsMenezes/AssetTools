namespace AssetTool
{
    [JsonAsset("FocusFirstPlayerViewTargetPolicy")]
    public class UFocusFirstPlayerViewTargetPolicy : UGameplayViewTargetPolicy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}