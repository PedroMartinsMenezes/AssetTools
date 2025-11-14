namespace AssetTool
{
    [JsonAsset("FocusFirstPlayerViewTargetPolicy")]
    public class UFocusFirstPlayerViewTargetPolicy : UGameplayViewTargetPolicy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}