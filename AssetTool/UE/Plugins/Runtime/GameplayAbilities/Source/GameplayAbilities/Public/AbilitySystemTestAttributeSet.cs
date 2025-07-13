namespace AssetTool
{
    [JsonAsset("AbilitySystemTestAttributeSet")]
    public class UAbilitySystemTestAttributeSet : UAttributeSet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}