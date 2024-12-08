namespace AssetTool
{
    [JsonAsset("FocusFirstPlayerViewTargetPolicy")]
    public class UFocusFirstPlayerViewTargetPolicy : UGameplayViewTargetPolicy
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}