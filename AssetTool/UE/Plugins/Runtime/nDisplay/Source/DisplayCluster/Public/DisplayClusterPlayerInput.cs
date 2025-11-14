namespace AssetTool
{
    [JsonAsset("DisplayClusterPlayerInput")]
    public class UDisplayClusterPlayerInput : UEnhancedPlayerInput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}