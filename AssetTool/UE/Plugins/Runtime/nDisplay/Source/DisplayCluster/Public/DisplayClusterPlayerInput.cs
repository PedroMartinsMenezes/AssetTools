namespace AssetTool
{
    [JsonAsset("DisplayClusterPlayerInput")]
    public class UDisplayClusterPlayerInput : UEnhancedPlayerInput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}