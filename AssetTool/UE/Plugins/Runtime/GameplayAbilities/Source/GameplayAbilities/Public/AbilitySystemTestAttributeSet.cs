namespace AssetTool
{
    [JsonAsset("AbilitySystemTestAttributeSet")]
    public class UAbilitySystemTestAttributeSet : UAttributeSet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}