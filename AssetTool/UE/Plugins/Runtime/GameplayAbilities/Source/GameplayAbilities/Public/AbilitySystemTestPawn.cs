namespace AssetTool
{
    [JsonAsset("AbilitySystemTestPawn")]
    public class AAbilitySystemTestPawn : ADefaultPawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}