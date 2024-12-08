namespace AssetTool
{
    [JsonAsset("EnhancedPlayerInput")]
    public class UEnhancedPlayerInput : UPlayerInput
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}