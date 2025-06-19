namespace AssetTool
{
    [JsonAsset("EnhancedPlayerInput")]
    public class UEnhancedPlayerInput : UPlayerInput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}